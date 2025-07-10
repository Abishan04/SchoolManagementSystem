using ClosedXML.Excel;
using SchoolManagementSystem.Model;
using System;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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
            txttel.Text = editingteacher.Telephone;
            txtnic.Text = editingteacher.Nic;
            txtemail.Text = editingteacher.Email;
            txtadd.Text = editingteacher.Address;
            dtpB.Value = editingteacher.DateOfBirth;
            dtpA.Value = editingteacher.DateOfAppoint;
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

            if (!ValidateRequired(txtfname, "First Name")) return false;
            if (!ValidateRequired(txtlname, "Last Name")) return false;
            if (!ValidateRequired(txtnic, "Nic No")) return false;
            if (!ValidateGender()) return false;
            if (!ValidatePhone(txttel)) return false;
            if (!ValidateEmail(txtemail)) return false;

            if (!ValidateRequired(txtadd, "Address")) return false;
            if (!ValidateDates()) return false;

            return true;
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
                case "nic":
                    isValid = char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == 'V' || e.KeyChar == 'v' || e.KeyChar == 'X' || e.KeyChar == 'x';
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                // Update editingteacher with new values
                editingteacher.FirstName = txtfname.Text.Trim();
                editingteacher.LastName = txtlname.Text.Trim();
                editingteacher.Gender = rdofemale.Checked ? "Female" : "Male";
                editingteacher.Telephone = txttel.Text.Trim();
                editingteacher.Nic = txtnic.Text.Trim();
                editingteacher.Email = txtemail.Text.Trim();
                editingteacher.Address = txtadd.Text.Trim();
                editingteacher.DateOfBirth = dtpB.Value.Date;
                editingteacher.DateOfAppoint = dtpA.Value.Date;
                editingteacher.UpdatedAt = DateTime.Now;
                editingteacher.UpdatedBy = Environment.UserName;
            }
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
            RestrictInput(e, txtfname, "numbers");
        }

        private void txtnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            RestrictInput(e, txtnic, "nic");
        }
    }
}