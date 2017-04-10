using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment
{
    class EnrollmentRepository
    {
        string connectionString = "server=localhost;user id=root;pwd=parola;database=studentenrollment";
        public List<int> GetCoursesForStudentId(int studentId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand("Select course_id from enrollments where student_id=@student_id", connection);
                command.Parameters.Add(new MySqlParameter("student_id", studentId));

                try
                {
                    var returnList = new List<int>();
                    connection.Open();
                    var results = command.ExecuteReader();
                    while (results.Read())
                        returnList.Add(results.GetInt32(0));
                    return returnList;
                }
                catch (Exception ex)
                {
                    return null;
                }
                finally { connection.Close(); }
            }
        }

        public List<int> GetStudentsForCourseId(int courseId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand("Select student_id from enrollments where course_id=@course_id", connection);
                command.Parameters.Add(new MySqlParameter("course_id", courseId));

                try
                {
                    var returnList = new List<int>();
                    connection.Open();
                    var results = command.ExecuteReader();
                    while (results.Read())
                        returnList.Add(results.GetInt32(0));
                    return returnList;
                }
                catch (Exception ex)
                {
                    return null;
                }
                finally { connection.Close(); }
            }
        }

        public void EnrollStudentToCourse(int studentId, int courseId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand("Insert into enrollments(student_id, course_id) values (@student_id, @course_id)", connection);

                command.Parameters.Add(new MySqlParameter("student_id", studentId));
                command.Parameters.Add(new MySqlParameter("course_id", courseId));

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return;
                }
                finally { connection.Close(); }
            }
        }
    }
}
