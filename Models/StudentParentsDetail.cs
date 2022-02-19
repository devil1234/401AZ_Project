using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    /// <summary>
    /// Class StudentParentsDetail.
    /// Implements the <see cref="_401AZ_PROJECT.Models.Person" />
    /// </summary>
    /// <seealso cref="_401AZ_PROJECT.Models.Person" />
    public class StudentParentsDetail : Person
    {
        private readonly DataManager _c = new DataManager();

        //Create a new datatable with a variable classroom
        /// <summary>
        /// Gets the name of the parent details by f.
        /// </summary>
        /// <param name="parent_fname_par">The parent fname par.</param>
        /// <returns>List&lt;StudentParentsDetail&gt;.</returns>
        public List<StudentParentsDetail> GetParentDetailsByFName(string parent_fname_par)
        {
            var spd = new List<StudentParentsDetail>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_select_parent_by_first_name", connection))
                {
                    cmd.Parameters.AddWithValue("parent_fname_par", parent_fname_par);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            spd.Add(new StudentParentsDetail
                            {
                                ParentId = reader.GetInt32(0),
                                ParentFName = reader.GetString(1),
                                ParentLName = reader.GetString(2),
                                ParentPhoneNumber = reader.GetString(3)

                            });
                        }
                    }
                }
                connection.Close();
                return spd;
            }
        }

        /// <summary>
        /// Updates the parent details.
        /// </summary>
        /// <param name="parent_id_par">The parent identifier par.</param>
        /// <param name="first_name_par">The first name par.</param>
        /// <param name="last_name_par">The last name par.</param>
        /// <param name="phone_number_par">The phone number par.</param>
        public void UpdateParentDetails(int parent_id_par, string first_name_par, string last_name_par, string phone_number_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_update_student_parents_details_by_parent_id", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("parent_id_par", parent_id_par);
                    cmd.Parameters.AddWithValue("first_name_par", first_name_par);
                    cmd.Parameters.AddWithValue("last_name_par", last_name_par);
                    cmd.Parameters.AddWithValue("phone_number_par", phone_number_par);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        // INSERT TO DATABASE AND END RETURN THE LAST ID INSERTED
        /// <summary>
        /// Inserts the parents details.
        /// </summary>
        /// <param name="first_name_par">The first name par.</param>
        /// <param name="last_name_par">The last name par.</param>
        /// <param name="phone_number_par">The phone number par.</param>
        /// <returns>System.Int32.</returns>
        public int InsertParentsDetails(string first_name_par, string last_name_par, string phone_number_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_insert_student_parent_details", connection))
                {
                    cmd.Parameters.AddWithValue("first_name_par", first_name_par);
                    cmd.Parameters.AddWithValue("last_name_par", last_name_par);
                    cmd.Parameters.AddWithValue("phone_number_par", phone_number_par);
                    cmd.Parameters.Add("@parent_id_par", MySqlDbType.Int32, 11);
                    cmd.Parameters["@parent_id_par"].Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteScalar();
                    var parentId = Convert.ToInt32(cmd.Parameters["@parent_id_par"].Value.ToString());
                    return parentId;
                }
            }
        }
    }
}
