using SchoolManagementSystem.DAL;
using SchoolManagementSystem.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolManagementSystem.UI.Subjects
{
    public partial class SubjectsForm : Form
    {
        private int selectedSubjectId = 0;
        private readonly SubjectsDal dal = new SubjectsDal(); // Ensure this DAL is implemented

        public SubjectsForm()
        {
            InitializeComponent();
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            dgvSubjects.DataSource = dal.GetAllSubjects();
            dgvSubjects.ClearSelection();
            selectedSubjectId = 0;
        }

        private void dgvSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSubjects.Rows[e.RowIndex].Cells["id"].Value != null)
            {
                var row = dgvSubjects.Rows[e.RowIndex];
                selectedSubjectId = Convert.ToInt32(row.Cells["id"].Value);
                txtsubject.Text = row.Cells["subject_name"].Value?.ToString();
                txtindex.Text = row.Cells["subject_index"].Value?.ToString();
                txtorder.Text = row.Cells["subject_order"].Value?.ToString();
                txtcolor.Text = row.Cells["subject_color"].Value?.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsubject.Text))
            {
                MessageBox.Show("Subject name is required.");
                return;
            }

            var subject = new Subject
            {
                SubjectName = txtsubject.Text.Trim(),
                SubjectIndex = txtindex.Text.Trim(),
                SubjectOrder = int.TryParse(txtorder.Text, out int order) ? order : 0,
                SubjectColor = txtcolor.Text.Trim(),
                CreatedAt = DateTime.Now,
                CreatedBy = Environment.UserName
            };

            dal.AddSubject(subject);
            LoadSubjects();
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedSubjectId == 0)
            {
                MessageBox.Show("Select a subject to edit.");
                return;
            }

            var subject = new Subject
            {
                Id = selectedSubjectId,
                SubjectName = txtsubject.Text.Trim(),
                SubjectIndex = txtindex.Text.Trim(),
                SubjectOrder = int.TryParse(txtorder.Text, out int order) ? order : 0,
                SubjectColor = txtcolor.Text.Trim(),
                UpdatedAt = DateTime.Now,
                UpdatedBy = Environment.UserName
            };

            dal.UpdateSubject(subject);
            LoadSubjects();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSubjectId == 0)
            {
                MessageBox.Show("Select a subject to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this subject?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                dal.DeleteSubject(selectedSubjectId, Environment.UserName);
                LoadSubjects();
                ClearFields();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSubjects();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {
            txtsubject.Clear();
            txtindex.Clear();
            txtorder.Clear();
            txtcolor.Clear();
            selectedSubjectId = 0;
        }
    }
}
