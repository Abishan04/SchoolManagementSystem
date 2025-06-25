namespace SchoolManagementSystem.UI.Teachers
{
    partial class ShowTeachersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowTeachersForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.cbograde = new System.Windows.Forms.ComboBox();
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
            this.lbladmission = new System.Windows.Forms.Label();
            this.lblstu = new System.Windows.Forms.Label();
            this.btnexport = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(5, 398);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(873, 1);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dtp
            // 
            this.dtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Location = new System.Drawing.Point(120, 290);
            this.dtp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(275, 26);
            this.dtp.TabIndex = 79;
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdofemale.Location = new System.Drawing.Point(256, 196);
            this.rdofemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(80, 24);
            this.rdofemale.TabIndex = 76;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "Female";
            this.rdofemale.UseVisualStyleBackColor = true;
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdomale.Location = new System.Drawing.Point(121, 197);
            this.rdomale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(61, 24);
            this.rdomale.TabIndex = 75;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "Male";
            this.rdomale.UseVisualStyleBackColor = true;
            // 
            // cbograde
            // 
            this.cbograde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbograde.FormattingEnabled = true;
            this.cbograde.Location = new System.Drawing.Point(120, 241);
            this.cbograde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbograde.Name = "cbograde";
            this.cbograde.Size = new System.Drawing.Size(155, 28);
            this.cbograde.TabIndex = 77;
            // 
            // txtlname
            // 
            this.txtlname.BackColor = System.Drawing.SystemColors.Control;
            this.txtlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.Location = new System.Drawing.Point(120, 148);
            this.txtlname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(217, 26);
            this.txtlname.TabIndex = 70;
            // 
            // lblgrade
            // 
            this.lblgrade.AutoSize = true;
            this.lblgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrade.Location = new System.Drawing.Point(8, 247);
            this.lblgrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgrade.Name = "lblgrade";
            this.lblgrade.Size = new System.Drawing.Size(54, 20);
            this.lblgrade.TabIndex = 65;
            this.lblgrade.Text = "Grade";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(8, 199);
            this.lblgender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(63, 20);
            this.lblgender.TabIndex = 64;
            this.lblgender.Text = "Gender";
            // 
            // lbllname
            // 
            this.lbllname.AutoSize = true;
            this.lbllname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllname.Location = new System.Drawing.Point(8, 151);
            this.lbllname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(86, 20);
            this.lbllname.TabIndex = 63;
            this.lbllname.Text = "Last Name";
            // 
            // txtfname
            // 
            this.txtfname.BackColor = System.Drawing.SystemColors.Control;
            this.txtfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Location = new System.Drawing.Point(120, 100);
            this.txtfname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(217, 26);
            this.txtfname.TabIndex = 69;
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfname.Location = new System.Drawing.Point(8, 103);
            this.lblfname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(86, 20);
            this.lblfname.TabIndex = 62;
            this.lblfname.Text = "First Name";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.Location = new System.Drawing.Point(8, 295);
            this.lbldob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(99, 20);
            this.lbldob.TabIndex = 61;
            this.lbldob.Text = "Date of Birth";
            // 
            // txtadd
            // 
            this.txtadd.BackColor = System.Drawing.SystemColors.Control;
            this.txtadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadd.Location = new System.Drawing.Point(120, 342);
            this.txtadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(217, 26);
            this.txtadd.TabIndex = 78;
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladd.Location = new System.Drawing.Point(8, 343);
            this.lbladd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(68, 20);
            this.lbladd.TabIndex = 60;
            this.lbladd.Text = "Address";
            // 
            // txtadmission
            // 
            this.txtadmission.BackColor = System.Drawing.SystemColors.Control;
            this.txtadmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadmission.Location = new System.Drawing.Point(120, 53);
            this.txtadmission.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtadmission.Name = "txtadmission";
            this.txtadmission.Size = new System.Drawing.Size(217, 26);
            this.txtadmission.TabIndex = 68;
            // 
            // lbladmission
            // 
            this.lbladmission.AutoSize = true;
            this.lbladmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmission.Location = new System.Drawing.Point(8, 55);
            this.lbladmission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbladmission.Name = "lbladmission";
            this.lbladmission.Size = new System.Drawing.Size(106, 20);
            this.lbladmission.TabIndex = 67;
            this.lbladmission.Text = "Admission No";
            // 
            // lblstu
            // 
            this.lblstu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblstu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblstu.Location = new System.Drawing.Point(0, 0);
            this.lblstu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstu.Name = "lblstu";
            this.lblstu.Size = new System.Drawing.Size(404, 40);
            this.lblstu.TabIndex = 48;
            this.lblstu.Text = "Specific Teacher\'s  Details";
            this.lblstu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnexport
            // 
            this.btnexport.AutoSize = true;
            this.btnexport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.Image = ((System.Drawing.Image)(resources.GetObject("btnexport.Image")));
            this.btnexport.Location = new System.Drawing.Point(216, 403);
            this.btnexport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(90, 48);
            this.btnexport.TabIndex = 51;
            this.btnexport.Text = "Export";
            this.btnexport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexport.UseVisualStyleBackColor = true;
            // 
            // btnprint
            // 
            this.btnprint.AutoSize = true;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Image = ((System.Drawing.Image)(resources.GetObject("btnprint.Image")));
            this.btnprint.Location = new System.Drawing.Point(134, 403);
            this.btnprint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(79, 48);
            this.btnprint.TabIndex = 50;
            this.btnprint.Text = "Print";
            this.btnprint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.AutoSize = true;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(310, 403);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(85, 48);
            this.btnclose.TabIndex = 49;
            this.btnclose.Text = "Close";
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // ShowTeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 453);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.rdofemale);
            this.Controls.Add(this.rdomale);
            this.Controls.Add(this.cbograde);
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
            this.Controls.Add(this.lbladmission);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblstu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ShowTeachersForm";
            this.Text = "ShowTeachersForm";
            this.Load += new System.EventHandler(this.ShowTeachersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.RadioButton rdofemale;
        private System.Windows.Forms.RadioButton rdomale;
        private System.Windows.Forms.ComboBox cbograde;
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
        private System.Windows.Forms.Label lbladmission;
        private System.Windows.Forms.Label lblstu;
    }
}