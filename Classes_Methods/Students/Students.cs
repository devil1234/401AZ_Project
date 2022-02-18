using _401AZ_PROJECT.Classes_Methods.Addresses;
using _401AZ_PROJECT.Classes_Methods.Students.StudentParentsDetails;
using _401AZ_PROJECT.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _401AZ_PROJECT.Classes_Methods.Students.Students
{

    public class Student : Person
    {
        public int StudentId { get; set; }


        readonly DataManager c = new DataManager();

        //SELECT FNAME AND LNAME FOR STUDENT BY STUDENT ID
        public List<Student> GetStudent_FName_LName_By_Id()
        {
            List<Student> Students = new List<Student>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("sp_select_student_fname_lname_by_id", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Students.Add(new Student
                            {
                                StudentId = reader.GetInt32(0),
                                First_Name = reader.GetString(1),
                                Last_Name = reader.GetString(2)

                            });
                        }
                    }
                }
                return Students;
            }
        }

        // SELECT ONLY THE STUDENT FNAME AND LNAME AND RETURNING AS A LIST
        public List<Student> GetStudent_FName_LName()
        {
            List<Student> Students = new List<Student>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("sp_select_student_fname_lname", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Students.Add(new Student
                            {
                                StudentId = reader.GetInt32(0),
                                First_Name = reader.GetString(1),
                                Last_Name = reader.GetString(2)

                            });
                        }
                    }
                }
                return Students;
            }
        }

        // GET THE LIST OF STUDENTS AND RETURN THE LIST OF STUDENTS
        public List<Student> GetStudents()
        {
            List<Student> Students = new List<Student>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("sp_select_students", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Students.Add(new Student 
                            {
                                StudentId = reader.GetInt32(0),
                                First_Name= reader.GetString(1),
                                Last_Name= reader.GetString(2),
                                DOB = reader.GetDateTime(3),
                                Gender = reader.GetString(4),
                                EMail_Address = reader.GetString(5),
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
                return Students;
            }
        }

        // GET THE LIST OF STUDENTS BY ID 
        public List<Student> GetStudentsByID(int studentId)
        {
            List<Student> Students = new List<Student>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("sp_select_students_by_student_id", connection))
                {
                    cmd.Parameters.AddWithValue("student_id_par", studentId);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Students.Add(new Student
                            {
                                StudentId = reader.GetInt32(0),
                                First_Name = reader.GetString(1),
                                Last_Name = reader.GetString(2),
                                DOB = reader.GetDateTime(3),
                                Gender = reader.GetString(4),
                                EMail_Address = reader.GetString(5),
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
                return Students;
            }
        }

        // INSERT STUDENT DETAILS
        async public void InsertStudent(int student_first_name_id_par, int student_last_name_id_par, int student_dob_id_par, 
            int gender_id_par, int student_e_mail_id_par, int student_parent_id_par, int student_address_home_id_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                await connection.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand("sp_insert_student", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("student_first_name_id_par", student_first_name_id_par);
                    cmd.Parameters.AddWithValue("student_last_name_id_par", student_last_name_id_par);
                    cmd.Parameters.AddWithValue("student_dob_id_par", student_dob_id_par);
                    cmd.Parameters.AddWithValue("gender_id_par", gender_id_par);
                    cmd.Parameters.AddWithValue("student_e_mail_id_par", student_e_mail_id_par);
                    cmd.Parameters.AddWithValue("student_parent_id_par", student_parent_id_par);
                    cmd.Parameters.AddWithValue("student_address_home_id_par", student_address_home_id_par);
                    await cmd.ExecuteNonQueryAsync();
                }

            }
        }

        public void DeleteStudent(int student_id_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_delete_student_by_student_id", connection))
                {
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("student_id_par", student_id_par);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                }
            }

        }
        public void UpdateStudent(int student_id_par, int student_first_name_id_par, int student_last_name_id_par, int student_dob_id_par, 
            int gender_id_par, int student_e_mail_id_par, int student_parent_id_par, int student_address_home_id_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_update_student", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("student_id_par", student_id_par);
                    cmd.Parameters.AddWithValue("student_first_name_id_par", student_first_name_id_par);
                    cmd.Parameters.AddWithValue("student_last_name_id_par", student_last_name_id_par);
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
