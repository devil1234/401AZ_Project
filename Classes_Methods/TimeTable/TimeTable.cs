using _401AZ_PROJECT.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _401AZ_PROJECT.Classes_Methods.TimeTable
{
    public class TimeTable
    {
        public int Class_Id { get; set; }
        public string Day { get; set; }
        public TimeSpan Start_Time_Day { get; set; }
        public TimeSpan End_Time_Day { get; set; }
        public string Classroom { get; set; }
        public string Subject { get; set; }
        public string Teacher_FName { get; set; }
        public string Teacher_LName { get; set; }
        public int TeacherId { get; set; }
        public int DayId { get; set; }

        readonly DB_details c = new DB_details();

        //Create a new datatable with a variable classroom
        public List<TimeTable> GetClasses_By_Classroom(string classroom)
        {
            List<TimeTable> classes = new List<TimeTable>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_select_time_table_by_classroom_name", connection))
                {
                    cmd.Parameters.AddWithValue("classroom_par", classroom);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            classes.Add(new TimeTable
                            {
                                Class_Id = reader.GetInt32(0),
                                Day = reader.GetString(1),
                                Start_Time_Day = reader.GetTimeSpan(2),
                                End_Time_Day = reader.GetTimeSpan(3),
                                Classroom = reader.GetString(4),
                                Teacher_FName = reader.GetString(5),
                                Teacher_LName = reader.GetString(6),
                                Subject = reader.GetString(7),
                                TeacherId = reader.GetInt32(8),
                                DayId = reader.GetInt32(9)

                            });
                        }
                    }
                }
                return classes;
            }
        }

        public List<TimeTable> GetClasses()
        {
            List<TimeTable> classes = new List<TimeTable>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("CALL sp_select_time_table", connection))
                {
                    //cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            classes.Add(new TimeTable
                            {
                                Class_Id = reader.GetInt32(0),
                                Day = reader.GetString(1),
                                Start_Time_Day = reader.GetTimeSpan(2),
                                End_Time_Day = reader.GetTimeSpan(3),
                                Classroom = reader.GetString(4),
                                Teacher_FName = reader.GetString(5),
                                Teacher_LName = reader.GetString(6),
                                Subject = reader.GetString(7),
                                TeacherId = reader.GetInt32(8),
                                DayId = reader.GetInt32(9)

                            });
                        }
                    }
                }
                return classes;
            }
        }

        async public void InsertClasses(int classroom_id_par, string subject_par, int teacher_id_par, int start_time_day_id_par, int end_time_day_id_par, int day_id_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                await connection.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand("sp_insert_classes", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("classroom_id_par", classroom_id_par);
                    cmd.Parameters.AddWithValue("subject_par", subject_par);
                    cmd.Parameters.AddWithValue("teacher_id_par", teacher_id_par);
                    cmd.Parameters.AddWithValue("start_time_day_id_par", start_time_day_id_par);
                    cmd.Parameters.AddWithValue("end_time_day_id_par", end_time_day_id_par);
                    cmd.Parameters.AddWithValue("day_id_par", day_id_par);
                    await cmd.ExecuteNonQueryAsync();
                }

            }
        }

        public void DeleteTimetable(int classId)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_delete_timetable", connection))
                {
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("class_id_par", classId);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                }
            }

        }

        public void UpdateTimeTable(int class_id_par, int classroom_id_par, string subject_par, int teacher_id_par, int start_time_day_id_par, int end_time_day_id_par, int day_id_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_update_timetable", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("class_id_par", class_id_par);
                    cmd.Parameters.AddWithValue("classroom_id_par", classroom_id_par);
                    cmd.Parameters.AddWithValue("subject_par", subject_par);
                    cmd.Parameters.AddWithValue("teacher_id_par", teacher_id_par);
                    cmd.Parameters.AddWithValue("start_time_day_id_par", start_time_day_id_par);
                    cmd.Parameters.AddWithValue("end_time_day_id_par", end_time_day_id_par);
                    cmd.Parameters.AddWithValue("day_id_par", day_id_par);
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }
}
