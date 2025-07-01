using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(txtfname.Text) || string.IsNullOrWhiteSpace(txtnic.Text))
            {
                MessageBox.Show("First Name and NIC No are required.");
                return;
            }

            var teacher = new Teacher
            {
                TeacherId = txtid.Text.Trim(),
                FirstName = txtfname.Text.Trim(),
                LastName = txtlname.Text.Trim(),
                NIC = txtnic.Text.Trim(),
                Gender = rdomale.Checked ? "Male" : "Female",
                Phone = txtphone.Text.Trim(),
                Email = txtemail.Text.Trim(),
                Address = txtaddress.Text.Trim(),
                DateOfBirth = dtpBirth.Value,
                DateOfAppointment = dtpAppointment.Value,
                CreatedBy = Environment.UserName,
                CreatedAt = DateTime.Now
            };

            new TeachersDal().AddTeacher(teacher);

            MessageBox.Show("Teacher saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}