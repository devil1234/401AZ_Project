using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    /// <summary>
    /// Class TimeTable.
    /// </summary>
    public class TimeTable 
    {
        /// <summary>
        /// Gets or sets the class identifier.
        /// </summary>
        /// <value>The class identifier.</value>
        public int ClassId { get; set; }
        /// <summary>
        /// Gets or sets the name of the day.
        /// </summary>
        /// <value>The name of the day.</value>
        public string DayName { get; set; }
        /// <summary>
        /// Gets or sets the start time day.
        /// </summary>
        /// <value>The start time day.</value>
        public TimeSpan StartTimeDay { get; set; }
        /// <summary>
        /// Gets or sets the end time day.
        /// </summary>
        /// <value>The end time day.</value>
        public TimeSpan EndTimeDay { get; set; }
        /// <summary>
        /// Gets or sets the classroom.
        /// </summary>
        /// <value>The classroom.</value>
        public string Classroom { get; set; }
        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>The subject.</value>
        public string Subject { get; set; }
        /// <summary>
        /// Gets or sets the name of the teacher f.
        /// </summary>
        /// <value>The name of the teacher f.</value>
        public string TeacherFName { get; set; }
        /// <summary>
        /// Gets or sets the name of the teacher l.
        /// </summary>
        /// <value>The name of the teacher l.</value>
        public string TeacherLName { get; set; }
        /// <summary>
        /// Gets or sets the teacher identifier.
        /// </summary>
        /// <value>The teacher identifier.</value>
        public int TeacherId { get; set; }
        /// <summary>
        /// Gets or sets the day identifier.
        /// </summary>
        /// <value>The day identifier.</value>
        public int DayId { get; set; }

        private readonly DataManager _c = new DataManager();

        /// <summary>
        /// Gets the time table by classroom name.
        /// </summary>
        /// <param name="classroom">The classroom.</param>
        /// <returns>List&lt;TimeTable&gt;.</returns>
        public List<TimeTable> GetTimeTableByClassroomName(string classroom)
        {
            var classes = new List<TimeTable>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_select_time_table_by_classroom_name", connection))
                {
                    cmd.Parameters.AddWithValue("classroom_par", classroom);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            classes.Add(new TimeTable
                            {
                                ClassId = reader.GetInt32(0),
                                DayName = reader.GetString(1),
                                StartTimeDay = reader.GetTimeSpan(2),
                                EndTimeDay = reader.GetTimeSpan(3),
                                Classroom = reader.GetString(4),
                                TeacherFName = reader.GetString(5),
                                TeacherLName = reader.GetString(6),
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

        /// <summary>
        /// Gets the classes.
        /// </summary>
        /// <returns>List&lt;TimeTable&gt;.</returns>
        public List<TimeTable> GetTimeTable()
        {
            var classes = new List<TimeTable>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();

                using (var cmd = new MySqlCommand("sp_select_time_table", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            classes.Add(new TimeTable
                            {
                                ClassId = reader.GetInt32(0),
                                DayName = reader.GetString(1),
                                StartTimeDay = reader.GetTimeSpan(2),
                                EndTimeDay = reader.GetTimeSpan(3),
                                Classroom = reader.GetString(4),
                                TeacherFName = reader.GetString(5),
                                TeacherLName = reader.GetString(6),
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

        /// <summary>
        /// Inserts the timetable.
        /// </summary>
        /// <param name="classroom_id_par">The classroom identifier parameter</param>
        /// <param name="subject_par">The subject parameter</param>
        /// <param name="teacher_id_par">The teacher identifier parameter</param>
        /// <param name="start_time_day_id_par">The start time day identifier parameter</param>
        /// <param name="end_time_day_id_par">The end time day identifier parameter</param>
        /// <param name="day_id_par">The day identifier parameter</param>
        public async void InsertTimetable(int classroom_id_par, string subject_par, int teacher_id_par, int start_time_day_id_par, int end_time_day_id_par, int day_id_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                await connection.OpenAsync();
                using (var cmd = new MySqlCommand("sp_insert_classes", connection))
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

        /// <summary>
        /// Deletes the timetable.
        /// </summary>
        /// <param name="classId">The class identifier.</param>
        public void DeleteTimetable(int classId)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_delete_timetable", connection))
                {
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("class_id_par", classId);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                }
            }

        }

        /// <summary>
        /// Updates the time table.
        /// </summary>
        /// <param name="class_id_par">The class identifier parameter</param>
        /// <param name="classroom_id_par">The classroom identifier parameter</param>
        /// <param name="subject_par">The subject parameter</param>
        /// <param name="teacher_id_par">The teacher identifier parameter</param>
        /// <param name="start_time_day_id_par">The start time day identifier parameter</param>
        /// <param name="end_time_day_id_par">The end time day identifier parameter</param>
        /// <param name="day_id_par">The day identifier parameter</param>
        public void UpdateTimeTable(int class_id_par, int classroom_id_par, string subject_par, int teacher_id_par, int start_time_day_id_par, int end_time_day_id_par, int day_id_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_update_timetable", connection))
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
