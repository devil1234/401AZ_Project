using _401AZ_PROJECT.Classes_Methods.Students.Students;
using _401AZ_PROJECT.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _401AZ_PROJECT.Classes_Methods.TimeTables;

namespace _401AZ_PROJECT.Classes_Methods.Enrolments
{
    public class Enrolment
    {
        public int StudentId { get; set; } //0
        public int ClassId { get; set; } // 1
        public string Student_FName { get; set; } // 2
        public string Student_LName { get; set; } // 3
        public string Classroom { get; set; } // 4
        public string Subject { get; set; } // 5 
        public DateTime StartDate { get; set; } //6
        public DateTime EndDate { get; set; } //7
        public int TeacherId { get; set; } //8

        readonly DataManager c = new DataManager();

        public List<Enrolment> GetEnrolments()
        {
            List<Enrolment> e = new List<Enrolment>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("sp_select_enrolments", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            e.Add(new Enrolment
                            {
                                StudentId = reader.GetInt32(0),
                                ClassId = reader.GetInt32(1),
                                Student_FName = reader.GetString(2),
                                Student_LName = reader.GetString(3),
                                Classroom = reader.GetString(4),
                                Subject = reader.GetString(5),
                                StartDate = reader.GetDateTime(6),
                                EndDate = reader.GetDateTime(7),
                                TeacherId = reader.GetInt32(8)

                            });
                        }
                    }
                }
                return e;
            }
        }

        public List<Enrolment> GetEnrolmentsByStudentId(int studentId)
        {
            List<Enrolment> e = new List<Enrolment>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("sp_select_enrolments_by_student_id", connection))
                {
                    cmd.Parameters.AddWithValue("student_id_par", studentId);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            e.Add(new Enrolment
                            {
                                StudentId = reader.GetInt32(0),
                                ClassId = reader.GetInt32(1),
                                Student_FName = reader.GetString(2),
                                Student_LName = reader.GetString(3),
                                Classroom = reader.GetString(4),
                                Subject = reader.GetString(5),
                                StartDate = reader.GetDateTime(6),
                                EndDate = reader.GetDateTime(7),
                                TeacherId = reader.GetInt32(8)

                            });
                        }
                    }
                }
                return e;
            }
        }

        public void DeleteEnrolment(int classId)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_delete_enrolment_by_class_id", connection))
                {
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("class_id_par", classId);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                }
            }

        }

        async public void InsertEnrolment(int student_id_par, int class_id_par, int date_start_id_par, int date_end_id_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                await connection.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand("sp_insert_enrolments", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("student_id_par", student_id_par);
                    cmd.Parameters.AddWithValue("class_id_par", class_id_par);
                    cmd.Parameters.AddWithValue("date_start_id_par", date_start_id_par);
                    cmd.Parameters.AddWithValue("date_end_id_par", date_end_id_par);
                    await cmd.ExecuteNonQueryAsync();
                }

            }

        }

        public void UpdateEnrolment(int student_id_par, int class_id_par, int date_start_id_par, int date_end_id_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_update_enrolments_by_student_id", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("student_id_par", student_id_par);
                    cmd.Parameters.AddWithValue("class_id_par", class_id_par);
                    cmd.Parameters.AddWithValue("date_start_id_par", date_start_id_par);
                    cmd.Parameters.AddWithValue("date_end_id_par", date_end_id_par);
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }

}
