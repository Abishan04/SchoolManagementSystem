using ClosedXML.Excel;
using SchoolManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.UI.Students
{

    public partial class ListStudentsForm : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        private DataTable studentTable; // Optional: cache your data for printing
        public ListStudentsForm()
        {
            InitializeComponent();
           

        }

        private void ListStudentsForm_Load(object sender, EventArgs e)
        {
            LoadStudentData();

        }
        private void LoadStudentData()
        {
            var dal = new StudentsDal();
            DataTable studentsTable = dal.GetAllStudents();
            dgvStudents.DataSource = studentsTable;
        }
        private void ExportToExcelWithClosedXML(DataGridView dgv)
        {
            var dt = (DataTable)dgv.DataSource;
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            using (var workbook = new XLWorkbook())
            {
                workbook.Worksheets.Add(dt, "Students");

                using (var saveFileDialog = new SaveFileDialog()
                {
                    Filter = "Excel Workbook|*.xlsx",
                    Title = "Save Excel File",
                    FileName = "StudentList.xlsx"
                })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Data exported successfully.", "Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnex_Click(object sender, EventArgs e)
        {
            ExportToExcelWithClosedXML(dgvStudents);

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string filter = txtsearch.Text.Trim();
            (dgvStudents.DataSource as DataTable).DefaultView.RowFilter =
                $"first_name LIKE '%{filter}%' OR last_name LIKE '%{filter}%' OR admission_no LIKE '%{filter}%'";

        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Segoe UI", 10);
            int startY = 100, offsetY = 0;

            e.Graphics.DrawString("Student List", new Font("Segoe UI", 14, FontStyle.Bold), Brushes.Black, 100, 50);

            foreach (DataRow row in studentTable.Rows)
            {
                string line = $"[{row["admission_no"]}] {row["first_name"]} {row["last_name"]}";
                e.Graphics.DrawString(line, font, Brushes.Black, 100, startY + offsetY);
                offsetY += 25;
            }
        }
        private void btnprint_Click(object sender, EventArgs e)
        {
            studentTable = (DataTable)dgvStudents.DataSource;

            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDocument,
                Width = 1000,
                Height = 800
            };

            printDocument.PrintPage += PrintDocument_PrintPage;
            previewDialog.ShowDialog();

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            ShowStudentsForm  showStudentsForm = new ShowStudentsForm();
            showStudentsForm.ShowDialog();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0) return;

            int studentId = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["id"].Value);
            var dal = new StudentsDal();

            if (MessageBox.Show("Are you sure you want to delete this student?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool deleted = dal.DeleteStudent(studentId);
                if (deleted)
                {
                    MessageBox.Show("Student deleted.");
                    LoadStudentData();
                }
            }

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to edit.");
                return;
            }

            int studentId = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["id"].Value);
            var dal = new StudentsDal();
            var student = dal.GetStudentById(studentId);

            using (var editForm = new EditStudentsForm(student))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadStudentData();
                }
            }
            LoadStudentData();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (var addForm = new CreateStudentsForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadStudentData();
                }
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            LoadStudentData();
        }
    }
}
