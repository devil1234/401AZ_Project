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
    public class Teachers
    {
        public int Teacher_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public string Gender { get; set; }
        public string E_mail { get; set; }
        public string Teacher_Address_Street { get; set; }
        public string Teacher_Address_City { get; set; }
        public string Teacher_Address_Region { get; set; }
        public string Teacher_Address_Postcode { get; set; }
        public string Text { get; set; }
        public override string ToString() { return Text; }

        readonly DB_details c = new DB_details();

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
                                Date_Of_Birth = reader.GetDateTime(3),
                                Gender = reader.GetString(4),
                                E_mail = reader.GetString(5),
                                Teacher_Address_Street = reader.GetString(6),
                                Teacher_Address_City = reader.GetString(7),
                                Teacher_Address_Region = reader.GetString(8),
                                Teacher_Address_Postcode = reader.GetString(9)

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
    }
}
