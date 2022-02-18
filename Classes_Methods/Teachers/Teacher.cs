using _401AZ_PROJECT.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _401AZ_PROJECT.Classes_Methods.Teachers.Teacher
{
    public class Teachers : Person
    {
        public int Teacher_Id { get; set; }

        readonly DataManager c = new DataManager();

        public List<Teachers> GetTeachers()
        {
            List<Teachers> teachers = new List<Teachers>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("sp_select_teachers", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            teachers.Add(new Teachers
                            {
                                Teacher_Id = reader.GetInt32(0),
                                First_Name = reader.GetString(1),
                                Last_Name = reader.GetString(2),
                                DOB = reader.GetDateTime(3),
                                Gender = reader.GetString(4),
                                EMail_Address = reader.GetString(5),
                                AddressId = reader.GetInt32(6),
                                AddressStreet = reader.GetString(7),
                                AddressCity = reader.GetString(8),
                                AddressRegion = reader.GetString(9),
                                AddressPostcode = reader.GetString(10)
                            });
                        }
                    }
                }
                return teachers;
            }
        }

        public List<Teachers> GetTeacher_FName_LName_By_Id()
        {
            List<Teachers> teachers = new List<Teachers>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("sp_select_teacher_fname_lname_by_id", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            teachers.Add(new Teachers
                            {
                                Teacher_Id = reader.GetInt32(0),
                                First_Name = reader.GetString(1),
                                Last_Name = reader.GetString(2)

                            });
                        }
                    }
                }
                return teachers;
            }
        }

        public List<Teachers> GetTeacher_FName_LName()
        {
            List<Teachers> teachers = new List<Teachers>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("sp_select_teacher_fname_lname", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            teachers.Add(new Teachers
                            {
                                Teacher_Id = reader.GetInt32(0),
                                First_Name = reader.GetString(1),
                                Last_Name = reader.GetString(2)

                            });
                        }
                    }
                }
                return teachers;
            }
        }

        // GET THE LIST OF TEACHERS BY ID 
        public List<Teachers> GetTeacherByID(int teacher_id_par)
        {
            List<Teachers> tc = new List<Teachers>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("sp_select_teacher_by_id", connection))
                {
                    cmd.Parameters.AddWithValue("teacher_id_par", teacher_id_par);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tc.Add(new Teachers
                            {
                                Teacher_Id = reader.GetInt32(0),
                                First_Name = reader.GetString(1),
                                Last_Name = reader.GetString(2),
                                DOB = reader.GetDateTime(3),
                                Gender = reader.GetString(4),
                                EMail_Address = reader.GetString(5),
                                AddressId = reader.GetInt32(6),
                                AddressStreet = reader.GetString(7),
                                AddressCity = reader.GetString(8),
                                AddressRegion = reader.GetString(9),
                                AddressPostcode = reader.GetString(10)

                            });
                        }
                    }
                }
                return tc;
            }
        }

        async public void InsertTeacher(int first_name_id_par, int last_name_id_par, int dob_id_par, int gender_id_par, int e_mail_id_par, int teachers_address_id_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                await connection.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand("sp_insert_teacher", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("first_name_id_par", first_name_id_par);
                    cmd.Parameters.AddWithValue("last_name_id_par", last_name_id_par);
                    cmd.Parameters.AddWithValue("dob_id_par", dob_id_par);
                    cmd.Parameters.AddWithValue("gender_id_par", gender_id_par);
                    cmd.Parameters.AddWithValue("e_mail_id_par", e_mail_id_par);
                    cmd.Parameters.AddWithValue("teachers_address_id_par", teachers_address_id_par);
                    await cmd.ExecuteNonQueryAsync();
                }

            }

        }

        public void DeleteTeacher(int teacher_id_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_delete_teacher_by_teacher_id", connection))
                {
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("teacher_id_par", teacher_id_par);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTeacher(int teacher_id_par, int first_name_id_par, int last_name_id_par, int dob_id_par,int gender_id_par, int e_mail_id_par, int teachers_address_id_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_update_teacher_by_teacher_id", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("teacher_id_par", teacher_id_par);
                    cmd.Parameters.AddWithValue("first_name_id_par", first_name_id_par);
                    cmd.Parameters.AddWithValue("last_name_id_par", last_name_id_par);
                    cmd.Parameters.AddWithValue("dob_id_par", dob_id_par);
                    cmd.Parameters.AddWithValue("gender_id_par", gender_id_par);
                    cmd.Parameters.AddWithValue("e_mail_id_par", e_mail_id_par);
                    cmd.Parameters.AddWithValue("teachers_address_id_par", teachers_address_id_par);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
