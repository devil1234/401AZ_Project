using System;
using System.Collections.Generic;
using System.Data;
using _401AZ_PROJECT.Classes_Methods.TimeTables;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    public class StartTimeDay : TimeTable
    {
        public int StartTimeDayId { get; set; }

        readonly DataManager _c = new DataManager();

        public void InsertStartTimeDay(DateTime start_time_day_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
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
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
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
                                StartTimeDayId = reader.GetInt32(0)
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
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
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