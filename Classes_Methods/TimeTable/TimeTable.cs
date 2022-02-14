using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _401AZ_PROJECT
{
    public class TimeTable
    {
        public int Class_Id { get; set; }
        public string Teacher_FName { get; set; }
        public string Teacher_LName { get; set; }
        public string Classroom { get; set; }
        public string Subject { get; set; }
        public TimeSpan Start_Time_Day { get; set; }
        public TimeSpan End_Time_Day { get; set;}
        public string Day { get; set; }
    }
    public class time_table_db_con
    {
        readonly DB_details c = new DB_details();
        readonly DataManager DM = new DataManager();

        //Create a new datatable with a variable classroom
        public List<TimeTable> GetTimeTable_By_Classroom(string classroom)
        {
            List<TimeTable> classes = new List<TimeTable>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_select_timetable_by_classroom", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
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
                                Subject = reader.GetString(7)

                            });
                        }
                    }
                }
                return classes;
            }
        }

        public List<TimeTable> GetTimeTable()
        {
            List<TimeTable> classes = new List<TimeTable>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                
                using (MySqlCommand cmd = new MySqlCommand("sp_select_timetable", connection))
                {
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
                                Subject = reader.GetString(7)

                            });
                        }
                    }
                }
                return classes;
            }
        }

        async public void InsertTimeTable(TimeTable timetable)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                await connection.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "insert_timetable(@p1,@p2,@p3,@p4,@p5,@p6,@p7)";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p1", timetable.Classroom);
                    cmd.Parameters.AddWithValue("p2", timetable.Subject);
                    cmd.Parameters.AddWithValue("p3", timetable.Teacher_FName);
                    cmd.Parameters.AddWithValue("p4", timetable.Teacher_LName);
                    cmd.Parameters.AddWithValue("p5", timetable.Start_Time_Day);
                    cmd.Parameters.AddWithValue("p6", timetable.End_Time_Day);
                    cmd.Parameters.AddWithValue("p7", timetable.Day);
                    await cmd.ExecuteNonQueryAsync();
                    long id = cmd.LastInsertedId;
                }
                
            }
        }

    }
}
