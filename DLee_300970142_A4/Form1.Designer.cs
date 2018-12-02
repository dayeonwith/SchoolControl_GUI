namespace DLee_300970142_A4
{
    partial class Form1
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
            this.btnSelectAddCourse = new System.Windows.Forms.Button();
            this.btnSelectAddSection = new System.Windows.Forms.Button();
            this.btnSelectAddTeacher = new System.Windows.Forms.Button();
            this.listOfCreatedCourse = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.btnCourseDetail = new System.Windows.Forms.Button();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectAddCourse
            // 
            this.btnSelectAddCourse.Location = new System.Drawing.Point(25, 89);
            this.btnSelectAddCourse.Name = "btnSelectAddCourse";
            this.btnSelectAddCourse.Size = new System.Drawing.Size(130, 21);
            this.btnSelectAddCourse.TabIndex = 0;
            this.btnSelectAddCourse.Text = "Add Course";
            this.btnSelectAddCourse.UseVisualStyleBackColor = true;
            this.btnSelectAddCourse.Click += new System.EventHandler(this.btnSelectAddCourse_Click);
            // 
            // btnSelectAddSection
            // 
            this.btnSelectAddSection.Location = new System.Drawing.Point(25, 128);
            this.btnSelectAddSection.Name = "btnSelectAddSection";
            this.btnSelectAddSection.Size = new System.Drawing.Size(130, 21);
            this.btnSelectAddSection.TabIndex = 1;
            this.btnSelectAddSection.Text = "Add Section";
            this.btnSelectAddSection.UseVisualStyleBackColor = true;
            this.btnSelectAddSection.Click += new System.EventHandler(this.btnSelectAddSection_Click);
            // 
            // btnSelectAddTeacher
            // 
            this.btnSelectAddTeacher.Location = new System.Drawing.Point(25, 165);
            this.btnSelectAddTeacher.Name = "btnSelectAddTeacher";
            this.btnSelectAddTeacher.Size = new System.Drawing.Size(130, 21);
            this.btnSelectAddTeacher.TabIndex = 2;
            this.btnSelectAddTeacher.Text = "Add Teacher";
            this.btnSelectAddTeacher.UseVisualStyleBackColor = true;
            this.btnSelectAddTeacher.Click += new System.EventHandler(this.btnSelectAddTeacher_Click);
            // 
            // listOfCreatedCourse
            // 
            this.listOfCreatedCourse.FormattingEnabled = true;
            this.listOfCreatedCourse.ItemHeight = 12;
            this.listOfCreatedCourse.Location = new System.Drawing.Point(170, 89);
            this.listOfCreatedCourse.Name = "listOfCreatedCourse";
            this.listOfCreatedCourse.Size = new System.Drawing.Size(139, 136);
            this.listOfCreatedCourse.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Manage Course";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(355, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.Location = new System.Drawing.Point(25, 202);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(130, 23);
            this.btnUpdateCourse.TabIndex = 7;
            this.btnUpdateCourse.Text = "Update Course List";
            this.btnUpdateCourse.UseVisualStyleBackColor = true;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // btnCourseDetail
            // 
            this.btnCourseDetail.Location = new System.Drawing.Point(182, 231);
            this.btnCourseDetail.Name = "btnCourseDetail";
            this.btnCourseDetail.Size = new System.Drawing.Size(115, 23);
            this.btnCourseDetail.TabIndex = 8;
            this.btnCourseDetail.Text = "See Detail Info";
            this.btnCourseDetail.UseVisualStyleBackColor = true;
            this.btnCourseDetail.Click += new System.EventHandler(this.btnCourseDetail_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.browseToolStripMenuItem.Text = "Browse";
            this.browseToolStripMenuItem.Click += new System.EventHandler(this.browseToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 319);
            this.Controls.Add(this.btnCourseDetail);
            this.Controls.Add(this.btnUpdateCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listOfCreatedCourse);
            this.Controls.Add(this.btnSelectAddTeacher);
            this.Controls.Add(this.btnSelectAddSection);
            this.Controls.Add(this.btnSelectAddCourse);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectAddCourse;
        private System.Windows.Forms.Button btnSelectAddSection;
        private System.Windows.Forms.Button btnSelectAddTeacher;
        private System.Windows.Forms.ListBox listOfCreatedCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.Button btnCourseDetail;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
    }
}

