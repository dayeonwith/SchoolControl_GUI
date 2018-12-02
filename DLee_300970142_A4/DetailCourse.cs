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
    public partial class DetailCourse : Form
    {
        public DetailCourse(Course course)
        {
            InitializeComponent();
            label5.Text=course.CourseCode;
            label6.Text = course.Name;
            label7.Text = course.Description;
            label8.Text = "";
            foreach (Section aSection in course.Sections)
            {
                label8.Text += aSection.SectionId + "\n";
            }
            this.Text = "Dayeon Lee 300970142";
        }

        private void DetailCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
