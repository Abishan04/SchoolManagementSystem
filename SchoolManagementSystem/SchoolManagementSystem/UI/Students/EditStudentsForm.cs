using SchoolManagementSystem.DAL;
using SchoolManagementSystem.Model;
using System;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (editingStudent == null) return;

            if (!ValidateForm()) 
            {            
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
            RestrictInput(e, txtadmission, "numbers");
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