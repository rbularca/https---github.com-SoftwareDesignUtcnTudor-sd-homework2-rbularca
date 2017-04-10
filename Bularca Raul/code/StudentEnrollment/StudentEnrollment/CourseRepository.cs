using MySql.Data.MySqlClient;
using System;
using System.Globalization;

namespace StudentEnrollment
{
    public class CourseRepository 
    {
        string connectionString = "server=localhost;user id=root;pwd=parola;database=studentenrollment";
        public string CreateCourse(string name, string teacher, string studyYear)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand("Insert into courses(name, teacher, studyYear) values (@name, @teacher, @studyYear)", connection);
                command.Parameters.Add(new MySqlParameter("name", name));
                command.Parameters.Add(new MySqlParameter("teacher", teacher));
                command.Parameters.Add(new MySqlParameter("studyYear", studyYear));

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return "-1";
                }
                finally { connection.Close(); }
            }

            return GetIdByFields(name, teacher, studyYear);
        }

        private string GetIdByFields(string name, string teacher, string studyYear)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand("Select id from courses where name=@name AND teacher=@teacher AND studyYear=@studyYear", connection);
                command.Parameters.Add(new MySqlParameter("name", name));
                command.Parameters.Add(new MySqlParameter("teacher", teacher));
                command.Parameters.Add(new MySqlParameter("studyYear", studyYear));

                try
                {
                    connection.Open();
                    return command.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    return "-1";
                }
                finally { connection.Close(); }
            }
        }

        public bool DeleteCourseById(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand("delete from courses where id=@id", connection);
                command.Parameters.Add(new MySqlParameter("id", id));

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally { connection.Close(); }
            }
        }

        public Course GetCourseById(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand("Select * from courses where id=@id", connection);
                command.Parameters.Add(new MySqlParameter("id", id));

                try
                {
                    connection.Open();
                    var databaseCourse = command.ExecuteReader();
                    if (databaseCourse.Read())
                        return new Course(int.Parse(databaseCourse[0].ToString()), databaseCourse[1].ToString(), databaseCourse[2].ToString(), databaseCourse[3].ToString());
                    return null;
                }
                catch (Exception ex)
                {
                    return null;
                }
                finally { connection.Close(); }
            }
        }

        public Course GetCourseByName(string name)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand("Select * from courses where name=@name", connection);
                command.Parameters.Add(new MySqlParameter("name", name));

                try
                {
                    connection.Open();
                    var databaseCourse = command.ExecuteReader();
                    if (databaseCourse.Read())
                        return new Course(int.Parse(databaseCourse[0].ToString()), databaseCourse[1].ToString(), databaseCourse[2].ToString(), databaseCourse[3].ToString());
                    return null;
                }
                catch (Exception ex)
                {
                    return null;
                }
                finally { connection.Close(); }
            }
        }

        public void UpdateCourse(Course course)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand("Update courses set name=@name, teacher=@teacher, studyYear=@studyYear WHERE id=@id", connection);
                command.Parameters.Add(new MySqlParameter("id", course.Id));
                command.Parameters.Add(new MySqlParameter("name", course.Name));
                command.Parameters.Add(new MySqlParameter("teacher", course.Teacher));
                command.Parameters.Add(new MySqlParameter("studyYear", course.StudyYear));

                try
                {
                    connection.Open();
                    var databaseStudent = command.ExecuteReader();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                finally { connection.Close(); }
            }
        }
    }
}
