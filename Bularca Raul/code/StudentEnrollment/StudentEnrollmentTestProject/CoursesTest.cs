using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentEnrollment;

namespace StudentEnrollmentTestProject
{
    [TestClass]
    public class CoursesTests
    {
        public const string Name = "SD";
        public const string Professor = "professor";
        public const string StudyYear = "3";

        CourseRepository _repository;

        [TestInitialize]
        public void BeforeEach()
        {
            _repository = new CourseRepository();
        }

        [TestMethod]
        public void RepositoryInsertsNewCourseAndReadsNewCourse()
        {
            // Arrange

            // Act
            var id = int.Parse(_repository.CreateCourse(Name, Professor, StudyYear));

            // Assert
            var readCourse = _repository.GetCourseById(id);
            Assert.IsTrue(readCourse.Name == Name && readCourse.Teacher == Professor && readCourse.StudyYear == StudyYear);

            // clean up
            _repository.DeleteCourseById(id);
        }

        [TestMethod]
        public void RepositoryDeletesCourse()
        {
            // Arrange
            var id = int.Parse(_repository.CreateCourse(Name, Professor, StudyYear));

            // Act
            _repository.DeleteCourseById(id);

            // Assert
            _repository.DeleteCourseById(id);
            Assert.IsNull(_repository.GetCourseById(id));
        }

        [TestMethod]
        public void RepositoryEditsCourse()
        {
            // Arrange
            var id = int.Parse(_repository.CreateCourse(Name, Professor, StudyYear));

            var newName = "SoftwareDesign";
            var newProfessor = "Other professor";
            var newYear = "4";

            var updatedCourse = new Course(id, newName, newProfessor, newYear);
            // Act
            _repository.UpdateCourse(updatedCourse);

            // Assert
            var resultedCourse = _repository.GetCourseById(id);
            Assert.IsTrue(CompareCourses(updatedCourse, resultedCourse));

            // Clean-up
            _repository.DeleteCourseById(id);
        }

        private bool CompareCourses(Course expectedCourse, Course actualCourse)
        {
            return expectedCourse.Id == actualCourse.Id 
                && expectedCourse.Name == actualCourse.Name 
                && expectedCourse.StudyYear == actualCourse.StudyYear 
                && expectedCourse.Teacher == actualCourse.Teacher;
        }
    }
}
