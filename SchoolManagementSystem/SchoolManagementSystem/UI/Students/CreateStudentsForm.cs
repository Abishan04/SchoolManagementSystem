using SchoolManagementSystem.DAL;
using SchoolManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.UI.Students
{
    public partial class CreateStudentsForm : Form
    {
        public CreateStudentsForm()
        {
            InitializeComponent();
            LoadGrades();

        }
        private void LoadGrades()
        {
      
            var gradesDal = new DAL.GradesDal();
            DataTable gradeTable = gradesDal.GetAllGrades();
            MessageBox.Show($"Rows loaded: {gradeTable.Rows.Count}"); // Should be > 0
            cbograde.DataSource = gradeTable;
            cbograde.DisplayMember = "grade_name";
            cbograde.ValueMember = "id";
            cbograde.SelectedIndex = -1;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            var student = new Student
            {
                Admission = txtadmission.Text.Trim(),
                FirstName = txtfname.Text.Trim(),
                LastName = txtlname.Text.Trim(),
                Gender = rdomale.Checked ? rdomale.Text : rdofemale.Text,
                Phone = txttel.Text.Trim(),
                Email = txtemail.Text.Trim(),
                Address = txtadd.Text.Trim(),
                DateOfBirth = dtpB.Value.Date,
                DateOfAdmission = dtpA.Value.Date,
                GradeId = Convert.ToInt32(cbograde.SelectedValue),
                CreatedBy = Environment.UserName // or any user tracking
            };

            var dal = new StudentsDal();
            int newId = dal.AddStudent(student);

            if (newId > 0)
            {
                MessageBox.Show("Student added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // or reset the form
            }
            else
            {
                MessageBox.Show("Failed to add student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}



