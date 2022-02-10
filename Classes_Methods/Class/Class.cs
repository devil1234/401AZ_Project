using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _401AZ_PROJECT
{
    public class classes
    {
        public int Class_Id { get; set; }
        public string Teacher_Name { get; set; }
        public string Classroom { get; set; }
        public string Subject { get; set; }
        public TimeSpan Start_Time_Day { get; set; }
        public TimeSpan End_Time_Day { get; set;}
        public string Day { get; set; }
    }
    public class classes_db_con
    {
        readonly DB_details c = new DB_details();
        readonly DataManager DM = new DataManager();

        //Create a new datatable with a variable classroom
        public DataTable GetClasses_by_classroom(string classroom)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                List<classes> classes = new List<classes>();
                using (MySqlCommand cmd = new MySqlCommand("select_classes_by_classroom", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("classroom_par", classroom);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            classes.Add(new classes
                            {
                                Class_Id = reader.GetInt32(0),
                                Day = reader.GetString(1),
                                Start_Time_Day = reader.GetTimeSpan(2),
                                End_Time_Day = reader.GetTimeSpan(3),
                                Classroom = reader.GetString(4),
                                Teacher_Name = reader.GetString(5),
                                Subject = reader.GetString(6)

                            });
                        }
                    }
                }
                return DM.toDataTable(classes);
            }
        }

        public DataTable GetClasses()
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                List<classes> classes = new List<classes>();
                using (MySqlCommand cmd = new MySqlCommand("select_classes", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            classes.Add(new classes
                            {
                                Class_Id = reader.GetInt32(0),
                                Day = reader.GetString(1),
                                Start_Time_Day = reader.GetTimeSpan(2),
                                End_Time_Day = reader.GetTimeSpan(3),
                                Classroom = reader.GetString(4),
                                Teacher_Name = reader.GetString(5),
                                Subject = reader.GetString(6)

                            });
                        }
                    }
                }
                return DM.toDataTable(classes);
            }
        }

        public void InsertClass(classes timetable)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "CALL insert_class(@p1,@p2,@p3,@p4,@p5,@p6)";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p1", timetable.Classroom);
                    cmd.Parameters.AddWithValue("p2", timetable.Subject);
                    cmd.Parameters.AddWithValue("p3", timetable.Teacher_Name);
                    cmd.Parameters.AddWithValue("p4", timetable.Start_Time_Day);
                    cmd.Parameters.AddWithValue("p5", timetable.End_Time_Day);
                    cmd.Parameters.AddWithValue("p6", timetable.Day);
                    cmd.ExecuteNonQuery();
                }
                
            }
        }

    }
}
