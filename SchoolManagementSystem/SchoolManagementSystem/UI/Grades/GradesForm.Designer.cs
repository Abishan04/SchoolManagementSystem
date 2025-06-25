namespace SchoolManagementSystem.UI.Grades
{
    partial class GradesForm
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
            this.btnadd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvstudentssubjects = new System.Windows.Forms.ListView();
            this.lblgrade = new System.Windows.Forms.Label();
            this.btnsub = new System.Windows.Forms.Button();
            this.txtgrade = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.btnex = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = true;
            this.btnadd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Black;
            this.btnadd.Image = global::SchoolManagementSystem.Properties.Resources.icons8_add_32;
            this.btnadd.Location = new System.Drawing.Point(658, 106);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(77, 41);
            this.btnadd.TabIndex = 27;
            this.btnadd.Text = "Add";
            this.btnadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(3, 231);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(867, 1);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lvstudentssubjects
            // 
            this.lvstudentssubjects.HideSelection = false;
            this.lvstudentssubjects.Location = new System.Drawing.Point(6, 35);
            this.lvstudentssubjects.Margin = new System.Windows.Forms.Padding(2);
            this.lvstudentssubjects.Name = "lvstudentssubjects";
            this.lvstudentssubjects.Size = new System.Drawing.Size(545, 193);
            this.lvstudentssubjects.TabIndex = 20;
            this.lvstudentssubjects.UseCompatibleStateImageBehavior = false;
            // 
            // lblgrade
            // 
            this.lblgrade.AutoSize = true;
            this.lblgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrade.Location = new System.Drawing.Point(553, 63);
            this.lblgrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgrade.Name = "lblgrade";
            this.lblgrade.Size = new System.Drawing.Size(54, 20);
            this.lblgrade.TabIndex = 29;
            this.lblgrade.Text = "Grade";
            // 
            // btnsub
            // 
            this.btnsub.AutoSize = true;
            this.btnsub.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnsub.FlatAppearance.BorderSize = 0;
            this.btnsub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.ForeColor = System.Drawing.Color.Black;
            this.btnsub.Image = global::SchoolManagementSystem.Properties.Resources.icons8_add_32__1_;
            this.btnsub.Location = new System.Drawing.Point(278, 248);
            this.btnsub.Margin = new System.Windows.Forms.Padding(2);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(139, 47);
            this.btnsub.TabIndex = 25;
            this.btnsub.Text = "Add subjects";
            this.btnsub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsub.UseVisualStyleBackColor = false;
            // 
            // txtgrade
            // 
            this.txtgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrade.Location = new System.Drawing.Point(608, 65);
            this.txtgrade.Margin = new System.Windows.Forms.Padding(2);
            this.txtgrade.Name = "txtgrade";
            this.txtgrade.Size = new System.Drawing.Size(125, 20);
            this.txtgrade.TabIndex = 28;
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
            this.lblname.Size = new System.Drawing.Size(739, 33);
            this.lblname.TabIndex = 56;
            this.lblname.Text = "Grades";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnex
            // 
            this.btnex.AutoSize = true;
            this.btnex.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnex.FlatAppearance.BorderSize = 0;
            this.btnex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnex.ForeColor = System.Drawing.Color.Black;
            this.btnex.Image = global::SchoolManagementSystem.Properties.Resources.icons8_export_32;
            this.btnex.Location = new System.Drawing.Point(525, 246);
            this.btnex.Margin = new System.Windows.Forms.Padding(2);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(102, 47);
            this.btnex.TabIndex = 57;
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
            this.btnrefresh.ForeColor = System.Drawing.Color.Black;
            this.btnrefresh.Image = global::SchoolManagementSystem.Properties.Resources.icons8_refresh_32;
            this.btnrefresh.Location = new System.Drawing.Point(162, 248);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(108, 47);
            this.btnrefresh.TabIndex = 58;
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
            this.btnprint.ForeColor = System.Drawing.Color.Black;
            this.btnprint.Image = global::SchoolManagementSystem.Properties.Resources.icons8_print_32;
            this.btnprint.Location = new System.Drawing.Point(425, 248);
            this.btnprint.Margin = new System.Windows.Forms.Padding(2);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(92, 47);
            this.btnprint.TabIndex = 59;
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
            this.btnclose.ForeColor = System.Drawing.Color.Black;
            this.btnclose.Image = global::SchoolManagementSystem.Properties.Resources.icons8_close_32;
            this.btnclose.Location = new System.Drawing.Point(635, 246);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(93, 47);
            this.btnclose.TabIndex = 60;
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
            this.btndel.ForeColor = System.Drawing.Color.Black;
            this.btndel.Image = global::SchoolManagementSystem.Properties.Resources.icons8_delete_32;
            this.btndel.Location = new System.Drawing.Point(55, 248);
            this.btndel.Margin = new System.Windows.Forms.Padding(2);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(99, 47);
            this.btndel.TabIndex = 61;
            this.btndel.Text = "Delete";
            this.btndel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndel.UseVisualStyleBackColor = false;
            // 
            // GradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(739, 304);
            this.Controls.Add(this.btnex);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblgrade);
            this.Controls.Add(this.txtgrade);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvstudentssubjects);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GradesForm";
            this.Text = "GradesForm";
            this.Load += new System.EventHandler(this.GradesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvstudentssubjects;
        private System.Windows.Forms.Label lblgrade;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.TextBox txtgrade;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnex;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btndel;
    }
}