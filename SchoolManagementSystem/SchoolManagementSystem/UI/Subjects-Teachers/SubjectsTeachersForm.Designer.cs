namespace SchoolManagementSystem.UI.Subjects_Teachers
{
    partial class SubjectsTeachersForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lvstudentssubjects = new System.Windows.Forms.ListView();
            this.lbltea = new System.Windows.Forms.Label();
            this.txttea = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnexport = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(5, 237);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(800, 1);
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
            this.lblname.Size = new System.Drawing.Size(787, 28);
            this.lblname.TabIndex = 21;
            this.lblname.Text = "SubjectsTeachers";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvstudentssubjects
            // 
            this.lvstudentssubjects.HideSelection = false;
            this.lvstudentssubjects.Location = new System.Drawing.Point(5, 30);
            this.lvstudentssubjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvstudentssubjects.Name = "lvstudentssubjects";
            this.lvstudentssubjects.Size = new System.Drawing.Size(522, 204);
            this.lvstudentssubjects.TabIndex = 20;
            this.lvstudentssubjects.UseCompatibleStateImageBehavior = false;
            // 
            // lbltea
            // 
            this.lbltea.AutoSize = true;
            this.lbltea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltea.Location = new System.Drawing.Point(531, 59);
            this.lbltea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltea.Name = "lbltea";
            this.lbltea.Size = new System.Drawing.Size(67, 20);
            this.lbltea.TabIndex = 37;
            this.lbltea.Text = "Teacher";
            // 
            // txttea
            // 
            this.txttea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttea.Location = new System.Drawing.Point(643, 59);
            this.txttea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttea.Name = "txttea";
            this.txttea.Size = new System.Drawing.Size(125, 20);
            this.txttea.TabIndex = 35;
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = true;
            this.btnadd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Image = global::SchoolManagementSystem.Properties.Resources.icons8_add_32;
            this.btnadd.Location = new System.Drawing.Point(691, 100);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(77, 41);
            this.btnadd.TabIndex = 33;
            this.btnadd.Text = "Add";
            this.btnadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // btnexport
            // 
            this.btnexport.AutoSize = true;
            this.btnexport.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnexport.FlatAppearance.BorderSize = 0;
            this.btnexport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.Image = global::SchoolManagementSystem.Properties.Resources.icons8_export_32;
            this.btnexport.Location = new System.Drawing.Point(590, 243);
            this.btnexport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(92, 43);
            this.btnexport.TabIndex = 38;
            this.btnexport.Text = "Export";
            this.btnexport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexport.UseVisualStyleBackColor = false;
            // 
            // btnrefresh
            // 
            this.btnrefresh.AutoSize = true;
            this.btnrefresh.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnrefresh.FlatAppearance.BorderSize = 0;
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Image = global::SchoolManagementSystem.Properties.Resources.icons8_refresh_32;
            this.btnrefresh.Location = new System.Drawing.Point(385, 243);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(102, 43);
            this.btnrefresh.TabIndex = 39;
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
            this.btnprint.Location = new System.Drawing.Point(498, 243);
            this.btnprint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(81, 43);
            this.btnprint.TabIndex = 40;
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
            this.btnclose.Image = global::SchoolManagementSystem.Properties.Resources.icons8_close_32;
            this.btnclose.Location = new System.Drawing.Point(693, 243);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(91, 43);
            this.btnclose.TabIndex = 41;
            this.btnclose.Text = "Close";
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = false;
            // 
            // btndel
            // 
            this.btndel.AutoSize = true;
            this.btndel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btndel.FlatAppearance.BorderSize = 0;
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Image = global::SchoolManagementSystem.Properties.Resources.icons8_delete_32;
            this.btndel.Location = new System.Drawing.Point(281, 243);
            this.btndel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(93, 43);
            this.btndel.TabIndex = 42;
            this.btndel.Text = "Delete";
            this.btndel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndel.UseVisualStyleBackColor = false;
            // 
            // SubjectsTeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(787, 292);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.lbltea);
            this.Controls.Add(this.txttea);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lvstudentssubjects);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SubjectsTeachersForm";
            this.Text = "SubjectsTeachersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ListView lvstudentssubjects;
        private System.Windows.Forms.Label lbltea;
        private System.Windows.Forms.TextBox txttea;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btndel;
    }
}