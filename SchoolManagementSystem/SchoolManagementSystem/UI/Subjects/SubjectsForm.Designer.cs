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
            this.btnexport = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblsub = new System.Windows.Forms.Label();
            this.txtgrade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnstudent = new System.Windows.Forms.Button();
            this.btnteacher = new System.Windows.Forms.Button();
            this.txtsubcode = new System.Windows.Forms.TextBox();
            this.lblcode = new System.Windows.Forms.Label();
            this.btngrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnexport
            // 
            this.btnexport.AutoSize = true;
            this.btnexport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.Image = global::SchoolManagementSystem.Properties.Resources.icons8_export_32;
            this.btnexport.Location = new System.Drawing.Point(947, 411);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(145, 47);
            this.btnexport.TabIndex = 18;
            this.btnexport.Text = "Export";
            this.btnexport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexport.UseVisualStyleBackColor = true;
            // 
            // btnrefresh
            // 
            this.btnrefresh.AutoSize = true;
            this.btnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Image = global::SchoolManagementSystem.Properties.Resources.icons8_refresh_32;
            this.btnrefresh.Location = new System.Drawing.Point(157, 411);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(145, 47);
            this.btnrefresh.TabIndex = 19;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnrefresh.UseVisualStyleBackColor = true;
            // 
            // btnprint
            // 
            this.btnprint.AutoSize = true;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Image = global::SchoolManagementSystem.Properties.Resources.icons8_print_32;
            this.btnprint.Location = new System.Drawing.Point(802, 411);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(145, 47);
            this.btnprint.TabIndex = 20;
            this.btnprint.Text = "Print";
            this.btnprint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnclose
            // 
            this.btnclose.AutoSize = true;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = global::SchoolManagementSystem.Properties.Resources.icons8_close_32;
            this.btnclose.Location = new System.Drawing.Point(1092, 411);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(145, 47);
            this.btnclose.TabIndex = 21;
            this.btnclose.Text = "Close";
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.AutoSize = true;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Image = global::SchoolManagementSystem.Properties.Resources.icons8_delete_32;
            this.btndelete.Location = new System.Drawing.Point(12, 411);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(145, 47);
            this.btndelete.TabIndex = 22;
            this.btndelete.Text = "Delete";
            this.btndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(7, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1300, 1);
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
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1242, 50);
            this.label1.TabIndex = 24;
            this.label1.Text = "Subjects";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 68);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(755, 294);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblsub
            // 
            this.lblsub.AutoSize = true;
            this.lblsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsub.Location = new System.Drawing.Point(790, 68);
            this.lblsub.Name = "lblsub";
            this.lblsub.Size = new System.Drawing.Size(94, 29);
            this.lblsub.TabIndex = 32;
            this.lblsub.Text = "Subject";
            // 
            // txtgrade
            // 
            this.txtgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrade.Location = new System.Drawing.Point(958, 68);
            this.txtgrade.Name = "txtgrade";
            this.txtgrade.Size = new System.Drawing.Size(186, 26);
            this.txtgrade.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::SchoolManagementSystem.Properties.Resources.icons8_add_32;
            this.button1.Location = new System.Drawing.Point(1029, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 45);
            this.button1.TabIndex = 30;
            this.button1.Text = "Add";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnstudent
            // 
            this.btnstudent.AutoSize = true;
            this.btnstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudent.Image = global::SchoolManagementSystem.Properties.Resources.icons8_add_32__1_;
            this.btnstudent.Location = new System.Drawing.Point(302, 411);
            this.btnstudent.Name = "btnstudent";
            this.btnstudent.Size = new System.Drawing.Size(171, 47);
            this.btnstudent.TabIndex = 20;
            this.btnstudent.Text = "Add student";
            this.btnstudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnstudent.UseVisualStyleBackColor = true;
            this.btnstudent.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnteacher
            // 
            this.btnteacher.AutoSize = true;
            this.btnteacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnteacher.Image = global::SchoolManagementSystem.Properties.Resources.icons8_add_32__1_;
            this.btnteacher.Location = new System.Drawing.Point(473, 411);
            this.btnteacher.Name = "btnteacher";
            this.btnteacher.Size = new System.Drawing.Size(172, 47);
            this.btnteacher.TabIndex = 20;
            this.btnteacher.Text = "Add teacher";
            this.btnteacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnteacher.UseVisualStyleBackColor = true;
            this.btnteacher.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // txtsubcode
            // 
            this.txtsubcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubcode.Location = new System.Drawing.Point(958, 119);
            this.txtsubcode.Name = "txtsubcode";
            this.txtsubcode.Size = new System.Drawing.Size(186, 26);
            this.txtsubcode.TabIndex = 31;
            // 
            // lblcode
            // 
            this.lblcode.AutoSize = true;
            this.lblcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcode.Location = new System.Drawing.Point(790, 119);
            this.lblcode.Name = "lblcode";
            this.lblcode.Size = new System.Drawing.Size(159, 29);
            this.lblcode.TabIndex = 32;
            this.lblcode.Text = "Subject Code";
            // 
            // btngrade
            // 
            this.btngrade.AutoSize = true;
            this.btngrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrade.Image = global::SchoolManagementSystem.Properties.Resources.icons8_add_32__1_;
            this.btngrade.Location = new System.Drawing.Point(645, 411);
            this.btngrade.Name = "btngrade";
            this.btngrade.Size = new System.Drawing.Size(157, 47);
            this.btngrade.TabIndex = 20;
            this.btngrade.Text = "Add grade";
            this.btngrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngrade.UseVisualStyleBackColor = true;
            this.btngrade.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 492);
            this.Controls.Add(this.lblcode);
            this.Controls.Add(this.txtsubcode);
            this.Controls.Add(this.lblsub);
            this.Controls.Add(this.txtgrade);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btngrade);
            this.Controls.Add(this.btnteacher);
            this.Controls.Add(this.btnstudent);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.groupBox1);
            this.Name = "SubjectsForm";
            this.Text = "SubjectsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblsub;
        private System.Windows.Forms.TextBox txtgrade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnstudent;
        private System.Windows.Forms.Button btnteacher;
        private System.Windows.Forms.TextBox txtsubcode;
        private System.Windows.Forms.Label lblcode;
        private System.Windows.Forms.Button btngrade;
    }
}