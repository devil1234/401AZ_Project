using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    /// <summary>
    /// Class Dob.
    /// Implements the <see cref="_401AZ_PROJECT.Models.Person" />
    /// </summary>
    /// <seealso cref="_401AZ_PROJECT.Models.Person" />
    public class Dob : Person
    {
        /// <summary>
        /// Gets or sets the dob identifier.
        /// </summary>
        /// <value>The dob identifier.</value>
        public int DobId { get; set; }
        
        private readonly DataManager _c = new DataManager();

        /// <summary>
        /// Inserts the date of birth.
        /// </summary>
        /// <param name="dob_par">The dob par.</param>
        public void InsertDoB(DateTime dob_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_insert_dob", connection))
                {
                    cmd.Parameters.AddWithValue("dob_par", MySqlDbType.Time).Value = dob_par;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        /// <summary>
        /// Gets the date of birth identifier by date of birth parameter.
        /// </summary>
        /// <param name="dob_par">The dob par.</param>
        /// <returns>List&lt;Dob&gt;.</returns>
        public List<Dob> GetDoBIdByDoBDate(DateTime dob_par)
        {
            var dob = new List<Dob>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_select_dobid_by_dob", connection))
                {
                    cmd.Parameters.AddWithValue("dob_par", MySqlDbType.Time).Value = dob_par;
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dob.Add(new Dob
                            {
                                DobId = reader.GetInt32(0)
                            });
                        }
                    }
                }
                connection.Close();
                return dob;
            }
        }

        /// <summary>
        /// Updates the date of birth.
        /// </summary>
        /// <param name="dob_old_par">The dob old par.</param>
        /// <param name="dob_new_par">The dob new par.</param>
        public void UpdateDoB(DateTime dob_old_par, DateTime dob_new_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_update_dob_by_date", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("dob_old_par", MySqlDbType.Time).Value = dob_old_par;
                    cmd.Parameters.AddWithValue("dob_new_par", MySqlDbType.Time).Value = dob_new_par;
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }
}