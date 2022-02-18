using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    public class LastName : Person
    {
        public int LastNameId { get; set; }

        readonly DataManager _c = new DataManager();

        public void InsertLastName(string last_name_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_insert_last_name", connection))
                {
                    cmd.Parameters.AddWithValue("last_name_par", last_name_par);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public List<LastName> GetLastNameIdByLName(string last_name_par)
        {
            List<LastName> ln = new List<LastName>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_select_last_name_by_last_name", connection))
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

        public void UpdateLName(string last_name_old_par, string last_name_new_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_update_last_name", connection))
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