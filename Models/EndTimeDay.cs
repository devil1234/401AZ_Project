using System;
using System.Collections.Generic;
using System.Data;
using _401AZ_PROJECT.Classes_Methods.TimeTables;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    public class EndTimeDay : TimeTable
    {
        public int EndTimeDayId { get; set; }

        readonly DataManager _c = new DataManager();

        public void InsertEndTimeDay(DateTime end_time_day_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
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
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
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
                                EndTimeDayId = reader.GetInt32(0)
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
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
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
}