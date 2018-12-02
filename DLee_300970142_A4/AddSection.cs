using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary;

namespace DLee_300970142_A4
{
    public partial class AddSection : Form
    {
        CourseManager aCourseManager;

        public AddSection(CourseManager courseManager)
        {
            this.aCourseManager = courseManager;
            InitializeComponent();
            AddItemToList();
            this.Text = "Dayeon Lee 300970142";
        }

        public void AddItemToList()
        {
            foreach (Course aCourse in aCourseManager.Courses)
            {
                listSectionCourse.Items.Add(aCourse.CourseCode);
            }
        }

        private void btnAddSection_Click(object sender, EventArgs e)
        {
            try
            {
                Section aSection = new Section()
                {
                    SectionId = txtSectionID.Text,
                    Name = txtSectionName.Text,
                    MaxNumberOfStudents = Convert.ToInt32(txtSectionMaxStu.Text)
                };
                int index = listSectionCourse.SelectedIndex;
                aCourseManager.Courses[index].AddSection(aSection);

                MessageBox.Show(aSection.SectionId + " is added to "+ aCourseManager.Courses[index].CourseCode, "Dayeon Lee 300970142");
            }
            catch
            {
                if (listSectionCourse.SelectedIndex == -1)
                {
                    MessageBox.Show("Course is not selected", "Dayeon Lee 300970142");
               
                }
                else
                    MessageBox.Show("Failed to add the section to course", "Dayeon Lee 300970142");
            }

            finally
            {
                txtSectionID.Clear();
                txtSectionMaxStu.Clear();
                txtSectionName.Clear();
            }


}

        private void btnSectionResetInfo_Click(object sender, EventArgs e)
        {
            txtSectionID.Clear();
            txtSectionMaxStu.Clear();
            txtSectionName.Clear();
        }
    }
}
