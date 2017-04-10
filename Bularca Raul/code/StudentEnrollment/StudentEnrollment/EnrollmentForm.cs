using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEnrollment
{
    public partial class EnrollmentForm : Form
    {
        public EnrollmentForm()
        {
            InitializeComponent();
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            (Tag as Main).Show();
            Close();
        }

        private void FindStudentBTN_Click(object sender, EventArgs e)
        {
            Student student;
            if (!string.IsNullOrEmpty(studentIdTB.Text))
            {
                UpdateStudentFields(new StudentRepository().GetStudentById(int.Parse(studentIdTB.Text)));
                return;
            }

            if (!string.IsNullOrEmpty(studentNameTB.Text))
            {
                UpdateStudentFields(new StudentRepository().GetStudentByName(studentNameTB.Text));
            }
        }

        private void UpdateStudentFields(Student student)
        {
            if (student == null)
                return;
            studentIdTB.Text = student.Id.ToString();
            studentNameTB.Text = student.Name;
        }

        private void FindCourseBTN_Click(object sender, EventArgs e)
        {
            Course Course;
            if (!string.IsNullOrEmpty(courseIdTB.Text))
            {
                UpdateCourseFields(new CourseRepository().GetCourseById(int.Parse(courseIdTB.Text)));
                return;
            }

            if (!string.IsNullOrEmpty(courseNameTB.Text))
            {
                UpdateCourseFields(new CourseRepository().GetCourseByName(courseNameTB.Text));
            }
        }

        private void UpdateCourseFields(Course course)
        {
            if (course == null)
                return;
            courseIdTB.Text = course.Id.ToString();
            courseNameTB.Text = course.Name;
        }

        private void EnrollBTN_Click(object sender, EventArgs e)
        {
            new EnrollmentRepository().EnrollStudentToCourse(int.Parse(studentIdTB.Text), int.Parse(courseIdTB.Text));
        }
    }
}
