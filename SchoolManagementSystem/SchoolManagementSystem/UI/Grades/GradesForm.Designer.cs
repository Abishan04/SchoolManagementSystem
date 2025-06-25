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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = true;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Image = global::SchoolManagementSystem.Properties.Resources.icons8_add_32;
            this.btnadd.Location = new System.Drawing.Point(658, 107);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 40);
            this.btnadd.TabIndex = 27;
            this.btnadd.Text = "Add";
            this.btnadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnadd.UseVisualStyleBackColor = true;
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
            this.btnsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.Image = global::SchoolManagementSystem.Properties.Resources.icons8_add_32__1_;
            this.btnsub.Location = new System.Drawing.Point(593, 246);
            this.btnsub.Margin = new System.Windows.Forms.Padding(2);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(131, 47);
            this.btnsub.TabIndex = 25;
            this.btnsub.Text = "Add subjects";
            this.btnsub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsub.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::SchoolManagementSystem.Properties.Resources.icons8_export_32;
            this.button1.Location = new System.Drawing.Point(416, 246);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 47);
            this.button1.TabIndex = 57;
            this.button1.Text = "Export";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::SchoolManagementSystem.Properties.Resources.icons8_refresh_32;
            this.button2.Location = new System.Drawing.Point(235, 246);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 47);
            this.button2.TabIndex = 58;
            this.button2.Text = "Refresh";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::SchoolManagementSystem.Properties.Resources.icons8_print_32;
            this.button3.Location = new System.Drawing.Point(336, 246);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 47);
            this.button3.TabIndex = 59;
            this.button3.Text = "Print";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::SchoolManagementSystem.Properties.Resources.icons8_close_32;
            this.button4.Location = new System.Drawing.Point(507, 246);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 47);
            this.button4.TabIndex = 60;
            this.button4.Text = "Close";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::SchoolManagementSystem.Properties.Resources.icons8_delete_32;
            this.button5.Location = new System.Drawing.Point(143, 246);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 47);
            this.button5.TabIndex = 61;
            this.button5.Text = "Delete";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // GradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}