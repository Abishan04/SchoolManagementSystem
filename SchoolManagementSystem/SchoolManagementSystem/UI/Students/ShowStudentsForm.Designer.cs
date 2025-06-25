namespace SchoolManagementSystem.UI.Students
{
    partial class ShowStudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowStudentsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblstu = new System.Windows.Forms.Label();
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
            this.btnex = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.lbltel = new System.Windows.Forms.Label();
            this.dtpA = new System.Windows.Forms.DateTimePicker();
            this.lbldoa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(-1, 514);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(873, 1);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            this.lblstu.Size = new System.Drawing.Size(351, 28);
            this.lblstu.TabIndex = 35;
            this.lblstu.Text = "Students Detail";
            this.lblstu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp
            // 
            this.dtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(186, 393);
            this.dtp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(152, 26);
            this.dtp.TabIndex = 74;
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdofemale.Location = new System.Drawing.Point(256, 204);
            this.rdofemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(80, 24);
            this.rdofemale.TabIndex = 71;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "Female";
            this.rdofemale.UseVisualStyleBackColor = true;
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdomale.Location = new System.Drawing.Point(121, 205);
            this.rdomale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(61, 24);
            this.rdomale.TabIndex = 70;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "Male";
            this.rdomale.UseVisualStyleBackColor = true;
            // 
            // cbograde
            // 
            this.cbograde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbograde.FormattingEnabled = true;
            this.cbograde.Location = new System.Drawing.Point(186, 342);
            this.cbograde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbograde.Name = "cbograde";
            this.cbograde.Size = new System.Drawing.Size(155, 28);
            this.cbograde.TabIndex = 72;
            // 
            // txtlname
            // 
            this.txtlname.BackColor = System.Drawing.SystemColors.Control;
            this.txtlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.Location = new System.Drawing.Point(120, 155);
            this.txtlname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(217, 26);
            this.txtlname.TabIndex = 69;
            // 
            // lblgrade
            // 
            this.lblgrade.AutoSize = true;
            this.lblgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrade.Location = new System.Drawing.Point(8, 344);
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
            this.lblgender.Location = new System.Drawing.Point(8, 203);
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
            this.lbllname.Location = new System.Drawing.Point(8, 156);
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
            this.txtfname.Location = new System.Drawing.Point(120, 108);
            this.txtfname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(217, 26);
            this.txtfname.TabIndex = 68;
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfname.Location = new System.Drawing.Point(8, 109);
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
            this.lbldob.Location = new System.Drawing.Point(8, 391);
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
            this.txtadd.Location = new System.Drawing.Point(121, 484);
            this.txtadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(217, 26);
            this.txtadd.TabIndex = 73;
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladd.Location = new System.Drawing.Point(9, 485);
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
            this.txtadmission.Location = new System.Drawing.Point(120, 60);
            this.txtadmission.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtadmission.Name = "txtadmission";
            this.txtadmission.Size = new System.Drawing.Size(217, 26);
            this.txtadmission.TabIndex = 67;
            // 
            // lbladmission
            // 
            this.lbladmission.AutoSize = true;
            this.lbladmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmission.Location = new System.Drawing.Point(8, 62);
            this.lbladmission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbladmission.Name = "lbladmission";
            this.lbladmission.Size = new System.Drawing.Size(106, 20);
            this.lbladmission.TabIndex = 66;
            this.lbladmission.Text = "Admission No";
            // 
            // btnex
            // 
            this.btnex.AutoSize = true;
            this.btnex.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnex.FlatAppearance.BorderSize = 0;
            this.btnex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnex.Image = ((System.Drawing.Image)(resources.GetObject("btnex.Image")));
            this.btnex.Location = new System.Drawing.Point(153, 519);
            this.btnex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(92, 41);
            this.btnex.TabIndex = 77;
            this.btnex.Text = "Export";
            this.btnex.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnex.UseVisualStyleBackColor = false;
            // 
            // btnprint
            // 
            this.btnprint.AutoSize = true;
            this.btnprint.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnprint.FlatAppearance.BorderSize = 0;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Image = ((System.Drawing.Image)(resources.GetObject("btnprint.Image")));
            this.btnprint.Location = new System.Drawing.Point(63, 519);
            this.btnprint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(81, 41);
            this.btnprint.TabIndex = 76;
            this.btnprint.Text = "Print";
            this.btnprint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnprint.UseVisualStyleBackColor = false;
            // 
            // btnclose
            // 
            this.btnclose.AutoSize = true;
            this.btnclose.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(254, 519);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(87, 41);
            this.btnclose.TabIndex = 75;
            this.btnclose.Text = "Close";
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(120, 290);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 26);
            this.textBox2.TabIndex = 81;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(8, 297);
            this.lblemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(69, 20);
            this.lblemail.TabIndex = 79;
            this.lblemail.Text = "Email ID";
            // 
            // txttel
            // 
            this.txttel.BackColor = System.Drawing.SystemColors.Control;
            this.txttel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttel.Location = new System.Drawing.Point(120, 246);
            this.txttel.Margin = new System.Windows.Forms.Padding(2);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(217, 26);
            this.txttel.TabIndex = 80;
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltel.Location = new System.Drawing.Point(8, 250);
            this.lbltel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(54, 20);
            this.lbltel.TabIndex = 78;
            this.lbltel.Text = "Tel No";
            // 
            // dtpA
            // 
            this.dtpA.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpA.Location = new System.Drawing.Point(186, 437);
            this.dtpA.Margin = new System.Windows.Forms.Padding(2);
            this.dtpA.Name = "dtpA";
            this.dtpA.Size = new System.Drawing.Size(151, 26);
            this.dtpA.TabIndex = 83;
            // 
            // lbldoa
            // 
            this.lbldoa.AutoSize = true;
            this.lbldoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoa.Location = new System.Drawing.Point(9, 438);
            this.lbldoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldoa.Name = "lbldoa";
            this.lbldoa.Size = new System.Drawing.Size(139, 20);
            this.lbldoa.TabIndex = 82;
            this.lbldoa.Text = "Date of Admission";
            // 
            // ShowStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(351, 563);
            this.Controls.Add(this.dtpA);
            this.Controls.Add(this.lbldoa);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.btnex);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnclose);
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
            this.Controls.Add(this.lblstu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ShowStudentsForm";
            this.Text = "ShowStudentsForm";
            this.Load += new System.EventHandler(this.ShowStudentsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblstu;
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
        private System.Windows.Forms.Button btnex;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.DateTimePicker dtpA;
        private System.Windows.Forms.Label lbldoa;
    }
}