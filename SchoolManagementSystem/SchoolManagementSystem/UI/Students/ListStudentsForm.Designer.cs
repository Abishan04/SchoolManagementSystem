namespace SchoolManagementSystem.UI.Students
{
    partial class ListStudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListStudentsForm));
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblstu = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsubjects = new System.Windows.Forms.Button();
            this.btnex = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(99, 41);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(125, 20);
            this.txtsearch.TabIndex = 0;
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(8, 43);
            this.lblsearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(86, 13);
            this.lblsearch.TabIndex = 1;
            this.lblsearch.Text = "Enter Student ID";
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(227, 38);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(63, 23);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(689, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "No of Students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(770, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(11, 81);
            this.dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1053, 423);
            this.dgv.TabIndex = 4;
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
            this.lblstu.Size = new System.Drawing.Size(1064, 28);
            this.lblstu.TabIndex = 5;
            this.lblstu.Text = "Students Detail";
            this.lblstu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(-6, 512);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1200, 1);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnsubjects
            // 
            this.btnsubjects.AutoSize = true;
            this.btnsubjects.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnsubjects.FlatAppearance.BorderSize = 0;
            this.btnsubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubjects.Image = ((System.Drawing.Image)(resources.GetObject("btnsubjects.Image")));
            this.btnsubjects.Location = new System.Drawing.Point(635, 524);
            this.btnsubjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsubjects.Name = "btnsubjects";
            this.btnsubjects.Size = new System.Drawing.Size(133, 46);
            this.btnsubjects.TabIndex = 55;
            this.btnsubjects.Text = "Add subjects";
            this.btnsubjects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsubjects.UseVisualStyleBackColor = false;
            // 
            // btnex
            // 
            this.btnex.AutoSize = true;
            this.btnex.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnex.FlatAppearance.BorderSize = 0;
            this.btnex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnex.Image = ((System.Drawing.Image)(resources.GetObject("btnex.Image")));
            this.btnex.Location = new System.Drawing.Point(877, 524);
            this.btnex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(95, 46);
            this.btnex.TabIndex = 54;
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
            this.btnrefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Image")));
            this.btnrefresh.Location = new System.Drawing.Point(527, 524);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(102, 46);
            this.btnrefresh.TabIndex = 53;
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
            this.btnprint.Image = ((System.Drawing.Image)(resources.GetObject("btnprint.Image")));
            this.btnprint.Location = new System.Drawing.Point(774, 524);
            this.btnprint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(95, 46);
            this.btnprint.TabIndex = 52;
            this.btnprint.Text = "Print";
            this.btnprint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnprint.UseVisualStyleBackColor = false;
            // 
            // btnshow
            // 
            this.btnshow.AutoSize = true;
            this.btnshow.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnshow.FlatAppearance.BorderSize = 0;
            this.btnshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Image = global::SchoolManagementSystem.Properties.Resources.icons8_show_32;
            this.btnshow.Location = new System.Drawing.Point(424, 524);
            this.btnshow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(95, 46);
            this.btnshow.TabIndex = 51;
            this.btnshow.Text = "Show";
            this.btnshow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnshow.UseVisualStyleBackColor = false;
            // 
            // btnclose
            // 
            this.btnclose.AutoSize = true;
            this.btnclose.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(980, 524);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(87, 46);
            this.btnclose.TabIndex = 50;
            this.btnclose.Text = "Close";
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = false;
            // 
            // btnupdate
            // 
            this.btnupdate.AutoSize = true;
            this.btnupdate.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.Image")));
            this.btnupdate.Location = new System.Drawing.Point(320, 524);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(98, 46);
            this.btnupdate.TabIndex = 56;
            this.btnupdate.Text = "Update";
            this.btnupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnupdate.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            this.btndelete.AutoSize = true;
            this.btndelete.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.Location = new System.Drawing.Point(217, 524);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(95, 46);
            this.btndelete.TabIndex = 49;
            this.btndelete.Text = "Delete";
            this.btndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // btnedit
            // 
            this.btnedit.AutoSize = true;
            this.btnedit.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnedit.FlatAppearance.BorderSize = 0;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.Location = new System.Drawing.Point(114, 524);
            this.btnedit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(95, 46);
            this.btnedit.TabIndex = 48;
            this.btnedit.Text = "Edit";
            this.btnedit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnedit.UseVisualStyleBackColor = false;
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = true;
            this.btnadd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(11, 524);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(95, 46);
            this.btnadd.TabIndex = 47;
            this.btnadd.Text = "Add";
            this.btnadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // ListStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1064, 581);
            this.Controls.Add(this.btnsubjects);
            this.Controls.Add(this.btnex);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblstu);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.txtsearch);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ListStudentsForm";
            this.Text = "ListStudentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblstu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsubjects;
        private System.Windows.Forms.Button btnex;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
    }
}