using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    /// <summary>
    /// Class FirstNames.
    /// Implements the <see cref="_401AZ_PROJECT.Models.Person" />
    /// </summary>
    /// <seealso cref="_401AZ_PROJECT.Models.Person" />
    public class FirstNames : Person
    {
        /// <summary>
        /// Gets or sets the first name identifier.
        /// </summary>
        /// <value>The first name identifier.</value>
        public int FirstNameId { get; set; }

        private readonly DataManager _c = new DataManager();

        /// <summary>
        /// Inserts the first name.
        /// </summary>
        /// <param name="first_name_par">The first name parameter</param>
        public void InsertFirstName(string first_name_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_insert_first_name", connection))
                {
                    cmd.Parameters.AddWithValue("first_name_par", first_name_par);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        
        /// <summary>Gets the first name by using the first_name_par.</summary>
        /// <param name="first_name_par">The first name parameter</param>
        /// <returns>List&lt;FirstNames&gt;.</returns>
        public List<FirstNames> GetFirstNameIdByFirstName(string first_name_par)
        {
            var fn = new List<FirstNames>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_select_first_name_by_first_name", connection))
                {
                    cmd.Parameters.AddWithValue("first_name_par", first_name_par);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            fn.Add(new FirstNames
                            {
                                FirstNameId = reader.GetInt32(0)
                            });
                        }
                    }
                }
                connection.Close();
                return fn;
            }
        }

        /// <summary>
        /// Updates the first name.
        /// </summary>
        /// <param name="first_name_old_par">The first name old parameter</param>
        /// <param name="first_name_new_par">The first name new parameter</param>
        public void UpdateFirstName(string first_name_old_par, string first_name_new_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_update_first_name", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("first_name_old_par", first_name_old_par);
                    cmd.Parameters.AddWithValue("first_name_new_par", first_name_new_par);
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }
}