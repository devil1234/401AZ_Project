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
                                AddressStreet = reader.GetString(6),
                                AddressCity = reader.GetString(7),
                                AddressRegion = reader.GetString(8),
                                AddressPostcode = reader.GetString(9)

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

        async public void InsertTeacher(string first_name_par, string last_name_par, DateTime dob_par, string e_mail_address_par, 
            string address_street_par, string address_city_par, string address_region_par, string address_postcode_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                await connection.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand("sp_insert_teachers_with_last_inserted_id_multiple_tbl", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("first_name_par", first_name_par);
                    cmd.Parameters.AddWithValue("last_name_par", last_name_par);
                    cmd.Parameters.AddWithValue("dob_par", MySqlDbType.Date).Value = dob_par;
                    cmd.Parameters.AddWithValue("e_mail_address_par", e_mail_address_par);
                    cmd.Parameters.AddWithValue("address_street_par", address_street_par);
                    cmd.Parameters.AddWithValue("address_city_par", address_city_par);
                    cmd.Parameters.AddWithValue("address_region_par", address_region_par);
                    cmd.Parameters.AddWithValue("address_postcode_par", address_postcode_par);
                    await cmd.ExecuteNonQueryAsync();
                }

            }

        }
    }
}
