using _401AZ_PROJECT.Classes.Teaching_Materials.TeachingMaterial;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _401AZ_PROJECT.Models
{
    public class Classrooms
    {
        public int classroom_id { get; set; }
        public int classroom { get; set; }

        readonly DB_details c = new DB_details();

        public void InsertClassroom(string classroom_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_insert_classroom", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("classroom_par", classroom_par);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        public List<Classrooms> GetClassroomId(string classroom_par)
        {
            List<Classrooms> classroom = new List<Classrooms>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_select_classroom_by_name", connection))
                {
                    cmd.Parameters.AddWithValue("classroom_par", classroom_par);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            classroom.Add(new Classrooms
                            {
                                classroom_id = reader.GetInt32(0)
                            });
                        }
                    }
                }
                return classroom;
            }
        }

        public void UpdateClassroom(string classroom_old_par, string classroom_new_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_update_classroom_by_name", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("classroom_old_par", classroom_old_par);
                    cmd.Parameters.AddWithValue("classroom_new_par", classroom_new_par);
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }

    public class DateEnd
    {
        public int date_end_id { get; set; }
        public DateTime date_end { get; set; }

        readonly DB_details c = new DB_details();

        public void InsertDateEnd(DateTime date_end_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_insert_date_end", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("date_end_par", MySqlDbType.Date).Value = date_end_par;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public List<DateEnd> GetEndDateByDate(DateTime date_end_par)
        {
            List<DateEnd> d = new List<DateEnd>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_select_date_end_by_date", connection))
                {
                    cmd.Parameters.AddWithValue("date_end_par", MySqlDbType.Date).Value = date_end_par;
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            d.Add(new DateEnd
                            {
                                date_end_id = reader.GetInt32(0)
                            });
                        }
                    }
                }
                connection.Close();
                return d;
            }
        }

        public void UpdateDateEndByDate(DateTime date_end_old_par, DateTime date_end_new_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_update_date_end_by_date", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("date_end_old_par", MySqlDbType.Date).Value = date_end_old_par;
                    cmd.Parameters.AddWithValue("date_end_new_par", MySqlDbType.Date).Value = date_end_new_par;
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }

    public class DateStart
    {
        public int date_start_id { get; set; }
        public DateTime date_end { get; set; }

        readonly DB_details c = new DB_details();

        public void InsertDateStart(DateTime date_start_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_insert_date_start", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("date_start_par", MySqlDbType.Date).Value = date_start_par;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public List<DateStart> GetStartDateByDate(DateTime date_start_par)
        {
            List<DateStart> d = new List<DateStart>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_select_date_start_by_date", connection))
                {
                    cmd.Parameters.AddWithValue("date_start_par", MySqlDbType.Date).Value = date_start_par;
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            d.Add(new DateStart
                            {
                                date_start_id = reader.GetInt32(0)
                            });
                        }
                    }
                }
                connection.Close();
                return d;
            }
        }

        public void UpdateDateStartByDate(DateTime date_start_old_par, DateTime date_start_new_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_update_date_start_by_date", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("date_start_old_par", MySqlDbType.Date).Value = date_start_old_par;
                    cmd.Parameters.AddWithValue("date_start_new_par", MySqlDbType.Date).Value = date_start_new_par;
                    cmd.ExecuteNonQuery();
                }

            }
        }
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

                using (MySqlCommand cmd = new MySqlCommand("sp_select_day", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
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

    public class DOB
    {
        public int dob_id { get; set; }
        public int dob { get; set; }
    }

    public class Emails
    {
        public int e_mail_id { get; set; }
        public string e_mail_address { get; set; }
    }

    public class EndTimeDay
    {
        public int end_time_day_id { get; set; }
        public DateTime end_time_day { get; set; }

        readonly DB_details c = new DB_details();

        public void InsertEndTimeDay(DateTime end_time_day_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_insert_end_time_day", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("end_time_day_par", MySqlDbType.Time).Value = end_time_day_par;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public List<EndTimeDay> GetEndTimeDayIdByStd(DateTime std)
        {
            List<EndTimeDay> d = new List<EndTimeDay>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_select_end_time_day_by_std", connection))
                {
                    cmd.Parameters.AddWithValue("end_time_day", MySqlDbType.Time).Value = std;
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            d.Add(new EndTimeDay
                            {
                                end_time_day_id = reader.GetInt32(0)
                            });
                        }
                    }
                }
                connection.Close();
                return d;
            }
        }
    }

    public class FileExtension
    {
        public int File_Extension_Id { get; set; }
        public string File_Extension { get; set; }

        readonly DB_details c = new DB_details();

        public void InsertFileExtension(FileExtension fe)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "CALL sp_insert_file_extension(@p1)";
                    //cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p1", fe.File_Extension);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public List<FileExtension> GetFileExtensionId(string extension)
        {
            List<FileExtension> fe = new List<FileExtension>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_select_file_extension_by_file_extension", connection))
                {
                    cmd.Parameters.AddWithValue("file_extension_par", extension);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            fe.Add(new FileExtension
                            {
                                File_Extension_Id = reader.GetInt32(0)
                            });
                        }
                    }
                }
                connection.Close();
                return fe;
            }
        }

    }

    public class FirstNames
    {
        public int first_name_id { get; set; }
        public string first_name { get; set; }
    }

    public class Genders
    {
        public int gender_id { get; set; }
        public string gender { get; set; }

        readonly DB_details c = new DB_details();
    }

    public class LastName
    {
        public int last_name_id { get; set; }
        public string last_name { get; set; }

        readonly DB_details c = new DB_details();
    }

    public class StartTimeDay
    {
        public int start_time_day_id { get; set; }
        public DateTime start_time { get; set; }

        readonly DB_details c = new DB_details();

        public void InsertStartTimeDay(DateTime start_time_day_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_insert_start_time_day", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("start_time_day_par", MySqlDbType.Time).Value = start_time_day_par;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public List<StartTimeDay> GetStartTimeDayIdByStd(DateTime std)
        {
            List<StartTimeDay> s = new List<StartTimeDay>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_select_start_time_day_by_std", connection))
                {
                    cmd.Parameters.AddWithValue("start_time_day", MySqlDbType.Time).Value = std;
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            s.Add(new StartTimeDay
                            {
                                start_time_day_id = reader.GetInt32(0)
                            });
                        }
                    }
                }
                connection.Close();
                return s;
            }
        }

        public void UpdateStartTimeDayIdByStd(DateTime start_time_day_old_par, DateTime start_time_day_new_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_update_start_time_day", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("start_time_day_old_par", MySqlDbType.Time).Value = start_time_day_old_par;
                    cmd.Parameters.AddWithValue("start_time_day_new_par", MySqlDbType.Time).Value = start_time_day_new_par;
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }
}
