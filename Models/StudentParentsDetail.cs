using _401AZ_PROJECT.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

namespace _401AZ_PROJECT.Classes_Methods.Students.StudentParentsDetails
{
    public class StudentParentsDetail : Person
    {
        readonly DataManager _c = new DataManager();

        //Create a new datatable with a variable classroom
        public List<StudentParentsDetail> GetParentDetailsByFName(string parent_fname_par)
        {
            List<StudentParentsDetail> spd = new List<StudentParentsDetail>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_select_parent_by_first_name", connection))
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

        public void UpdateParentDetails(int parent_id_par, string first_name_par, string last_name_par, string phone_number_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_update_student_parents_details_by_parent_id", connection))
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
        public int InsertParentsDetails(string first_name_par, string last_name_par, string phone_number_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_insert_student_parent_details", connection))
                {
                    cmd.Parameters.AddWithValue("first_name_par", first_name_par);
                    cmd.Parameters.AddWithValue("last_name_par", last_name_par);
                    cmd.Parameters.AddWithValue("phone_number_par", phone_number_par);
                    cmd.Parameters.Add("@parent_id_par", MySqlDbType.Int32, 11);
                    cmd.Parameters["@parent_id_par"].Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteScalar();
                    int parentId = Convert.ToInt32(cmd.Parameters["@parent_id_par"].Value.ToString());
                    return parentId;
                }
            }
        }
    }
}
