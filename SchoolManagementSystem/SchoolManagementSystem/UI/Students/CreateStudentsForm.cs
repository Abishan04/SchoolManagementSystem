using SchoolManagementSystem.DAL;
using SchoolManagementSystem.Model; // Added this line to include the namespace where 'Student' is defined
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
        }

     private void btnSave_Click(object sender, EventArgs e)
{
            // 1. Collect input
            var student = new Student
            {
        Admission = txtadmission.Text.Trim(),
        FirstName = txtfname.Text.Trim(),
        LastName = txtlname.Text.Trim(),
        Gender = rdomale.Checked ? rdomale.Text : rdofemale.Checked ? rdofemale.Text : "",
        Phone = txttel.Text.Trim(),
        Email = txtemail.Text.Trim(),
        Address = txtadd.Text.Trim(),
        DateOfBirth = dtpB.Value,
        DateOfAdmission = dtpA.Value,
        GradeId = cbograde.SelectedValue != null ? Convert.ToInt32(cbograde.SelectedValue) : 0,//CreatedBy = CurrentUser.Username // Uncomment and set this if you have a current user context
    };

    // 2. Validate input (simple example)
    if (string.IsNullOrWhiteSpace(student.FirstName) || string.IsNullOrWhiteSpace(student.LastName))
    {
        MessageBox.Show("First Name and Last Name are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }
    if (student.GradeId == 0)
    {
        MessageBox.Show("Please select a grade.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    // 3. Save to database
    var dal = new StudentsDal();
    try
    {
        int newId = dal.AddStudent(student);
        MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.DialogResult = DialogResult.OK;
        this.Close();
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error adding student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}

