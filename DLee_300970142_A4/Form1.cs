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
    public partial class Form1 : Form
    {
        CourseManager courseManager = new CourseManager();
        OpenFileDialog ofd = new OpenFileDialog();


        public Form1()
        {
            InitializeComponent();
            ShowCreatedCourses();
            this.Text = "Dayeon Lee 300970142";
        }


        private void btnSelectAddCourse_Click(object sender, EventArgs e)
        {
            AddCourse addCourse = new AddCourse(courseManager);
            addCourse.Show();
        }

        private void btnSelectAddSection_Click(object sender, EventArgs e)
        {
            AddSection addSection = new AddSection(courseManager);
            addSection.Show();
        }

        private void btnSelectAddTeacher_Click(object sender, EventArgs e)
        {
            AddTeacher addTeacher = new AddTeacher(courseManager);
            addTeacher.Show();
        }

        private void ShowCreatedCourses()
        {
            foreach (Course aCourse in courseManager.Courses)
            {
                listOfCreatedCourse.Items.Add(aCourse.CourseCode);
            }

        }


        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            listOfCreatedCourse.Items.Clear();
            ShowCreatedCourses();
        }

        private void btnCourseDetail_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listOfCreatedCourse.SelectedIndex;
                Course aCourse = courseManager.Courses[index];
                DetailCourse detailCourse = new DetailCourse(aCourse);
                detailCourse.ShowDialog();
            }
            catch
            {
                if (listOfCreatedCourse.SelectedIndex == -1)
                {
                    MessageBox.Show("There is no added course", "Dayeon Lee 300970142");
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            courseManager.SaveSchoolInfo();
        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "DAT|*.dat";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                courseManager.LoadSchool(ofd.FileName);
                ShowCreatedCourses(); 
            }

        }

        



    }
}
