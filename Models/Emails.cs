using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    /// <summary>
    /// Class Emails.
    /// Implements the <see cref="_401AZ_PROJECT.Models.Person" />
    /// </summary>
    /// <seealso cref="_401AZ_PROJECT.Models.Person" />
    public class Emails : Person
    {
        /// <summary>
        /// Gets or sets the e mail identifier.
        /// </summary>
        /// <value>The e mail identifier.</value>
        public int EMailId { get; set; }
        
        private readonly DataManager _c = new DataManager();

        /// <summary>
        /// Inserts the email.
        /// </summary>
        /// <param name="e_mail_address_par">The e mail address par.</param>
        public void InsertEmail(string e_mail_address_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_insert_e_mail_address", connection))
                {
                    cmd.Parameters.AddWithValue("e_mail_address_par", e_mail_address_par);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        /// <summary>
        /// Gets the email identifier by email.
        /// </summary>
        /// <param name="e_mail_address_par">The e mail address par.</param>
        /// <returns>List&lt;Emails&gt;.</returns>
        public List<Emails> GetEmailIdByEmail(string e_mail_address_par)
        {
            var email = new List<Emails>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_select_e_mail_address_id_by_email", connection))
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

        /// <summary>
        /// Updates the email address.
        /// </summary>
        /// <param name="e_mail_address_old_par">The e mail address old par.</param>
        /// <param name="e_mail_address_new_par">The e mail address new par.</param>
        public void UpdateEmail(string e_mail_address_old_par, string e_mail_address_new_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_update_e_mail_address_by_e_mail", connection))
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