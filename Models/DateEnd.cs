using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    public class DateEnd : Enrolment
    {
        public int DateEndId { get; set; }

        readonly DataManager _c = new DataManager();

        public void InsertDateEnd(DateTime date_end_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
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
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
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
                                DateEndId = reader.GetInt32(0)
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
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
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
}