using _401AZ_PROJECT.Classes.Teaching_Materials.TeachingMaterial;
using _401AZ_PROJECT.Classes_Methods.Enrolments;
using _401AZ_PROJECT.Classes_Methods.TimeTables;
using _401AZ_PROJECT.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _401AZ_PROJECT.Models
{
    public class Classrooms : TimeTable
    {
        public int classroom_id { get; set; }

        readonly DataManager c = new DataManager();

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

    public class Person 
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string EMail_Address { get; set; }
        public string AddressCity { get; set; }
        public int AddressId { get; set; }

        public string AddressPostcode { get; set; }

        public string AddressRegion { get; set; }

        public string AddressStreet { get; set; }

        public int ParentId { get; set; }

        public string ParentFName { get; set; }

        public string ParentLName { get; set; }

        public string ParentPhoneNumber { get; set; }

    }

    public class DateEnd : Enrolment
    {
        public int date_end_id { get; set; }

        readonly DataManager c = new DataManager();

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

    public class DateStart : Enrolment
    {
        public int date_start_id { get; set; }

        readonly DataManager c = new DataManager();

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

    public class Days : TimeTable
    {
        public int Day_Id_pk { get; set; }

        readonly DataManager c = new DataManager();

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

    public class DOB : Person
    {
        public int dob_id { get; set; }

        readonly DataManager c = new DataManager();

        public void InsertDoB(DateTime dob_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_insert_dob", connection))
                {
                    cmd.Parameters.AddWithValue("dob_par", MySqlDbType.Time).Value = dob_par;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public List<DOB> GetDoBIdByDoBDate(DateTime dob_par)
        {
            List<DOB> dob = new List<DOB>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_select_dobid_by_dob", connection))
                {
                    cmd.Parameters.AddWithValue("dob_par", MySqlDbType.Time).Value = dob_par;
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dob.Add(new DOB
                            {
                                dob_id = reader.GetInt32(0)
                            });
                        }
                    }
                }
                connection.Close();
                return dob;
            }
        }

        public void UpdateDoB(DateTime dob_old_par, DateTime dob_new_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_update_dob_by_date", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("dob_old_par", MySqlDbType.Time).Value = dob_old_par;
                    cmd.Parameters.AddWithValue("dob_new_par", MySqlDbType.Time).Value = dob_new_par;
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }

    public class Emails : Person
    {
        public int e_mail_id { get; set; }

        readonly DataManager c = new DataManager();

        public void InsertEmail(string e_mail_address_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_insert_e_mail_address", connection))
                {
                    cmd.Parameters.AddWithValue("e_mail_address_par", e_mail_address_par);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public List<Emails> GetEmailIdByEmail(string e_mail_address_par)
        {
            List<Emails> email = new List<Emails>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_select_e_mail_address_id_by_email", connection))
                {
                    cmd.Parameters.AddWithValue("e_mail_address_par", e_mail_address_par);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            email.Add(new Emails
                            {
                                e_mail_id = reader.GetInt32(0)
                            });
                        }
                    }
                }
                connection.Close();
                return email;
            }
        }

        public void UpdateEmail(string e_mail_address_old_par, string e_mail_address_new_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_update_e_mail_address_by_e_mail", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("e_mail_address_old_par", e_mail_address_old_par);
                    cmd.Parameters.AddWithValue("e_mail_address_new_par", e_mail_address_new_par);
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }

    public class EndTimeDay : TimeTable
    {
        public int end_time_day_id { get; set; }

        readonly DataManager c = new DataManager();

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

        public void UpdateEndTimeDayIdByEtd(DateTime end_time_day_old_par, DateTime end_time_day_new_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_update_end_time_day_by_end_time_day", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("end_time_day_old_par", MySqlDbType.Time).Value = end_time_day_old_par;
                    cmd.Parameters.AddWithValue("end_time_day_new_par", MySqlDbType.Time).Value = end_time_day_new_par;
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }

    public class FileExtension : TeachingMaterials
    {
        public int File_Extension_Id { get; set; }

        readonly DataManager c = new DataManager();

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

    public class FirstNames : Person
    {
        public int first_name_id { get; set; }

        readonly DataManager c = new DataManager();

        public void InsertFirstName(string first_name_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_insert_first_name", connection))
                {
                    cmd.Parameters.AddWithValue("first_name_par", first_name_par);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public List<FirstNames> GetFirstNameIdByFName(string first_name_par)
        {
            List<FirstNames> fn = new List<FirstNames>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_select_first_name_by_first_name", connection))
                {
                    cmd.Parameters.AddWithValue("first_name_par", first_name_par);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            fn.Add(new FirstNames
                            {
                                first_name_id = reader.GetInt32(0)
                            });
                        }
                    }
                }
                connection.Close();
                return fn;
            }
        }

        public void UpdateFName(string first_name_old_par, string first_name_new_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_update_first_name", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("first_name_old_par", first_name_old_par);
                    cmd.Parameters.AddWithValue("first_name_new_par", first_name_new_par);
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }

    public class Genders : Person
    {
        public int gender_id { get; set; }

        readonly DataManager c = new DataManager();

        public List<Genders> GetGenders()
        {
            List<Genders> genders = new List<Genders>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("sp_select_genders", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            genders.Add(new Genders
                            {
                                gender_id = reader.GetInt32(0),
                                Gender = reader.GetString(1),

                            });
                        }
                    }
                }
                return genders;
            }
        }
    }

    public class LastName : Person
    {
        public int last_name_id { get; set; }

        readonly DataManager c = new DataManager();

        public void InsertLastName(string last_name_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_insert_last_name", connection))
                {
                    cmd.Parameters.AddWithValue("last_name_par", last_name_par);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public List<LastName> GetLastNameIdByLName(string last_name_par)
        {
            List<LastName> ln = new List<LastName>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_select_last_name_by_last_name", connection))
                {
                    cmd.Parameters.AddWithValue("last_name_par", last_name_par);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ln.Add(new LastName
                            {
                                last_name_id = reader.GetInt32(0)
                            });
                        }
                    }
                }
                connection.Close();
                return ln;
            }
        }

        public void UpdateLName(string last_name_old_par, string last_name_new_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_update_last_name", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("last_name_old_par", last_name_old_par);
                    cmd.Parameters.AddWithValue("last_name_new_par", last_name_new_par);
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }

    public class StartTimeDay : TimeTable
    {
        public int start_time_day_id { get; set; }

        readonly DataManager c = new DataManager();

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
