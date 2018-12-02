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
    public partial class AddTeacher : Form
    {
        CourseManager aCourseManager;
        Course aCourse;

        public AddTeacher(CourseManager courseManager)
        {
            this.aCourseManager = courseManager;
            InitializeComponent();
            AddItemToCourseList();
            this.Text = "Dayeon Lee 300970142";

        }

        private void AddItemToSectionList()
        {
            foreach (Section aSection in aCourse.Sections)
            {
                listTeacherSection.Items.Add(aSection.SectionId);
            }

        }

        private void AddItemToCourseList()
        {
            foreach (Course aCourse in aCourseManager.Courses)
            {
                comboBox1.Items.Add(aCourse.CourseCode);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            this.aCourse=aCourseManager.Courses[index];
            comboBox1.Items.Clear();
            AddItemToCourseList();
            AddItemToSectionList();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                Teacher aTeacher = new Teacher()
                {
                    Name = txtTeacherName.Text,
                    DOB = dateDOB.Value,
                    Address = new Address(txtTeacherStreet.Text, txtTeacherCity.Text, txtTeacherProvince.Text)
                };

                int index = listTeacherSection.SelectedIndex;
                aCourse.Sections[index].Faculty = aTeacher;

                MessageBox.Show("Teacher " + aTeacher.Name + " is added to " + aCourse.CourseCode + " " + aCourse.Sections[index].SectionId);
            }
            catch
            {
                if (listTeacherSection.SelectedIndex == -1)
                {
                    MessageBox.Show("Section is not selected","Dayeon Lee 300970142");
                }

                else
                {
                    MessageBox.Show("Failed to add the teacher to section", "Dayeon Lee 300970142");
                }
            }

            finally
            {
                txtTeacherCity.Clear();
                txtTeacherName.Clear();
                txtTeacherProvince.Clear();
                txtTeacherStreet.Clear();
            }
        }

        private void btnResetTeacherInfo_Click(object sender, EventArgs e)
        {
            txtTeacherCity.Clear();
            txtTeacherName.Clear();
            txtTeacherProvince.Clear();
            txtTeacherStreet.Clear();
        }
    }
}
