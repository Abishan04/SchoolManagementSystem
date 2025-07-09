using ClosedXML.Excel;
using SchoolManagementSystem.Model;
using System;
using System.Windows.Forms;


namespace SchoolManagementSystem.UI.Teachers
{
    public partial class EditTeachersForm : Form
    {
        private Teacher editingteacher;

        public EditTeachersForm(Teacher teacher)
        {
            InitializeComponent();
            editingteacher = teacher;
            this.Load += EditTeachersForm_Load;
        }

        private void EditTeachersForm_Load(object sender, EventArgs e)
        {
            // Populate fields with teacher data
     
            txtfname.Text = editingteacher.FirstName;
            txtlname.Text = editingteacher.LastName;
            if (editingteacher.Gender == "Male")
                rdomale.Checked = true;
            else if (editingteacher.Gender == "Female")
                rdofemale.Checked = true;
            else
            {
                rdomale.Checked = false;
                rdofemale.Checked = false;
            }
            txtphone.Text = editingteacher.Telephone;
            txtnic.Text = editingteacher.Nic;
            txtemail.Text = editingteacher.Email;
            txtadd.Text = editingteacher.Address;
            dtpB.Value = editingteacher.DateOfBirth;
            dtpA.Value = editingteacher.DateOfAppoint;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Update editingteacher with new values
            editingteacher.FirstName = txtfname.Text.Trim();
            editingteacher.LastName = txtlname.Text.Trim();
            editingteacher.Gender = rdofemale.Checked ? "Female" : "Male";
            editingteacher.Telephone = txtphone.Text.Trim();
            editingteacher.Nic = txtnic.Text.Trim();
            editingteacher.Email = txtemail.Text.Trim();
            editingteacher.Address = txtadd.Text.Trim();
            editingteacher.DateOfBirth = dtpB.Value.Date;
            editingteacher.DateOfAppoint = dtpA.Value.Date;
            editingteacher.UpdatedAt = DateTime.Now;
            editingteacher.UpdatedBy = Environment.UserName;

            // Save to database
            var dal = new DAL.TeachersDal();
            bool updated = dal.UpdateTeacher(editingteacher);

            if (updated)
            {
                MessageBox.Show("Teacher updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update teacher.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}