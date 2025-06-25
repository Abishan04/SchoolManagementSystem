namespace SchoolManagementSystem.UI.Subjects
{
    partial class TeachersSubjectsForm
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
            this.lblname = new System.Windows.Forms.Label();
            this.lvstudentssubjects = new System.Windows.Forms.ListView();
            this.lblsub = new System.Windows.Forms.Label();
            this.txtsub = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnexport
            // 
            this.btnexport.AutoSize = true;
            this.btnexport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.Image = global::SchoolManagementSystem.Properties.Resources.icons8_export_32;
            this.btnexport.Location = new System.Drawing.Point(587, 239);
            this.btnexport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(90, 42);
            this.btnexport.TabIndex = 23;
            this.btnexport.Text = "Export";
            this.btnexport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexport.UseVisualStyleBackColor = true;
            // 
            // btnrefresh
            // 
            this.btnrefresh.AutoSize = true;
            this.btnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Image = global::SchoolManagementSystem.Properties.Resources.icons8_refresh_32;
            this.btnrefresh.Location = new System.Drawing.Point(408, 239);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(100, 42);
            this.btnrefresh.TabIndex = 24;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnrefresh.UseVisualStyleBackColor = true;
            // 
            // btnprint
            // 
            this.btnprint.AutoSize = true;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Image = global::SchoolManagementSystem.Properties.Resources.icons8_print_32;
            this.btnprint.Location = new System.Drawing.Point(508, 239);
            this.btnprint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(79, 42);
            this.btnprint.TabIndex = 25;
            this.btnprint.Text = "Print";
            this.btnprint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.AutoSize = true;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = global::SchoolManagementSystem.Properties.Resources.icons8_close_32;
            this.btnclose.Location = new System.Drawing.Point(677, 239);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(91, 42);
            this.btnclose.TabIndex = 26;
            this.btnclose.Text = "Close";
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.AutoSize = true;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Image = global::SchoolManagementSystem.Properties.Resources.icons8_delete_32;
            this.btndelete.Location = new System.Drawing.Point(317, 239);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(91, 42);
            this.btndelete.TabIndex = 27;
            this.btndelete.Text = "Delete";
            this.btndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(6, 231);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(933, 1);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblname
            // 
            this.lblname.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblname.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblname.Location = new System.Drawing.Point(0, 0);
            this.lblname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(779, 28);
            this.lblname.TabIndex = 21;
            this.lblname.Text = "TeachersSubjects";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvstudentssubjects
            // 
            this.lvstudentssubjects.HideSelection = false;
            this.lvstudentssubjects.Location = new System.Drawing.Point(9, 30);
            this.lvstudentssubjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvstudentssubjects.Name = "lvstudentssubjects";
            this.lvstudentssubjects.Size = new System.Drawing.Size(521, 198);
            this.lvstudentssubjects.TabIndex = 20;
            this.lvstudentssubjects.UseCompatibleStateImageBehavior = false;
            // 
            // lblsub
            // 
            this.lblsub.AutoSize = true;
            this.lblsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsub.Location = new System.Drawing.Point(534, 61);
            this.lblsub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsub.Name = "lblsub";
            this.lblsub.Size = new System.Drawing.Size(63, 20);
            this.lblsub.TabIndex = 40;
            this.lblsub.Text = "Subject";
            // 
            // txtsub
            // 
            this.txtsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsub.Location = new System.Drawing.Point(646, 61);
            this.txtsub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsub.Name = "txtsub";
            this.txtsub.Size = new System.Drawing.Size(125, 20);
            this.txtsub.TabIndex = 39;
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = true;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Image = global::SchoolManagementSystem.Properties.Resources.icons8_add_32;
            this.btnadd.Location = new System.Drawing.Point(693, 101);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(77, 39);
            this.btnadd.TabIndex = 38;
            this.btnadd.Text = "Add";
            this.btnadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // TeachersSubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 288);
            this.Controls.Add(this.lblsub);
            this.Controls.Add(this.txtsub);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lvstudentssubjects);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TeachersSubjectsForm";
            this.Text = "TeachersSubjectsForm";
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
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ListView lvstudentssubjects;
        private System.Windows.Forms.Label lblsub;
        private System.Windows.Forms.TextBox txtsub;
        private System.Windows.Forms.Button btnadd;
    }
}