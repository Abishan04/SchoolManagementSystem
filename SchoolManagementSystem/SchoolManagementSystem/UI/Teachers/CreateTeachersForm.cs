using ClosedXML.Excel;
using SchoolManagementSystem.DAL;
using SchoolManagementSystem.Model;
using System;
using System.Windows.Forms;

namespace SchoolManagementSystem.UI.Teachers
{
    public partial class CreateTeachersForm : Form
    {
        public CreateTeachersForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. Collect input
            var teacher = new Teacher
            {
                FirstName = txtfname.Text.Trim(),
                LastName = txtlname.Text.Trim(),
                Gender = rdomale.Checked ? "Male" : rdofemale.Checked ? "Female" : "",
                Telephone = txttel.Text.Trim(),
                Nic = txtnic.Text.Trim(),
                Email = txtemail.Text.Trim(),
                Address = txtadd.Text.Trim(),
                DateOfBirth = dtpB.Value.Date,
                DateOfAppoint = dtpA.Value.Date,
                CreatedAt = DateTime.Now,
                CreatedBy = Environment.UserName // or your user tracking
            };

            //// 2. Validate input (simple example)
            //if (string.IsNullOrWhiteSpace(teacher.FirstName) || string.IsNullOrWhiteSpace(teacher.LastName))
            //{
            //    MessageBox.Show("First Name and Last Name are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            // 3. Save to database
            var dal = new TeachersDal();
            try
            {
                int newId = dal.AddTeacher(teacher);
                MessageBox.Show("Teacher added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding teacher: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}