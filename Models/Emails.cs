using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    public class Emails : Person
    {
        public int EMailId { get; set; }

        readonly DataManager _c = new DataManager();

        public void InsertEmail(string e_mail_address_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_insert_e_mail_address", connection))
                {
                    cmd.Parameters.AddWithValue("e_mail_address_par", e_mail_address_par);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public List<Emails> GetEmailIdByEmail(string e_mail_address_par)
        {
            List<Emails> email = new List<Emails>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_select_e_mail_address_id_by_email", connection))
                {
                    cmd.Parameters.AddWithValue("e_mail_address_par", e_mail_address_par);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            email.Add(new Emails
                            {
                                EMailId = reader.GetInt32(0)
                            });
                        }
                    }
                }
                connection.Close();
                return email;
            }
        }

        public void UpdateEmail(string e_mail_address_old_par, string e_mail_address_new_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_update_e_mail_address_by_e_mail", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("e_mail_address_old_par", e_mail_address_old_par);
                    cmd.Parameters.AddWithValue("e_mail_address_new_par", e_mail_address_new_par);
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }
}