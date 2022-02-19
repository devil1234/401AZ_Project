using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    /// <summary>
    /// Class Genders.
    /// Implements the <see cref="_401AZ_PROJECT.Models.Person" />
    /// </summary>
    /// <seealso cref="_401AZ_PROJECT.Models.Person" />
    public class Genders : Person
    {
        /// <summary>
        /// Gets or sets the gender identifier.
        /// </summary>
        /// <value>The gender identifier.</value>
        public int GenderId { get; set; }
        
        private readonly DataManager _c = new DataManager();

        /// <summary>
        /// Gets the genders.
        /// </summary>
        /// <returns>List&lt;Genders&gt;.</returns>
        public List<Genders> GetGenders()
        {
            var genders = new List<Genders>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();

                using (var cmd = new MySqlCommand("sp_select_genders", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            genders.Add(new Genders
                            {
                                GenderId = reader.GetInt32(0),
                                Gender = reader.GetString(1),

                            });
                        }
                    }
                }
                return genders;
            }
        }
    }
}