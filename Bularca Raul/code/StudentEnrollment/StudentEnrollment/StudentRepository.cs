using MySql.Data.MySqlClient;
using System;
using System.Globalization;

namespace StudentEnrollment
{
    class StudentRepository
    {
        string connectionString = "server=localhost;user id=root;pwd=parola;database=studentenrollment";
        public string CreateStudent(string name, DateTime dateOfBirth, string address)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand("Insert into students(name, dateOfbirth, address) values (@name, @DOB, @address)", connection);
                command.Parameters.Add(new MySqlParameter("name", name));
                command.Parameters.Add(new MySqlParameter("DOB", dateOfBirth.Date));
                command.Parameters.Add(new MySqlParameter("address", address));

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

            return GetIdByFields(name, dateOfBirth, address);
        }

        private string GetIdByFields(string name, DateTime dateOfBirth, string address)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand("Select id from students where name=@name AND dateOfBirth=@DOB AND address=@address", connection);
                command.Parameters.Add(new MySqlParameter("name", name));
                command.Parameters.Add(new MySqlParameter("DOB", dateOfBirth.Date));
                command.Parameters.Add(new MySqlParameter("address", address));

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

        public bool DeleteStudentById(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand("delete from students where id=@id", connection);
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

        public Student GetStudentById(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand("Select * from students where id=@id", connection);
                command.Parameters.Add(new MySqlParameter("id", id));

                try
                {
                    connection.Open();
                    var databaseStudent = command.ExecuteReader();
                    if (databaseStudent.Read())
                        return new Student(int.Parse(databaseStudent[0].ToString()), databaseStudent[1].ToString(), databaseStudent.GetDateTime(2).Date, databaseStudent[3].ToString());
                    return null;
                }
                catch (Exception ex)
                {
                    return null;
                }
                finally { connection.Close(); }
            }
        }

        public Student GetStudentByName(string name)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand("Select * from students where name=@name", connection);
                command.Parameters.Add(new MySqlParameter("name", name));

                try
                {
                    connection.Open();
                    var databaseStudent = command.ExecuteReader();
                    if(databaseStudent.Read())
                        return new Student(int.Parse(databaseStudent[0].ToString()), databaseStudent[1].ToString(), databaseStudent.GetDateTime(2).Date, databaseStudent[3].ToString());
                    return null;
                }
                catch (Exception ex)
                {
                    return null;
                }
                finally { connection.Close(); }
            }
        }

        public void UpdateStudent(Student student)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand("Update students set name=@name, dateOfBirth=@DOB, address=@address WHERE id=@id", connection);
                command.Parameters.Add(new MySqlParameter("id", student.Id));
                command.Parameters.Add(new MySqlParameter("name", student.Name));
                command.Parameters.Add(new MySqlParameter("DOB", student.DateOfBirth.Date));
                command.Parameters.Add(new MySqlParameter("address", student.Address));

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
