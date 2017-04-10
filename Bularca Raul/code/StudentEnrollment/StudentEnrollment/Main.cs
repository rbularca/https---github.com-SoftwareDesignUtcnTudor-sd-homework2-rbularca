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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void StudentsBTN_Click(object sender, EventArgs e)
        {
            var studentForm = new StudentForm();
            studentForm.Tag = this;
            Hide();
            studentForm.Show();
        }

        private void CoursesBTN_Click(object sender, EventArgs e)
        {
            var courseForm = new CourseForm();
            courseForm.Tag = this;
            Hide();
            courseForm.Show();
        }

        private void EnrollmentsBTN_Click(object sender, EventArgs e)
        {
            var enrollmentForm = new EnrollmentForm();
            enrollmentForm.Tag = this;
            Hide();
            enrollmentForm.Show();
        }
    }
}
