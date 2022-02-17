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

    public class Student
    {
        public int StudentId { get; set; }
        public string Student_FName { get; set; }
        public string Student_LName { get; set; }
        public string Student_Date_Of_Birth { get; set; }
        public string Student_Gender { get; set; }
        public byte[] Student_Picture { get; set; }
        public string Student_E_Mail_Address { get; set; }
        public string Student_Parent_Full_Name { get; set; }

        readonly DB_details c = new DB_details();

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
                                Student_FName = reader.GetString(1),
                                Student_LName = reader.GetString(2)

                            });
                        }
                    }
                }
                return Students;
            }
        }

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
                                Student_FName = reader.GetString(1),
                                Student_LName = reader.GetString(2)

                            });
                        }
                    }
                }
                return Students;
            }
        }
    }
}
