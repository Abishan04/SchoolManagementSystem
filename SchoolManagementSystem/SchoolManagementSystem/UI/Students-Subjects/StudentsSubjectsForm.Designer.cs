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
            this.btnexport = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
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
            // btnexport
            // 
            this.btnexport.AutoSize = true;
            this.btnexport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.Image = global::SchoolManagementSystem.Properties.Resources.icons8_export_32;
            this.btnexport.Location = new System.Drawing.Point(589, 236);
            this.btnexport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(90, 41);
            this.btnexport.TabIndex = 44;
            this.btnexport.Text = "Export";
            this.btnexport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexport.UseVisualStyleBackColor = true;
            // 
            // btnrefresh
            // 
            this.btnrefresh.AutoSize = true;
            this.btnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Image = global::SchoolManagementSystem.Properties.Resources.icons8_refresh_32;
            this.btnrefresh.Location = new System.Drawing.Point(410, 236);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(100, 41);
            this.btnrefresh.TabIndex = 45;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnrefresh.UseVisualStyleBackColor = true;
            // 
            // btnprint
            // 
            this.btnprint.AutoSize = true;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Image = global::SchoolManagementSystem.Properties.Resources.icons8_print_32;
            this.btnprint.Location = new System.Drawing.Point(510, 236);
            this.btnprint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(79, 41);
            this.btnprint.TabIndex = 46;
            this.btnprint.Text = "Print";
            this.btnprint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.AutoSize = true;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = global::SchoolManagementSystem.Properties.Resources.icons8_close_32;
            this.btnclose.Location = new System.Drawing.Point(679, 236);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(85, 41);
            this.btnclose.TabIndex = 47;
            this.btnclose.Text = "Close";
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.AutoSize = true;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Image = global::SchoolManagementSystem.Properties.Resources.icons8_delete_32;
            this.btndelete.Location = new System.Drawing.Point(319, 236);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(91, 41);
            this.btndelete.TabIndex = 48;
            this.btndelete.Text = "Delete";
            this.btndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = true;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(693, 94);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 39);
            this.btnadd.TabIndex = 67;
            this.btnadd.Text = "Add";
            this.btnadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnadd.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(775, 284);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblsub);
            this.Controls.Add(this.txtsub);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndelete);
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
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lblsub;
        private System.Windows.Forms.TextBox txtsub;
    }
}