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
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            (Tag as Main).Show();
            Close();
        }

        private void FindBTN_Click(object sender, EventArgs e)
        {
            Course Course;
            if (!string.IsNullOrEmpty(idTB.Text))
            {
                UpdateCourseFields(new CourseRepository().GetCourseById(int.Parse(idTB.Text)));
                return;
            }

            if (!string.IsNullOrEmpty(nameTB.Text))
            {
                UpdateCourseFields(new CourseRepository().GetCourseByName(nameTB.Text));
            }
        }

        private void UpdateCourseFields(Course course)
        {
            if (course == null)
                return;
            idTB.Text = course.Id.ToString();
            nameTB.Text = course.Name;
            TeacherTB.Text = course.Teacher;
            YearOfStudyTB.Text = course.StudyYear;

            var studentsEnrolled = new EnrollmentRepository().GetStudentsForCourseId(course.Id);
            var studentsRepository = new StudentRepository();

            foreach(var currentStudentId in studentsEnrolled)
            {
                var currentStudent = studentsRepository.GetStudentById(currentStudentId);
                listBox1.Items.Add(currentStudent.Name);
            }
        }

        private void CreateBTN_Click(object sender, EventArgs e)
        {
            idTB.Text = new CourseRepository().CreateCourse(nameTB.Text, TeacherTB.Text, YearOfStudyTB.Text);
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            var courseToUpdate = new Course(int.Parse(idTB.Text), nameTB.Text, TeacherTB.Text, YearOfStudyTB.Text);
            new CourseRepository().UpdateCourse(courseToUpdate);
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            new CourseRepository().DeleteCourseById(int.Parse(idTB.Text));
        }
    }
}
