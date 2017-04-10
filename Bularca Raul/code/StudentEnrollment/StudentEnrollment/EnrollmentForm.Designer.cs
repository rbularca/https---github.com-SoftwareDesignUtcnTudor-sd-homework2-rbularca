namespace StudentEnrollment
{
    partial class EnrollmentForm
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
            this.studentNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentIdTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.courseNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.courseIdTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FindStudentBTN = new System.Windows.Forms.Button();
            this.FindCourseBTN = new System.Windows.Forms.Button();
            this.EnrollBTN = new System.Windows.Forms.Button();
            this.BackBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentNameTB
            // 
            this.studentNameTB.Location = new System.Drawing.Point(135, 81);
            this.studentNameTB.Name = "studentNameTB";
            this.studentNameTB.Size = new System.Drawing.Size(100, 20);
            this.studentNameTB.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name:";
            // 
            // studentIdTB
            // 
            this.studentIdTB.Location = new System.Drawing.Point(135, 50);
            this.studentIdTB.Name = "studentIdTB";
            this.studentIdTB.Size = new System.Drawing.Size(100, 20);
            this.studentIdTB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student id:";
            // 
            // courseNameTB
            // 
            this.courseNameTB.Location = new System.Drawing.Point(135, 180);
            this.courseNameTB.Name = "courseNameTB";
            this.courseNameTB.Size = new System.Drawing.Size(100, 20);
            this.courseNameTB.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Name:";
            // 
            // courseIdTB
            // 
            this.courseIdTB.Location = new System.Drawing.Point(135, 149);
            this.courseIdTB.Name = "courseIdTB";
            this.courseIdTB.Size = new System.Drawing.Size(100, 20);
            this.courseIdTB.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Course id:";
            // 
            // FindStudentBTN
            // 
            this.FindStudentBTN.Location = new System.Drawing.Point(135, 107);
            this.FindStudentBTN.Name = "FindStudentBTN";
            this.FindStudentBTN.Size = new System.Drawing.Size(75, 20);
            this.FindStudentBTN.TabIndex = 21;
            this.FindStudentBTN.Text = "Find student";
            this.FindStudentBTN.UseVisualStyleBackColor = true;
            this.FindStudentBTN.Click += new System.EventHandler(this.FindStudentBTN_Click);
            // 
            // FindCourseBTN
            // 
            this.FindCourseBTN.Location = new System.Drawing.Point(135, 206);
            this.FindCourseBTN.Name = "FindCourseBTN";
            this.FindCourseBTN.Size = new System.Drawing.Size(75, 20);
            this.FindCourseBTN.TabIndex = 22;
            this.FindCourseBTN.Text = "Find course";
            this.FindCourseBTN.UseVisualStyleBackColor = true;
            this.FindCourseBTN.Click += new System.EventHandler(this.FindCourseBTN_Click);
            // 
            // EnrollBTN
            // 
            this.EnrollBTN.Location = new System.Drawing.Point(94, 264);
            this.EnrollBTN.Name = "EnrollBTN";
            this.EnrollBTN.Size = new System.Drawing.Size(92, 20);
            this.EnrollBTN.TabIndex = 23;
            this.EnrollBTN.Text = "Enroll student";
            this.EnrollBTN.UseVisualStyleBackColor = true;
            this.EnrollBTN.Click += new System.EventHandler(this.EnrollBTN_Click);
            // 
            // BackBTN
            // 
            this.BackBTN.Location = new System.Drawing.Point(192, 264);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(75, 20);
            this.BackBTN.TabIndex = 24;
            this.BackBTN.Text = "Back";
            this.BackBTN.UseVisualStyleBackColor = true;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // EnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 328);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.EnrollBTN);
            this.Controls.Add(this.FindCourseBTN);
            this.Controls.Add(this.FindStudentBTN);
            this.Controls.Add(this.courseNameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.courseIdTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.studentNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentIdTB);
            this.Controls.Add(this.label1);
            this.Name = "EnrollmentForm";
            this.Text = "Enrollment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentIdTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox courseNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox courseIdTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FindStudentBTN;
        private System.Windows.Forms.Button FindCourseBTN;
        private System.Windows.Forms.Button EnrollBTN;
        private System.Windows.Forms.Button BackBTN;
    }
}