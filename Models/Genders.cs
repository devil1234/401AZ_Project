using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    public class Genders : Person
    {
        public int GenderId { get; set; }

        readonly DataManager _c = new DataManager();

        public List<Genders> GetGenders()
        {
            List<Genders> genders = new List<Genders>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("sp_select_genders", connection))
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