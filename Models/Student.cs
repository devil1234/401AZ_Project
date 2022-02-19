using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{

    /// <summary>
    /// Class Student.
    /// Implements the <see cref="_401AZ_PROJECT.Models.Person" />
    /// </summary>
    /// <seealso cref="_401AZ_PROJECT.Models.Person" />
    public class Student : Person
    {
        /// <summary>
        /// Gets or sets the student identifier.
        /// </summary>
        /// <value>The student identifier.</value>
        public int StudentId { get; set; }
        private readonly DataManager _c = new DataManager();

        //SELECT FNAME AND LNAME FOR STUDENT BY STUDENT ID
        /// <summary>
        /// Gets the student f name l name by identifier.
        /// </summary>
        /// <returns>List&lt;Student&gt;.</returns>
        public List<Student> GetStudent_FName_LName_By_Id()
        {
            var students = new List<Student>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();

                using (var cmd = new MySqlCommand("sp_select_student_fname_lname_by_id", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new Student
                            {
                                StudentId = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2)

                            });
                        }
                    }
                }
                return students;
            }
        }

        // SELECT ONLY THE STUDENT FNAME AND LNAME AND RETURNING AS A LIST
        /// <summary>
        /// Gets the name of the student f name l.
        /// </summary>
        /// <returns>List&lt;Student&gt;.</returns>
        public List<Student> GetStudent_FName_LName()
        {
            var students = new List<Student>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();

                using (var cmd = new MySqlCommand("sp_select_student_fname_lname", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new Student
                            {
                                StudentId = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2)

                            });
                        }
                    }
                }
                return students;
            }
        }

        // GET THE LIST OF STUDENTS AND RETURN THE LIST OF STUDENTS
        /// <summary>
        /// Gets the students.
        /// </summary>
        /// <returns>List&lt;Student&gt;.</returns>
        public List<Student> GetStudents()
        {
            var students = new List<Student>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();

                using (var cmd = new MySqlCommand("sp_select_students", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new Student 
                            {
                                StudentId = reader.GetInt32(0),
                                FirstName= reader.GetString(1),
                                LastName= reader.GetString(2),
                                Dob = reader.GetDateTime(3),
                                Gender = reader.GetString(4),
                                EMailAddress = reader.GetString(5),
                                ParentId = reader.GetInt32(6),
                                ParentFName = reader.GetString(7),
                                ParentLName = reader.GetString(8),
                                ParentPhoneNumber = reader.GetString(9),
                                AddressId = reader.GetInt32(10),
                                AddressStreet = reader.GetString(11),
                                AddressCity = reader.GetString(12),
                                AddressRegion = reader.GetString(13),
                                AddressPostcode = reader.GetString(14)

                            });
                        }
                    }
                }
                return students;
            }
        }

        // GET THE LIST OF STUDENTS BY ID 
        /// <summary>
        /// Gets the students by identifier.
        /// </summary>
        /// <param name="studentId">The student identifier.</param>
        /// <returns>List&lt;Student&gt;.</returns>
        public List<Student> GetStudentsById(int studentId)
        {
            var students = new List<Student>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();

                using (var cmd = new MySqlCommand("sp_select_students_by_student_id", connection))
                {
                    cmd.Parameters.AddWithValue("student_id_par", studentId);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new Student
                            {
                                StudentId = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Dob = reader.GetDateTime(3),
                                Gender = reader.GetString(4),
                                EMailAddress = reader.GetString(5),
                                ParentId = reader.GetInt32(6),
                                ParentFName = reader.GetString(7),
                                ParentLName = reader.GetString(8),
                                ParentPhoneNumber = reader.GetString(9),
                                AddressId = reader.GetInt32(10),
                                AddressStreet = reader.GetString(11),
                                AddressCity = reader.GetString(12),
                                AddressRegion = reader.GetString(13),
                                AddressPostcode = reader.GetString(14)

                            });
                        }
                    }
                }
                return students;
            }
        }

        // INSERT STUDENT DETAILS
        /// <summary>
        /// Inserts the student.
        /// </summary>
        /// <param name="student_first_name_id_par">The student first name identifier par.</param>
        /// <param name="student_last_Name_id_par">The student last name identifier par.</param>
        /// <param name="student_dob_id_par">The student dob identifier par.</param>
        /// <param name="gender_id_par">The gender identifier par.</param>
        /// <param name="student_e_mail_id_par">The student e mail identifier par.</param>
        /// <param name="student_parent_id_par">The student parent identifier par.</param>
        /// <param name="student_address_home_id_par">The student address home identifier par.</param>
        async public void InsertStudent(int student_first_name_id_par, int student_last_Name_id_par, int student_dob_id_par, 
            int gender_id_par, int student_e_mail_id_par, int student_parent_id_par, int student_address_home_id_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                await connection.OpenAsync();
                using (var cmd = new MySqlCommand("sp_insert_student", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("student_first_name_id_par", student_first_name_id_par);
                    cmd.Parameters.AddWithValue("student_last_Name_id_par", student_last_Name_id_par);
                    cmd.Parameters.AddWithValue("student_dob_id_par", student_dob_id_par);
                    cmd.Parameters.AddWithValue("gender_id_par", gender_id_par);
                    cmd.Parameters.AddWithValue("student_e_mail_id_par", student_e_mail_id_par);
                    cmd.Parameters.AddWithValue("student_parent_id_par", student_parent_id_par);
                    cmd.Parameters.AddWithValue("student_address_home_id_par", student_address_home_id_par);
                    await cmd.ExecuteNonQueryAsync();
                }

            }
        }

        /// <summary>
        /// Deletes the student.
        /// </summary>
        /// <param name="student_id_par">The student identifier par.</param>
        public void DeleteStudent(int student_id_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_delete_student_by_student_id", connection))
                {
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("student_id_par", student_id_par);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                }
            }

        }
        /// <summary>
        /// Updates the student.
        /// </summary>
        /// <param name="student_id_par">The student identifier par.</param>
        /// <param name="student_FirstNameId_par">The student first name identifier par.</param>
        /// <param name="student_LastNameId_par">The student last name identifier par.</param>
        /// <param name="student_DobId_par">The student dob identifier par.</param>
        /// <param name="GenderId_par">The gender identifier par.</param>
        /// <param name="student_EMailId_par">The student e mail identifier par.</param>
        /// <param name="student_parent_id_par">The student parent identifier par.</param>
        /// <param name="student_address_home_id_par">The student address home identifier par.</param>
        public void UpdateStudent(int student_id_par, int student_first_name_id_par, int student_last_Name_id_par, int student_dob_id_par,
            int gender_id_par, int student_e_mail_id_par, int student_parent_id_par, int student_address_home_id_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_update_student", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("student_id_par", student_id_par);
                    cmd.Parameters.AddWithValue("student_first_name_id_par", student_first_name_id_par);
                    cmd.Parameters.AddWithValue("student_last_Name_id_par", student_last_Name_id_par);
                    cmd.Parameters.AddWithValue("student_dob_id_par", student_dob_id_par);
                    cmd.Parameters.AddWithValue("gender_id_par", gender_id_par);
                    cmd.Parameters.AddWithValue("student_e_mail_id_par", student_e_mail_id_par);
                    cmd.Parameters.AddWithValue("student_parent_id_par", student_parent_id_par);
                    cmd.Parameters.AddWithValue("student_address_home_id_par", student_address_home_id_par);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
