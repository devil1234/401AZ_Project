﻿using MySqlConnector;
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
        public string Day_Id_fk { get; set; }
        public TimeSpan Start_Time_Day_Id { get; set; }
        public TimeSpan End_Time_Day_Id { get; set; }
        public string Classroom_Id { get; set; }
        public string Teacher_FName_Id { get; set; }
        public string Teacher_LName_Id { get; set; }
        public string Subject_Id { get; set; }
    }

    public class Days
    {
        public int Day_Id_pk { get; set; }
        public string Day_Name { get; set; }

        readonly DB_details c = new DB_details();

        public List<Days> GetDays()
        {
            List<Days> day = new List<Days>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("CALL sp_select_days", connection))
                {
                    //cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            day.Add(new Days
                            {
                                Day_Id_pk = reader.GetInt32(0),
                                Day_Name = reader.GetString(1),

                            });
                        }
                    }
                }
               return day;
            }
        }
    }

    public class Time_Table_Db_Con
    {
        readonly DB_details c = new DB_details();

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
                                Day_Id_fk = reader.GetString(1),
                                Start_Time_Day_Id = reader.GetTimeSpan(2),
                                End_Time_Day_Id = reader.GetTimeSpan(3),
                                Classroom_Id = reader.GetString(4),
                                Teacher_FName_Id = reader.GetString(5),
                                Teacher_LName_Id = reader.GetString(6),
                                Subject_Id = reader.GetString(7)

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
                
                using (MySqlCommand cmd = new MySqlCommand("CALL sp_select_timetable", connection))
                {
                    //cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            classes.Add(new TimeTable
                            {
                                Class_Id = reader.GetInt32(0),
                                Day_Id_fk = reader.GetString(1),
                                Start_Time_Day_Id = reader.GetTimeSpan(2),
                                End_Time_Day_Id = reader.GetTimeSpan(3),
                                Classroom_Id = reader.GetString(4),
                                Teacher_FName_Id = reader.GetString(5),
                                Teacher_LName_Id = reader.GetString(6),
                                Subject_Id = reader.GetString(7)

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
                    cmd.Parameters.AddWithValue("p1", timetable.Classroom_Id);
                    cmd.Parameters.AddWithValue("p2", timetable.Subject_Id);
                    cmd.Parameters.AddWithValue("p3", timetable.Teacher_FName_Id);
                    cmd.Parameters.AddWithValue("p4", timetable.Teacher_LName_Id);
                    cmd.Parameters.AddWithValue("p5", timetable.Start_Time_Day_Id);
                    cmd.Parameters.AddWithValue("p6", timetable.End_Time_Day_Id);
                    cmd.Parameters.AddWithValue("p7", timetable.Day_Id_fk);
                    await cmd.ExecuteNonQueryAsync();
                    long id = cmd.LastInsertedId;
                }
                
            }
        }

    }
}
