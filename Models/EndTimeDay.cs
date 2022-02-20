using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    /// <summary>
    /// Class EndTimeDay.
    /// Implements the <see cref="_401AZ_PROJECT.Models.TimeTable" />
    /// </summary>
    /// <seealso cref="_401AZ_PROJECT.Models.TimeTable" />
    public class EndTimeDay : TimeTable
    {
        /// <summary>
        /// Gets or sets the end time day identifier.
        /// </summary>
        /// <value>The end time day identifier.</value>
        public int EndTimeDayId { get; set; }
        
        private readonly DataManager _c = new DataManager();

        /// <summary>
        /// Inserts the end time day.
        /// </summary>
        /// <param name="end_time_day_par">The end time day parameter</param>
        public void InsertEndTimeDay(DateTime end_time_day_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_insert_end_time_day", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("end_time_day_par", MySqlDbType.Time).Value = end_time_day_par;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        /// <summary>
        /// Gets the end time day identifier by end time days.
        /// </summary>
        /// <param name="std">The standard.</param>
        /// <returns>List&lt;EndTimeDay&gt;.</returns>
        public List<EndTimeDay> getEndTimeDayIdByEndTimeDays(DateTime std)
        {
            var d = new List<EndTimeDay>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_select_end_time_day_by_std", connection))
                {
                    cmd.Parameters.AddWithValue("end_time_day_par", MySqlDbType.Time).Value = std;
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

        /// <summary>
        /// Updates the end time day identifier by end of time.
        /// </summary>
        /// <param name="end_time_day_old_par">The end time day old parameter</param>
        /// <param name="end_time_day_new_par">The end time day new parameter</param>
        public void UpdateEndTimeDayIdByEndofTime(DateTime end_time_day_old_par, DateTime end_time_day_new_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_update_end_time_day_by_end_time_day", connection))
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