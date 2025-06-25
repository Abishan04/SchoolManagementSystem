namespace SchoolManagementSystem.UI.Students_Subjects
{
    partial class StudentsSubjectsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsSubjectsForm));
            this.lblname = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvsubjectsstudents = new System.Windows.Forms.ListView();
            this.btnex = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.lblsub = new System.Windows.Forms.Label();
            this.txtsub = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.lblname.Size = new System.Drawing.Size(775, 38);
            this.lblname.TabIndex = 43;
            this.lblname.Text = "StudentsSubjects";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(0, 231);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(800, 1);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lvsubjectsstudents
            // 
            this.lvsubjectsstudents.HideSelection = false;
            this.lvsubjectsstudents.Location = new System.Drawing.Point(8, 40);
            this.lvsubjectsstudents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvsubjectsstudents.Name = "lvsubjectsstudents";
            this.lvsubjectsstudents.Size = new System.Drawing.Size(515, 189);
            this.lvsubjectsstudents.TabIndex = 32;
            this.lvsubjectsstudents.UseCompatibleStateImageBehavior = false;
            // 
            // btnex
            // 
            this.btnex.AutoSize = true;
            this.btnex.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnex.FlatAppearance.BorderSize = 0;
            this.btnex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnex.Image = global::SchoolManagementSystem.Properties.Resources.icons8_export_32;
            this.btnex.Location = new System.Drawing.Point(579, 236);
            this.btnex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(92, 41);
            this.btnex.TabIndex = 44;
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
            this.btnrefresh.Location = new System.Drawing.Point(384, 236);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(102, 41);
            this.btnrefresh.TabIndex = 45;
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
            this.btnprint.Location = new System.Drawing.Point(492, 236);
            this.btnprint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(81, 41);
            this.btnprint.TabIndex = 46;
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
            this.btnclose.Location = new System.Drawing.Point(677, 236);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(87, 41);
            this.btnclose.TabIndex = 47;
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
            this.btndel.Location = new System.Drawing.Point(285, 236);
            this.btndel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(93, 41);
            this.btndel.TabIndex = 48;
            this.btndel.Text = "Delete";
            this.btndel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndel.UseVisualStyleBackColor = false;
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = true;
            this.btnadd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(693, 94);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(77, 40);
            this.btnadd.TabIndex = 67;
            this.btnadd.Text = "Add";
            this.btnadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // lblsub
            // 
            this.lblsub.AutoSize = true;
            this.lblsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsub.Location = new System.Drawing.Point(529, 62);
            this.lblsub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsub.Name = "lblsub";
            this.lblsub.Size = new System.Drawing.Size(63, 20);
            this.lblsub.TabIndex = 66;
            this.lblsub.Text = "Subject";
            // 
            // txtsub
            // 
            this.txtsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsub.Location = new System.Drawing.Point(641, 62);
            this.txtsub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsub.Name = "txtsub";
            this.txtsub.Size = new System.Drawing.Size(125, 20);
            this.txtsub.TabIndex = 65;
            // 
            // StudentsSubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(775, 284);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblsub);
            this.Controls.Add(this.txtsub);
            this.Controls.Add(this.btnex);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvsubjectsstudents);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentsSubjectsForm";
            this.Text = "StudentsSubjectsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvsubjectsstudents;
        private System.Windows.Forms.Button btnex;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lblsub;
        private System.Windows.Forms.TextBox txtsub;
    }
}