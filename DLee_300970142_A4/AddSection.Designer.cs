namespace DLee_300970142_A4
{
    partial class AddSection
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSectionID = new System.Windows.Forms.Label();
            this.lblSectionName = new System.Windows.Forms.Label();
            this.lblSectionMaxStu = new System.Windows.Forms.Label();
            this.lblSectionSemester = new System.Windows.Forms.Label();
            this.txtSectionID = new System.Windows.Forms.TextBox();
            this.txtSectionName = new System.Windows.Forms.TextBox();
            this.txtSectionMaxStu = new System.Windows.Forms.TextBox();
            this.lblSectionCourse = new System.Windows.Forms.Label();
            this.comboSectionSemester = new System.Windows.Forms.ComboBox();
            this.listSectionCourse = new System.Windows.Forms.ListBox();
            this.btnAddSection = new System.Windows.Forms.Button();
            this.btnSectionResetInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(89, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Section";
            // 
            // lblSectionID
            // 
            this.lblSectionID.AutoSize = true;
            this.lblSectionID.Location = new System.Drawing.Point(50, 66);
            this.lblSectionID.Name = "lblSectionID";
            this.lblSectionID.Size = new System.Drawing.Size(62, 12);
            this.lblSectionID.TabIndex = 1;
            this.lblSectionID.Text = "Section ID";
            // 
            // lblSectionName
            // 
            this.lblSectionName.AutoSize = true;
            this.lblSectionName.Location = new System.Drawing.Point(30, 90);
            this.lblSectionName.Name = "lblSectionName";
            this.lblSectionName.Size = new System.Drawing.Size(85, 12);
            this.lblSectionName.TabIndex = 2;
            this.lblSectionName.Text = "Section Name";
            // 
            // lblSectionMaxStu
            // 
            this.lblSectionMaxStu.AutoSize = true;
            this.lblSectionMaxStu.Location = new System.Drawing.Point(22, 114);
            this.lblSectionMaxStu.Name = "lblSectionMaxStu";
            this.lblSectionMaxStu.Size = new System.Drawing.Size(92, 12);
            this.lblSectionMaxStu.TabIndex = 3;
            this.lblSectionMaxStu.Text = "Max Of Student";
            // 
            // lblSectionSemester
            // 
            this.lblSectionSemester.AutoSize = true;
            this.lblSectionSemester.Location = new System.Drawing.Point(57, 138);
            this.lblSectionSemester.Name = "lblSectionSemester";
            this.lblSectionSemester.Size = new System.Drawing.Size(59, 12);
            this.lblSectionSemester.TabIndex = 4;
            this.lblSectionSemester.Text = "Semester";
            // 
            // txtSectionID
            // 
            this.txtSectionID.Location = new System.Drawing.Point(134, 64);
            this.txtSectionID.Name = "txtSectionID";
            this.txtSectionID.Size = new System.Drawing.Size(140, 21);
            this.txtSectionID.TabIndex = 5;
            // 
            // txtSectionName
            // 
            this.txtSectionName.Location = new System.Drawing.Point(134, 88);
            this.txtSectionName.Name = "txtSectionName";
            this.txtSectionName.Size = new System.Drawing.Size(140, 21);
            this.txtSectionName.TabIndex = 6;
            // 
            // txtSectionMaxStu
            // 
            this.txtSectionMaxStu.Location = new System.Drawing.Point(134, 112);
            this.txtSectionMaxStu.Name = "txtSectionMaxStu";
            this.txtSectionMaxStu.Size = new System.Drawing.Size(140, 21);
            this.txtSectionMaxStu.TabIndex = 8;
            // 
            // lblSectionCourse
            // 
            this.lblSectionCourse.AutoSize = true;
            this.lblSectionCourse.Location = new System.Drawing.Point(76, 162);
            this.lblSectionCourse.Name = "lblSectionCourse";
            this.lblSectionCourse.Size = new System.Drawing.Size(46, 12);
            this.lblSectionCourse.TabIndex = 10;
            this.lblSectionCourse.Text = "Course";
            // 
            // comboSectionSemester
            // 
            this.comboSectionSemester.FormattingEnabled = true;
            this.comboSectionSemester.Items.AddRange(new object[] {
            "FALL",
            "WINTER",
            "SUMMER"});
            this.comboSectionSemester.Location = new System.Drawing.Point(134, 136);
            this.comboSectionSemester.Name = "comboSectionSemester";
            this.comboSectionSemester.Size = new System.Drawing.Size(140, 20);
            this.comboSectionSemester.TabIndex = 11;
            // 
            // listSectionCourse
            // 
            this.listSectionCourse.FormattingEnabled = true;
            this.listSectionCourse.ItemHeight = 12;
            this.listSectionCourse.Location = new System.Drawing.Point(135, 161);
            this.listSectionCourse.Name = "listSectionCourse";
            this.listSectionCourse.Size = new System.Drawing.Size(139, 88);
            this.listSectionCourse.TabIndex = 12;
            // 
            // btnAddSection
            // 
            this.btnAddSection.Location = new System.Drawing.Point(54, 262);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(87, 21);
            this.btnAddSection.TabIndex = 13;
            this.btnAddSection.Text = "Add";
            this.btnAddSection.UseVisualStyleBackColor = true;
            this.btnAddSection.Click += new System.EventHandler(this.btnAddSection_Click);
            // 
            // btnSectionResetInfo
            // 
            this.btnSectionResetInfo.Location = new System.Drawing.Point(162, 262);
            this.btnSectionResetInfo.Name = "btnSectionResetInfo";
            this.btnSectionResetInfo.Size = new System.Drawing.Size(87, 21);
            this.btnSectionResetInfo.TabIndex = 14;
            this.btnSectionResetInfo.Text = "Reset";
            this.btnSectionResetInfo.UseVisualStyleBackColor = true;
            this.btnSectionResetInfo.Click += new System.EventHandler(this.btnSectionResetInfo_Click);
            // 
            // AddSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 294);
            this.Controls.Add(this.btnSectionResetInfo);
            this.Controls.Add(this.btnAddSection);
            this.Controls.Add(this.listSectionCourse);
            this.Controls.Add(this.comboSectionSemester);
            this.Controls.Add(this.lblSectionCourse);
            this.Controls.Add(this.txtSectionMaxStu);
            this.Controls.Add(this.txtSectionName);
            this.Controls.Add(this.txtSectionID);
            this.Controls.Add(this.lblSectionSemester);
            this.Controls.Add(this.lblSectionMaxStu);
            this.Controls.Add(this.lblSectionName);
            this.Controls.Add(this.lblSectionID);
            this.Controls.Add(this.label1);
            this.Name = "AddSection";
            this.Text = "AddSection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSectionID;
        private System.Windows.Forms.Label lblSectionName;
        private System.Windows.Forms.Label lblSectionMaxStu;
        private System.Windows.Forms.Label lblSectionSemester;
        private System.Windows.Forms.TextBox txtSectionID;
        private System.Windows.Forms.TextBox txtSectionName;
        private System.Windows.Forms.TextBox txtSectionMaxStu;
        private System.Windows.Forms.Label lblSectionCourse;
        private System.Windows.Forms.ComboBox comboSectionSemester;
        private System.Windows.Forms.ListBox listSectionCourse;
        private System.Windows.Forms.Button btnAddSection;
        private System.Windows.Forms.Button btnSectionResetInfo;
    }
}