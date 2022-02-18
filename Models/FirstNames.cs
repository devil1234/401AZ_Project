using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    public class FirstNames : Person
    {
        public int FirstNameId { get; set; }

        readonly DataManager _c = new DataManager();

        public void InsertFirstName(string first_name_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_insert_first_name", connection))
                {
                    cmd.Parameters.AddWithValue("first_name_par", first_name_par);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public List<FirstNames> GetFirstNameIdByFName(string first_name_par)
        {
            List<FirstNames> fn = new List<FirstNames>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_select_first_name_by_first_name", connection))
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

        public void UpdateFName(string first_name_old_par, string first_name_new_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_update_first_name", connection))
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