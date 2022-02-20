using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    /// <summary>
    /// Class LastName.
    /// Implements the <see cref="_401AZ_PROJECT.Models.Person" />
    /// </summary>
    /// <seealso cref="_401AZ_PROJECT.Models.Person" />
    public class LastName : Person
    {
        /// <summary>
        /// Gets or sets the last name identifier.
        /// </summary>
        /// <value>The last name identifier.</value>
        public int LastNameId { get; set; }

        /// <summary>
        /// The c
        /// </summary>
        private readonly DataManager _c = new DataManager();

        /// <summary>
        /// Inserts the last name.
        /// </summary>
        /// <param name="last_name_par">The last name parameter</param>
        public void InsertLastName(string last_name_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_insert_last_name", connection))
                {
                    cmd.Parameters.AddWithValue("last_name_par", last_name_par);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        /// <summary>
        /// Gets the last name of the name identifier by l.
        /// </summary>
        /// <param name="last_name_par">The last name parameter</param>
        /// <returns>List&lt;LastName&gt;.</returns>
        public List<LastName> GetLastNameIdByLName(string last_name_par)
        {
            var ln = new List<LastName>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_select_last_name_by_last_name", connection))
                {
                    cmd.Parameters.AddWithValue("last_name_par", last_name_par);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ln.Add(new LastName
                            {
                                LastNameId = reader.GetInt32(0)
                            });
                        }
                    }
                }
                connection.Close();
                return ln;
            }
        }

        /// <summary>
        /// Updates the name of the l.
        /// </summary>
        /// <param name="last_name_old_par">The last name old parameter</param>
        /// <param name="last_name_new_par">The last name new parameter</param>
        public void UpdateLName(string last_name_old_par, string last_name_new_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_update_last_name", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("last_name_old_par", last_name_old_par);
                    cmd.Parameters.AddWithValue("last_name_new_par", last_name_new_par);
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }
}