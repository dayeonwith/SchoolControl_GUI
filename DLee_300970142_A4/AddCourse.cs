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
    public partial class AddCourse : Form
    {
        CourseManager mng;


        public AddCourse(CourseManager aCourseManager)
        {
            InitializeComponent();
            this.mng = aCourseManager;
            this.Text = "Dayeon Lee 300970142";
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                Course aCourse = new Course()
                {
                    CourseCode = txtCourseCode.Text,
                    Name = txtCourseName.Text,
                    Description = txtDescription.Text
                };

                mng.AddCourse(aCourse);
                MessageBox.Show(aCourse.CourseCode+" is added","Dayeon Lee 300970142");
            }
            catch
            {
                MessageBox.Show("Failed to add a course");
            }

            finally
            {
                txtCourseCode.Clear();
                txtCourseName.Clear();
                txtDescription.Clear();
            }
        }

        private void btnCourseResetInfo_Click(object sender, EventArgs e)
        {
            txtCourseCode.Clear();
            txtCourseName.Clear();
            txtDescription.Clear();
        }
    }
}
