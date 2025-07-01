using SchoolManagementSystem.DAL;
using SchoolManagementSystem.Model;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SchoolManagementSystem.UI.Grades
{
    public partial class GradesForm : Form
    {
        private GradesDal dal = new GradesDal();
        private int selectedGradeId = 0;

        public GradesForm()
        {
            InitializeComponent();
            dgvGrades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrades.AutoGenerateColumns = false;
            LoadGrades();

            // Attach color picker to color textbox
            txtcolor.Click += Txtcolor_Click;
        }

        private void GradesForm_Load(object sender, EventArgs e)
        {
            SetButtonRoundedRegion(btnadd);
            SetButtonRoundedRegion(btnsub);
            SetButtonRoundedRegion(btnex);
            SetButtonRoundedRegion(btnrefresh);
            SetButtonRoundedRegion(btnprint);
            SetButtonRoundedRegion(btnclose);
            SetButtonRoundedRegion(btndel);
        }

        private void SetButtonRoundedRegion(Button button, int radius = 20)
        {
            var path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            button.Region = new Region(path);
        }

        private void LoadGrades()
        {
            var dt = dal.GetAllGrades();
            dgvGrades.AutoGenerateColumns = true;
            dgvGrades.DataSource = dt;
            dgvGrades.ClearSelection();
            selectedGradeId = 0;
        }

        private void ClearFields()
        {
            txtgrade.Clear();
            txtorder.Clear();
            txtgroup.Clear();
            txtcolor.Clear();
            selectedGradeId = 0;
        }

        private Grade GetGradeFromForm()
        {
            return new Grade
            {
                GradeName = txtgrade.Text.Trim(),
                GradeOrder = int.Parse(txtorder.Text.Trim()),
                GradeColor = txtcolor.Text.Trim(),
                GradeGroup = txtgroup.Text.Trim(),
                CreatedBy = Environment.UserName,
                CreatedAt = DateTime.Now
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            var newGrade = GetGradeFromForm();
            dal.addgrade(newGrade);
            LoadGrades();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedGradeId == 0 || !ValidateFields())
            {
                MessageBox.Show("Please select a grade to update.");
                return;
            }

            var updatedGrade = GetGradeFromForm();
            dal.UpdateGrade(selectedGradeId, updatedGrade); // ✅ Correct method now used
            LoadGrades();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedGradeId == 0)
            {
                MessageBox.Show("Please select a grade to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this grade?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                dal.DeleteGrade(selectedGradeId, Environment.UserName);
                LoadGrades();
                ClearFields();
            }
        }

        private void dgvGrades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvGrades.Rows[e.RowIndex];
                selectedGradeId = Convert.ToInt32(row.Cells["id"].Value);
                txtgrade.Text = row.Cells["grade_name"].Value.ToString();
                txtorder.Text = row.Cells["grade_order"].Value.ToString();
                txtgroup.Text = row.Cells["grade_group"].Value.ToString();
                txtcolor.Text = row.Cells["grade_color"].Value.ToString();
            }
        }

        private void Txtcolor_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtcolor.BackColor = dlg.Color;
                    txtcolor.Text = ColorTranslator.ToHtml(dlg.Color);
                }
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtgrade.Text))
            {
                MessageBox.Show("Grade name is required.");
                return false;
            }

            if (!int.TryParse(txtorder.Text.Trim(), out _))
            {
                MessageBox.Show("Grade order must be a valid number.");
                return false;
            }

            return true;
        }
    }
}
