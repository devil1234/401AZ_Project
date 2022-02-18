using System;
using System.Collections.Generic;
using System.Data;
using _401AZ_PROJECT.Classes_Methods.Enrolments;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    public class DateStart : Enrolment
    {
        public int DateStartId { get; set; }

        readonly DataManager _c = new DataManager();

        public void InsertDateStart(DateTime date_start_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
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
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
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
                                DateStartId = reader.GetInt32(0)
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
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
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
}