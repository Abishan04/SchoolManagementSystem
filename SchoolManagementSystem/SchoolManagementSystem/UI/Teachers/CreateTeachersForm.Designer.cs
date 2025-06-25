namespace SchoolManagementSystem.UI.Teachers
{
    partial class CreateTeachersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.cbograde = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.lblgrade = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbllname = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.lblfname = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.lbladd = new System.Windows.Forms.Label();
            this.txtadmission = new System.Windows.Forms.TextBox();
            this.lbltea = new System.Windows.Forms.Label();
            this.lbladmission = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtp
            // 
            this.dtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(131, 289);
            this.dtp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(155, 26);
            this.dtp.TabIndex = 59;
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdofemale.Location = new System.Drawing.Point(267, 194);
            this.rdofemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(80, 24);
            this.rdofemale.TabIndex = 56;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "Female";
            this.rdofemale.UseVisualStyleBackColor = true;
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdomale.Location = new System.Drawing.Point(131, 195);
            this.rdomale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(61, 24);
            this.rdomale.TabIndex = 55;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "Male";
            this.rdomale.UseVisualStyleBackColor = true;
            // 
            // cbograde
            // 
            this.cbograde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbograde.FormattingEnabled = true;
            this.cbograde.Location = new System.Drawing.Point(131, 239);
            this.cbograde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbograde.Name = "cbograde";
            this.cbograde.Size = new System.Drawing.Size(155, 28);
            this.cbograde.TabIndex = 57;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(1, 382);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(867, 1);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnclose
            // 
            this.btnclose.AutoSize = true;
            this.btnclose.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = global::SchoolManagementSystem.Properties.Resources.icons8_close_32;
            this.btnclose.Location = new System.Drawing.Point(264, 390);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(85, 40);
            this.btnclose.TabIndex = 52;
            this.btnclose.Text = "close";
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = false;
            // 
            // btnreset
            // 
            this.btnreset.AutoSize = true;
            this.btnreset.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnreset.FlatAppearance.BorderSize = 0;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Image = global::SchoolManagementSystem.Properties.Resources.icons8_reset_32;
            this.btnreset.Location = new System.Drawing.Point(86, 391);
            this.btnreset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(84, 40);
            this.btnreset.TabIndex = 51;
            this.btnreset.Text = "reset";
            this.btnreset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreset.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            this.btnsave.AutoSize = true;
            this.btnsave.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Image = global::SchoolManagementSystem.Properties.Resources.icons8_save_32;
            this.btnsave.Location = new System.Drawing.Point(176, 391);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(82, 40);
            this.btnsave.TabIndex = 53;
            this.btnsave.Text = "save";
            this.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsave.UseVisualStyleBackColor = false;
            // 
            // txtlname
            // 
            this.txtlname.BackColor = System.Drawing.SystemColors.Control;
            this.txtlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.Location = new System.Drawing.Point(131, 146);
            this.txtlname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(217, 26);
            this.txtlname.TabIndex = 50;
            // 
            // lblgrade
            // 
            this.lblgrade.AutoSize = true;
            this.lblgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrade.Location = new System.Drawing.Point(19, 245);
            this.lblgrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgrade.Name = "lblgrade";
            this.lblgrade.Size = new System.Drawing.Size(54, 20);
            this.lblgrade.TabIndex = 45;
            this.lblgrade.Text = "Grade";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(19, 197);
            this.lblgender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(63, 20);
            this.lblgender.TabIndex = 44;
            this.lblgender.Text = "Gender";
            // 
            // lbllname
            // 
            this.lbllname.AutoSize = true;
            this.lbllname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllname.Location = new System.Drawing.Point(19, 149);
            this.lbllname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(86, 20);
            this.lbllname.TabIndex = 43;
            this.lbllname.Text = "Last Name";
            // 
            // txtfname
            // 
            this.txtfname.BackColor = System.Drawing.SystemColors.Control;
            this.txtfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Location = new System.Drawing.Point(131, 98);
            this.txtfname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(217, 26);
            this.txtfname.TabIndex = 49;
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfname.Location = new System.Drawing.Point(19, 101);
            this.lblfname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(86, 20);
            this.lblfname.TabIndex = 42;
            this.lblfname.Text = "First Name";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.Location = new System.Drawing.Point(19, 293);
            this.lbldob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(99, 20);
            this.lbldob.TabIndex = 41;
            this.lbldob.Text = "Date of Birth";
            // 
            // txtadd
            // 
            this.txtadd.BackColor = System.Drawing.SystemColors.Control;
            this.txtadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadd.Location = new System.Drawing.Point(131, 340);
            this.txtadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(217, 26);
            this.txtadd.TabIndex = 58;
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladd.Location = new System.Drawing.Point(19, 341);
            this.lbladd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(68, 20);
            this.lbladd.TabIndex = 40;
            this.lbladd.Text = "Address";
            // 
            // txtadmission
            // 
            this.txtadmission.BackColor = System.Drawing.SystemColors.Control;
            this.txtadmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadmission.Location = new System.Drawing.Point(131, 51);
            this.txtadmission.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtadmission.Name = "txtadmission";
            this.txtadmission.Size = new System.Drawing.Size(217, 26);
            this.txtadmission.TabIndex = 48;
            // 
            // lbltea
            // 
            this.lbltea.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbltea.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltea.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltea.Location = new System.Drawing.Point(0, 0);
            this.lbltea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltea.Name = "lbltea";
            this.lbltea.Size = new System.Drawing.Size(356, 31);
            this.lbltea.TabIndex = 46;
            this.lbltea.Text = "Create Teacher";
            this.lbltea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbladmission
            // 
            this.lbladmission.AutoSize = true;
            this.lbladmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmission.Location = new System.Drawing.Point(19, 53);
            this.lbladmission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbladmission.Name = "lbladmission";
            this.lbladmission.Size = new System.Drawing.Size(106, 20);
            this.lbladmission.TabIndex = 47;
            this.lbladmission.Text = "Admission No";
            // 
            // CreateTeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(356, 436);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.rdofemale);
            this.Controls.Add(this.rdomale);
            this.Controls.Add(this.cbograde);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.lblgrade);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lbllname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.lblfname);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.lbladd);
            this.Controls.Add(this.txtadmission);
            this.Controls.Add(this.lbltea);
            this.Controls.Add(this.lbladmission);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateTeachersForm";
            this.Text = "CreateTeachers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.RadioButton rdofemale;
        private System.Windows.Forms.RadioButton rdomale;
        private System.Windows.Forms.ComboBox cbograde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label lblgrade;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbllname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.Label lbladd;
        private System.Windows.Forms.TextBox txtadmission;
        private System.Windows.Forms.Label lbltea;
        private System.Windows.Forms.Label lbladmission;
    }
}