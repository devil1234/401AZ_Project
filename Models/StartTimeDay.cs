using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    /// <summary>
    /// Class StartTimeDay.
    /// Implements the <see cref="_401AZ_PROJECT.Models.TimeTable" />
    /// </summary>
    /// <seealso cref="_401AZ_PROJECT.Models.TimeTable" />
    public class StartTimeDay : TimeTable
    {
        /// <summary>
        /// Gets or sets the start time day identifier.
        /// </summary>
        /// <value>The start time day identifier.</value>
        public int StartTimeDayId { get; set; }

        private readonly DataManager _c = new DataManager();

        /// <summary>
        /// Inserts the start time day.
        /// </summary>
        /// <param name="start_time_day_par">The start time day par.</param>
        public void InsertStartTimeDay(DateTime start_time_day_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_insert_start_time_day", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("start_time_day_par", MySqlDbType.Time).Value = start_time_day_par;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        /// <summary>
        /// Gets the start time day identifier by standard.
        /// </summary>
        /// <param name="std">The standard.</param>
        /// <returns>List&lt;StartTimeDay&gt;.</returns>
        public List<StartTimeDay> GetStartTimeDayIdByStd(DateTime std)
        {
            var s = new List<StartTimeDay>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_select_start_time_day_by_std", connection))
                {
                    cmd.Parameters.AddWithValue("start_time_day_par", MySqlDbType.Time).Value = std;
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

        /// <summary>
        /// Updates the start time day identifier by standard.
        /// </summary>
        /// <param name="start_time_day_old_par">The start time day old par.</param>
        /// <param name="start_time_day_new_par">The start time day new par.</param>
        public void UpdateStartTimeDayIdByStd(DateTime start_time_day_old_par, DateTime start_time_day_new_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_update_start_time_day", connection))
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