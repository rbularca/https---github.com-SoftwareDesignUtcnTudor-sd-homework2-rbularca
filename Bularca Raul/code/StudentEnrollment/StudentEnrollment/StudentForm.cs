using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEnrollment
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            (Tag as Main).Show();
            Close();
        }

        private void CreateBTN_Click(object sender, EventArgs e)
        {
            idTB.Text = new StudentRepository().CreateStudent(nameTB.Text, DateTime.ParseExact(DOBTB.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture), AddressTB.Text);
        }

        private void FindBTN_Click(object sender, EventArgs e)
        {
            Student student;
            if(!string.IsNullOrEmpty(idTB.Text))
            {
                UpdateStudentFields(new StudentRepository().GetStudentById(int.Parse(idTB.Text)));
                return;
            }

            if(!string.IsNullOrEmpty(nameTB.Text))
            {
                UpdateStudentFields(new StudentRepository().GetStudentByName(nameTB.Text));
            }
        }

        private void UpdateStudentFields(Student student)
        {
            if (student == null)
                return;
            idTB.Text = student.Id.ToString();
            nameTB.Text = student.Name;
            DOBTB.Text = student.DateOfBirth.Date.ToString();
            AddressTB.Text = student.Address;

            var coursesEnrolled = new EnrollmentRepository().GetCoursesForStudentId(student.Id);
            var courseRepository = new CourseRepository();

            foreach(var courseId in coursesEnrolled)
            {
                var currentCourse = courseRepository.GetCourseById(courseId);
                listBox1.Items.Add(currentCourse.Name + "  " + currentCourse.Teacher);
            }
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            var studentToUpdate = new Student(int.Parse(idTB.Text), nameTB.Text, DateTime.ParseExact(DOBTB.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture), AddressTB.Text);
            new StudentRepository().UpdateStudent(studentToUpdate);
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            new StudentRepository().DeleteStudentById(int.Parse(idTB.Text));
        }
    }
}
