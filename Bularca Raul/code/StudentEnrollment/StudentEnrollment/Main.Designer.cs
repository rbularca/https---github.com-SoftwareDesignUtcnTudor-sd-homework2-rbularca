namespace StudentEnrollment
{
    partial class Main
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
            this.StudentsBTN = new System.Windows.Forms.Button();
            this.EnrollmentsBTN = new System.Windows.Forms.Button();
            this.CoursesBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentsBTN
            // 
            this.StudentsBTN.Location = new System.Drawing.Point(40, 34);
            this.StudentsBTN.Name = "StudentsBTN";
            this.StudentsBTN.Size = new System.Drawing.Size(105, 30);
            this.StudentsBTN.TabIndex = 0;
            this.StudentsBTN.Text = "Students";
            this.StudentsBTN.UseVisualStyleBackColor = true;
            this.StudentsBTN.Click += new System.EventHandler(this.StudentsBTN_Click);
            // 
            // EnrollmentsBTN
            // 
            this.EnrollmentsBTN.Location = new System.Drawing.Point(40, 171);
            this.EnrollmentsBTN.Name = "EnrollmentsBTN";
            this.EnrollmentsBTN.Size = new System.Drawing.Size(105, 30);
            this.EnrollmentsBTN.TabIndex = 3;
            this.EnrollmentsBTN.Text = "Enrollments";
            this.EnrollmentsBTN.UseVisualStyleBackColor = true;
            this.EnrollmentsBTN.Click += new System.EventHandler(this.EnrollmentsBTN_Click);
            // 
            // CoursesBTN
            // 
            this.CoursesBTN.Location = new System.Drawing.Point(40, 104);
            this.CoursesBTN.Name = "CoursesBTN";
            this.CoursesBTN.Size = new System.Drawing.Size(105, 30);
            this.CoursesBTN.TabIndex = 4;
            this.CoursesBTN.Text = "Courses";
            this.CoursesBTN.UseVisualStyleBackColor = true;
            this.CoursesBTN.Click += new System.EventHandler(this.CoursesBTN_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 261);
            this.Controls.Add(this.CoursesBTN);
            this.Controls.Add(this.EnrollmentsBTN);
            this.Controls.Add(this.StudentsBTN);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StudentsBTN;
        private System.Windows.Forms.Button EnrollmentsBTN;
        private System.Windows.Forms.Button CoursesBTN;
    }
}