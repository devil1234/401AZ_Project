using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    /// <summary>
    /// Class DateEnd.
    /// Implements the <see cref="_401AZ_PROJECT.Models.Enrolment" />
    /// </summary>
    /// <seealso cref="_401AZ_PROJECT.Models.Enrolment" />
    public class DateEnd : Enrolment
    {
        /// <summary>
        /// Gets or sets the date end identifier.
        /// </summary>
        /// <value>The date end identifier.</value>
        public int DateEndId { get; set; }

        private readonly DataManager _c = new DataManager();

        /// <summary>
        /// Inserts the date end.
        /// </summary>
        /// <param name="date_end_par">The date end par.</param>
        public void InsertDateEnd(DateTime date_end_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_insert_date_end", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("date_end_par", MySqlDbType.Date).Value = date_end_par;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        /// <summary>
        /// Gets the end date by date.
        /// </summary>
        /// <param name="date_end_par">The date end par.</param>
        /// <returns>List&lt;DateEnd&gt;.</returns>
        public List<DateEnd> GetEndDateByDate(DateTime date_end_par)
        {
            var d = new List<DateEnd>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_select_date_end_by_date", connection))
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

        /// <summary>
        /// Updates the date end by date.
        /// </summary>
        /// <param name="date_end_old_par">The date end old par.</param>
        /// <param name="date_end_new_par">The date end new par.</param>
        public void UpdateDateEndByDate(DateTime date_end_old_par, DateTime date_end_new_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_update_date_end_by_date", connection))
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