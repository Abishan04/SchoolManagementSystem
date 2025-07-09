using SchoolManagementSystem.DAL;
using SchoolManagementSystem.UI.Students;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.UI.Teachers
{
    public partial class ListTeachersForm : Form
    {
        private TeachersDal dal = new TeachersDal();
     
    private const string PlaceholderText = "Enter your name";

        public ListTeachersForm()
        {
            InitializeComponent();
            LoadTeacherData();
            SetPlaceholder();

        }
        private void SetPlaceholder()
        {
            txtSearch.Text = PlaceholderText;
            txtSearch.ForeColor = Color.Gray;
        }

        private void RemovePlaceholder()
        {
            if (txtSearch.Text == PlaceholderText)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }





        private void LoadTeacherData()
            {         
                DataTable dt = dal.GetAllTeachers();
                dgvTeachers.DataSource = dt;
            }

            private void btnAdd_Click(object sender, EventArgs e)
            {
                using (var addForm = new CreateTeachersForm())
                {
                    if (addForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadTeacherData();
                    }
                }
            }

            //private void btnEdit_Click(object sender, EventArgs e)
            //{
            //    if (dgvTeachers.SelectedRows.Count == 0)
            //    {
            //        MessageBox.Show("Please select a teacher to edit.");
            //        return;
            //    }

            //    int teacherId = Convert.ToInt32(dgvTeachers.SelectedRows[0].Cells["id"].Value);
            //    var teacher = dal.GetTeacherById(teacherId);

            //    using (var editForm = new EditTeachersForm(teacher))
            //    {
            //        if (editForm.ShowDialog() == DialogResult.OK)
            //        {
            //            LoadTeacherData();
            //        }
            //    }
            //}

            private void btnDelete_Click(object sender, EventArgs e)
            {
                if (dgvTeachers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a teacher to delete.");
                    return;
                }

                int teacherId = Convert.ToInt32(dgvTeachers.SelectedRows[0].Cells["id"].Value);
                var confirm = MessageBox.Show("Are you sure you want to delete this teacher?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    bool deleted = dal.DeleteTeacher(teacherId, Environment.UserName);
                    if (deleted)
                        LoadTeacherData();
                    else
                        MessageBox.Show("Failed to delete teacher.");
                }
            }

            private void txtSearch_TextChanged(object sender, EventArgs e)
            {
                string filter = txtSearch.Text.Trim().Replace("'", "''");
                (dgvTeachers.DataSource as DataTable).DefaultView.RowFilter =
                    $"first_name LIKE '%{filter}%' OR last_name LIKE '%{filter}%' OR email_id LIKE '%{filter}%'";
            }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to edit.");
                return;
            }

            int teacherId = Convert.ToInt32(dgvTeachers.SelectedRows[0].Cells["id"].Value);
            var dal = new TeachersDal();
            var teacher = dal.GetTeacherById(teacherId);

            using (var editForm = new EditTeachersForm(teacher))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadTeacherData();
                }
            }
            LoadTeacherData();

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            LoadTeacherData();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder();

        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                SetPlaceholder();
            }

        }
    }
    }

