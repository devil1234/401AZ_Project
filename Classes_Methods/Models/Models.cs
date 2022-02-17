using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _401AZ_PROJECT.Classes_Methods.Models
{
    class FileExtension
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
            }
        }

        public List<FileExtension> GetFileExtension(string extension)
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
                return fe;
            }
        }

    }

    public class Start_Time_day
    {
        public int start_time_id { get; set; }
        public TimeSpan start_time_day { get; set; }

        readonly DB_details c = new DB_details();
    }

    public class End_Time_day
    {
        public int end_time_id { get; set; }
        public TimeSpan end_time_day { get; set; }

        readonly DB_details c = new DB_details();
    }

    public class Classroom
    {
        public int classroom_id { get; set; }
        public string classroom { get; set; }

        readonly DB_details c = new DB_details();
    }

    public class First_Name
    {
        public int first_name_id { get; set; }
        public string first_name { get; set; }

        readonly DB_details c = new DB_details();
    }

    public class Last_Name
    {
        public int Last_name_id { get; set; }
        public string Last_name { get; set; }

        readonly DB_details c = new DB_details();
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

    public class Addresses
    {
        public int Address_Id { get; set; }
        public string Address_Street { get; set; }
        public string Address_City { get; set; }
        public string Address_Region { get; set; }
        public string Address_Postcode { get; set; }

        readonly DB_details c = new DB_details();
    }
}
