namespace SchoolManagementSystem.UI.Subjects
{
    partial class SubjectsForm
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
            this.btnex = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblsub = new System.Windows.Forms.Label();
            this.txtgrade = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnstudent = new System.Windows.Forms.Button();
            this.btnteacher = new System.Windows.Forms.Button();
            this.txtsubcode = new System.Windows.Forms.TextBox();
            this.lblcode = new System.Windows.Forms.Label();
            this.btngrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnex
            // 
            this.btnex.AutoSize = true;
            this.btnex.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnex.FlatAppearance.BorderSize = 0;
            this.btnex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnex.Image = global::SchoolManagementSystem.Properties.Resources.icons8_export_32;
            this.btnex.Location = new System.Drawing.Point(718, 267);
            this.btnex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(97, 42);
            this.btnex.TabIndex = 18;
            this.btnex.Text = "Export";
            this.btnex.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnex.UseVisualStyleBackColor = false;
            // 
            // btnrefresh
            // 
            this.btnrefresh.AutoSize = true;
            this.btnrefresh.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnrefresh.FlatAppearance.BorderSize = 0;
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Image = global::SchoolManagementSystem.Properties.Resources.icons8_refresh_32;
            this.btnrefresh.Location = new System.Drawing.Point(114, 267);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(102, 42);
            this.btnrefresh.TabIndex = 19;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnrefresh.UseVisualStyleBackColor = false;
            // 
            // btnprint
            // 
            this.btnprint.AutoSize = true;
            this.btnprint.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnprint.FlatAppearance.BorderSize = 0;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Image = global::SchoolManagementSystem.Properties.Resources.icons8_print_32;
            this.btnprint.Location = new System.Drawing.Point(615, 267);
            this.btnprint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(97, 42);
            this.btnprint.TabIndex = 20;
            this.btnprint.Text = "Print";
            this.btnprint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnclose
            // 
            this.btnclose.AutoSize = true;
            this.btnclose.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = global::SchoolManagementSystem.Properties.Resources.icons8_close_32;
            this.btnclose.Location = new System.Drawing.Point(821, 267);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(97, 42);
            this.btnclose.TabIndex = 21;
            this.btnclose.Text = "Close";
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            this.btndelete.AutoSize = true;
            this.btndelete.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Image = global::SchoolManagementSystem.Properties.Resources.icons8_delete_32;
            this.btndelete.Location = new System.Drawing.Point(11, 267);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(97, 42);
            this.btndelete.TabIndex = 22;
            this.btndelete.Text = "Delete";
            this.btndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(5, 251);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1000, 1);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(917, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Subjects";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 34);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(609, 213);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblsub
            // 
            this.lblsub.AutoSize = true;
            this.lblsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsub.Location = new System.Drawing.Point(624, 44);
            this.lblsub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsub.Name = "lblsub";
            this.lblsub.Size = new System.Drawing.Size(63, 20);
            this.lblsub.TabIndex = 32;
            this.lblsub.Text = "Subject";
            // 
            // txtgrade
            // 
            this.txtgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrade.Location = new System.Drawing.Point(736, 44);
            this.txtgrade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtgrade.Name = "txtgrade";
            this.txtgrade.Size = new System.Drawing.Size(125, 20);
            this.txtgrade.TabIndex = 31;
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = true;
            this.btnadd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Image = global::SchoolManagementSystem.Properties.Resources.icons8_add_32;
            this.btnadd.Location = new System.Drawing.Point(784, 116);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(77, 41);
            this.btnadd.TabIndex = 30;
            this.btnadd.Text = "Add";
            this.btnadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // btnstudent
            // 
            this.btnstudent.AutoSize = true;
            this.btnstudent.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnstudent.FlatAppearance.BorderSize = 0;
            this.btnstudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudent.Image = global::SchoolManagementSystem.Properties.Resources.icons8_add_32__1_;
            this.btnstudent.Location = new System.Drawing.Point(222, 267);
            this.btnstudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnstudent.Name = "btnstudent";
            this.btnstudent.Size = new System.Drawing.Size(128, 42);
            this.btnstudent.TabIndex = 20;
            this.btnstudent.Text = "Add student";
            this.btnstudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnstudent.UseVisualStyleBackColor = false;
            this.btnstudent.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnteacher
            // 
            this.btnteacher.AutoSize = true;
            this.btnteacher.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnteacher.FlatAppearance.BorderSize = 0;
            this.btnteacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnteacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnteacher.Image = global::SchoolManagementSystem.Properties.Resources.icons8_add_32__1_;
            this.btnteacher.Location = new System.Drawing.Point(356, 267);
            this.btnteacher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnteacher.Name = "btnteacher";
            this.btnteacher.Size = new System.Drawing.Size(129, 42);
            this.btnteacher.TabIndex = 20;
            this.btnteacher.Text = "Add teacher";
            this.btnteacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnteacher.UseVisualStyleBackColor = false;
            this.btnteacher.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // txtsubcode
            // 
            this.txtsubcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubcode.Location = new System.Drawing.Point(736, 77);
            this.txtsubcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsubcode.Name = "txtsubcode";
            this.txtsubcode.Size = new System.Drawing.Size(125, 20);
            this.txtsubcode.TabIndex = 31;
            // 
            // lblcode
            // 
            this.lblcode.AutoSize = true;
            this.lblcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcode.Location = new System.Drawing.Point(624, 77);
            this.lblcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcode.Name = "lblcode";
            this.lblcode.Size = new System.Drawing.Size(105, 20);
            this.lblcode.TabIndex = 32;
            this.lblcode.Text = "Subject Code";
            // 
            // btngrade
            // 
            this.btngrade.AutoSize = true;
            this.btngrade.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btngrade.FlatAppearance.BorderSize = 0;
            this.btngrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrade.Image = global::SchoolManagementSystem.Properties.Resources.icons8_add_32__1_;
            this.btngrade.Location = new System.Drawing.Point(491, 267);
            this.btngrade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btngrade.Name = "btngrade";
            this.btngrade.Size = new System.Drawing.Size(118, 42);
            this.btngrade.TabIndex = 20;
            this.btngrade.Text = "Add grade";
            this.btngrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngrade.UseVisualStyleBackColor = false;
            this.btngrade.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(917, 320);
            this.Controls.Add(this.lblcode);
            this.Controls.Add(this.txtsubcode);
            this.Controls.Add(this.lblsub);
            this.Controls.Add(this.txtgrade);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnex);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btngrade);
            this.Controls.Add(this.btnteacher);
            this.Controls.Add(this.btnstudent);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SubjectsForm";
            this.Text = "SubjectsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnex;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblsub;
        private System.Windows.Forms.TextBox txtgrade;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnstudent;
        private System.Windows.Forms.Button btnteacher;
        private System.Windows.Forms.TextBox txtsubcode;
        private System.Windows.Forms.Label lblcode;
        private System.Windows.Forms.Button btngrade;
    }
}