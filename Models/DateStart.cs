using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    /// <summary>
    /// Class DateStart.
    /// Implements the <see cref="_401AZ_PROJECT.Models.Enrolment" />
    /// </summary>
    /// <seealso cref="_401AZ_PROJECT.Models.Enrolment" />
    public class DateStart : Enrolment
    {
        /// <summary>
        /// Gets or sets the date start identifier.
        /// </summary>
        /// <value>The date start identifier.</value>
        public int DateStartId { get; set; }

        private readonly DataManager _c = new DataManager();

        /// <summary>
        /// Inserts the date start.
        /// </summary>
        /// <param name="date_start_par">The date start parameter</param>
        public void InsertDateStart(DateTime date_start_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_insert_date_start", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("date_start_par", MySqlDbType.Date).Value = date_start_par;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        /// <summary>
        /// Gets the start date by date.
        /// </summary>
        /// <param name="date_start_par">The date start parameter</param>
        /// <returns>List&lt;DateStart&gt;.</returns>
        public List<DateStart> GetStartDateByDate(DateTime date_start_par)
        {
            var d = new List<DateStart>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_select_date_start_by_date", connection))
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

        /// <summary>
        /// Updates the date start by date.
        /// </summary>
        /// <param name="date_start_old_par">The date start old parameter</param>
        /// <param name="date_start_new_par">The date start new parameter</param>
        public void UpdateDateStartByDate(DateTime date_start_old_par, DateTime date_start_new_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_update_date_start_by_date", connection))
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