using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Teacher { get; set; }
        public string StudyYear { get; set; }

        public Course(int id, string name, string teacher, string studyYear)
        {
            Id = id;
            Name = name;
            Teacher = teacher;
            StudyYear = studyYear;
        }
    }
}
