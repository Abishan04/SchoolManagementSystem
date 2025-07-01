using SchoolManagementSystem.DAL;
using SchoolManagementSystem.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolManagementSystem.UI.Students
{
    public partial class EditStudentsForm : Form
    {
        private Student editingStudent; // Use Students (plural) for consistency

        public EditStudentsForm(Student student)
        {
            InitializeComponent();
            editingStudent = student;
            this.Load += EditStudentsForm_Load; // Ensure the Load event is hooked
        }

        private void EditStudentsForm_Load(object sender, EventArgs e)
        {
            LoadGrades();
            PopulateFields();
        }

        private void LoadGrades()
        {
            var gradesDal = new GradesDal();
            DataTable gradeTable = gradesDal.GetAllGrades();
            cbograde.DataSource = gradeTable;
            cbograde.DisplayMember = "grade_name";
            cbograde.ValueMember = "id";
            cbograde.SelectedIndex = -1;
            // Only set this if there's a valid GradeId
            if (editingStudent != null && editingStudent.GradeId > 0)
                cbograde.SelectedValue = editingStudent.GradeId;
            else
                cbograde.SelectedIndex = -1;

        }

        private void PopulateFields()
        {
            if (editingStudent == null) return;

            txtadmission.Text = editingStudent.Admission;
            txtfname.Text = editingStudent.FirstName;
            txtlname.Text = editingStudent.LastName;

            if (editingStudent.Gender == "Male")
                rdomale.Checked = true;
            else if (editingStudent.Gender == "Female")
                rdofemale.Checked = true;
            else
            {
                rdomale.Checked = false;
                rdofemale.Checked = false;
            }
            cbograde.SelectedValue = editingStudent.GradeId;
            txttel.Text = editingStudent.Phone;
            txtemail.Text = editingStudent.Email;
            txtadd.Text = editingStudent.Address;
            dtpB.Value = editingStudent.DateOfBirth;
            dtpA.Value = editingStudent.DateOfAdmission;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtadmission.Clear();
            txtfname.Clear();
            txtlname.Clear();
            rdomale.Checked = false;
            rdofemale.Checked = false;
            txttel.Clear();
            txtemail.Clear();
            txtadd.Clear();
            dtpB.Value = DateTime.Today;
            dtpA.Value = DateTime.Today;
            cbograde.SelectedIndex = -1;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (editingStudent == null) return;

            editingStudent.Admission = txtadmission.Text;
            editingStudent.FirstName = txtfname.Text;
            editingStudent.LastName = txtlname.Text;
            editingStudent.Gender = rdofemale.Checked ? "Female" : "Male";
            editingStudent.Phone = txttel.Text;
            editingStudent.Email = txtemail.Text;
            editingStudent.Address = txtadd.Text;
            editingStudent.DateOfBirth = dtpB.Value;
            editingStudent.DateOfAdmission = dtpA.Value;
            editingStudent.GradeId = cbograde.SelectedValue != null ? Convert.ToInt32(cbograde.SelectedValue) : 0;

            var dal = new StudentsDal();
            editingStudent.UpdatedBy = Environment.UserName;
            editingStudent.UpdatedAt = DateTime.Now;
            dal.UpdateStudent(editingStudent);
            MessageBox.Show("Student information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

    
    }
}