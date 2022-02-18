using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    public class Dob : Person
    {
        public int DobId { get; set; }

        readonly DataManager _c = new DataManager();

        public void InsertDoB(DateTime dob_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_insert_dob", connection))
                {
                    cmd.Parameters.AddWithValue("dob_par", MySqlDbType.Time).Value = dob_par;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public List<Dob> GetDoBIdByDoBDate(DateTime dob_par)
        {
            List<Dob> dob = new List<Dob>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_select_dobid_by_dob", connection))
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

        public void UpdateDoB(DateTime dob_old_par, DateTime dob_new_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_update_dob_by_date", connection))
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