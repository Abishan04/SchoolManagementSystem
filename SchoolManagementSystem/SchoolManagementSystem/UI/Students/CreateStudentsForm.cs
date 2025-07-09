using ClosedXML.Excel;
using SchoolManagementSystem.DAL;
using SchoolManagementSystem.Model;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolManagementSystem.UI.Students
{
    public partial class CreateStudentsForm : Form
    {
        public CreateStudentsForm()
        {
            InitializeComponent();
            LoadGrades();
            txttel.KeyPress += txttel_KeyPress;
            txtfname.KeyPress += txtfname_KeyPress;
            txtlname.KeyPress += txtlname_KeyPress;
        }

        private void LoadGrades()
        {
            var gradesDal = new GradesDal();
            DataTable gradeTable = gradesDal.GetAllGrades();
            cbograde.DataSource = gradeTable;
            cbograde.DisplayMember = "grade_name";
            cbograde.ValueMember = "id";
            cbograde.SelectedIndex = -1;
        }

        private bool ValidateRequired(TextBox textBox, string fieldName)
        {
            textBox.Text = textBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show($"{fieldName} is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }
            return true;
        }

        private bool ValidateComboBox(ComboBox comboBox, string fieldName)
        {
            if (comboBox.SelectedIndex == -1)
            {
                MessageBox.Show($"Please select a {fieldName}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox.Focus();
                return false;
            }
            return true;
        }

        private bool ValidatePhone(TextBox textBox)
        {
            textBox.Text = textBox.Text.Trim();
            if (!textBox.Text.All(char.IsDigit) || textBox.Text.Length < 10)
            {
                MessageBox.Show("Enter a valid phone number (at least 10 digits).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }
            return true;
        }

        private bool ValidateEmail(TextBox textBox)
        {
            textBox.Text = textBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }

            try
            {
                var addr = new MailAddress(textBox.Text);
                return addr.Address == textBox.Text;
            }
            catch
            {
                MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }
        }

        private bool ValidateGender()
        {
            if (!rdomale.Checked && !rdofemale.Checked)
            {
                MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool ValidateDates()
        {
            if (dtpB.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Date of Birth cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpA.Value.Date < dtpB.Value.Date)
            {
                MessageBox.Show("Date of Admission cannot be before Date of Birth.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidateForm()
        {
            if (!ValidateRequired(txtadmission, "Admission No")) return false;
            if (!ValidateRequired(txtfname, "First Name")) return false;
            if (!ValidateRequired(txtlname, "Last Name")) return false;
            if (!ValidateGender()) return false;
            if (!ValidatePhone(txttel)) return false;
            if (!ValidateEmail(txtemail)) return false;
            if (!ValidateComboBox(cbograde, "Grade")) return false;
            if (!ValidateRequired(txtadd, "Address")) return false;
            if (!ValidateDates()) return false;

            return true;
        }

        private void ClearForm()
        {
            txtadmission.Clear();
            txtfname.Clear();
            txtlname.Clear();
            txttel.Clear();
            txtemail.Clear();
            txtadd.Clear();
            cbograde.SelectedIndex = -1;
            rdomale.Checked = false;
            rdofemale.Checked = false;
            dtpB.Value = DateTime.Today;
            dtpA.Value = DateTime.Today;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
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
                    CreatedBy = Environment.UserName
                };

                var dal = new StudentsDal();
                int newId = dal.AddStudent(student);

                DialogResult result = MessageBox.Show("Student record saved successfully! Do you want to add another?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    ClearForm();
                }
                else
                {
                    this.Close();
                }
            }
        }
        private void RestrictInput(KeyPressEventArgs e, TextBox textBox, string mode)
        {
            bool isValid = false;

            switch (mode.ToLower())
            {
                case "numbers":
                    isValid = char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar);
                    break;

                case "letters":
                    isValid = char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar);
                    break;

                case "alphanumeric":
                    isValid = char.IsControl(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar);
                    break;

                default:
                    isValid = true; // allow all if mode is unknown
                    break;
            }

            if (!isValid)
            {
                e.Handled = true;
                toolTip1.Show($"Only {mode} are allowed", textBox, 0, -20, 2000);
            }
        }
        private void txtadmission_KeyPress(object sender, KeyPressEventArgs e)
        {
            RestrictInput(e,txtadmission,"numbers");
        }

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            RestrictInput(e, txtfname, "letters");
        }

        private void txtlname_KeyPress(object sender, KeyPressEventArgs e)
        {
            RestrictInput(e, txtlname, "letters");
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            RestrictInput(e, txttel, "numbers");
        }
    }
}