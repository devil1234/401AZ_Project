using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    /// <summary>
    /// Class Teachers.
    /// Implements the <see cref="_401AZ_PROJECT.Models.Person" />
    /// </summary>
    /// <seealso cref="_401AZ_PROJECT.Models.Person" />
    public class Teachers : Person
    {
        /// <summary>
        /// Gets or sets the teacher identifier.
        /// </summary>
        /// <value>The teacher identifier.</value>
        public int TeacherId { get; set; }
        private readonly DataManager _c = new DataManager();

        /// <summary>
        /// Gets the teachers.
        /// </summary>
        /// <returns>List&lt;Teachers&gt;.</returns>
        public List<Teachers> GetTeachers()
        {
            var teachers = new List<Teachers>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();

                using (var cmd = new MySqlCommand("sp_select_teachers", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            teachers.Add(new Teachers
                            {
                                TeacherId = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Dob = reader.GetDateTime(3),
                                Gender = reader.GetString(4),
                                EMailAddress = reader.GetString(5),
                                AddressId = reader.GetInt32(6),
                                AddressStreet = reader.GetString(7),
                                AddressCity = reader.GetString(8),
                                AddressRegion = reader.GetString(9),
                                AddressPostcode = reader.GetString(10)
                            });
                        }
                    }
                }
                return teachers;
            }
        }
        
        /// <summary>
        /// Gets the name of the teacher FirstName and Lastname.
        /// </summary>
        /// <returns>List&lt;Teachers&gt;.</returns>
        public List<Teachers> GetTeacher_FName_LName()
        {
            var teachers = new List<Teachers>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();

                using (var cmd = new MySqlCommand("sp_select_teacher_fname_lname", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            teachers.Add(new Teachers
                            {
                                TeacherId = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2)

                            });
                        }
                    }
                }
                return teachers;
            }
        }

        // GET THE LIST OF TEACHERS BY ID 
        /// <summary>
        /// Gets the teacher by identifier.
        /// </summary>
        /// <param name="teacher_id_par">The teacher identifier parameter</param>
        /// <returns>List&lt;Teachers&gt;.</returns>
        public List<Teachers> GetTeacherById(int teacher_id_par)
        {
            var tc = new List<Teachers>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();

                using (var cmd = new MySqlCommand("sp_select_teacher_by_id", connection))
                {
                    cmd.Parameters.AddWithValue("teacher_id_par", teacher_id_par);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tc.Add(new Teachers
                            {
                                TeacherId = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Dob = reader.GetDateTime(3),
                                Gender = reader.GetString(4),
                                EMailAddress = reader.GetString(5),
                                AddressId = reader.GetInt32(6),
                                AddressStreet = reader.GetString(7),
                                AddressCity = reader.GetString(8),
                                AddressRegion = reader.GetString(9),
                                AddressPostcode = reader.GetString(10)

                            });
                        }
                    }
                }
                return tc;
            }
        }

        /// <summary>
        /// Inserts the teacher.
        /// </summary>
        /// <param name="first_name_id_par">The first name identifier parameter</param>
        /// <param name="last_name_id_par">The last name identifier parameter</param>
        /// <param name="dob_id_par">The dob identifier parameter</param>
        /// <param name="gender_id_par">The gender identifier parameter</param>
        /// <param name="e_mail_id_par">The e mail identifier parameter</param>
        /// <param name="teachers_address_id_par">The teachers address identifier parameter</param>
        public async void InsertTeacher(int first_name_id_par, int last_name_id_par, int dob_id_par, int gender_id_par, int e_mail_id_par, int teachers_address_id_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                await connection.OpenAsync();
                using (var cmd = new MySqlCommand("sp_insert_teacher", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("first_name_id_par", first_name_id_par);
                    cmd.Parameters.AddWithValue("last_name_id_par", last_name_id_par);
                    cmd.Parameters.AddWithValue("dob_id_par", dob_id_par);
                    cmd.Parameters.AddWithValue("gender_id_par", gender_id_par);
                    cmd.Parameters.AddWithValue("e_mail_id_par", e_mail_id_par);
                    cmd.Parameters.AddWithValue("teachers_address_id_par", teachers_address_id_par);
                    await cmd.ExecuteNonQueryAsync();
                }

            }

        }

        /// <summary>
        /// Deletes the teacher.
        /// </summary>
        /// <param name="teacher_id_par">The teacher identifier parameter</param>
        public void DeleteTeacher(int teacher_id_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_delete_teacher_by_teacher_id", connection))
                {
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("teacher_id_par", teacher_id_par);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Updates the teacher.
        /// </summary>
        /// <param name="teacher_id_par">The teacher identifier parameter</param>
        /// <param name="first_name_id_par">The first name identifier parameter</param>
        /// <param name="last_name_id_par">The last name identifier parameter</param>
        /// <param name="dob_id_par">The dob identifier parameter</param>
        /// <param name="gender_id_par">The gender identifier parameter</param>
        /// <param name="e_mail_id_par">The e mail identifier parameter</param>
        /// <param name="teachers_address_id_par">The teachers address identifier parameter</param>
        public void UpdateTeacher(int teacher_id_par, int first_name_id_par, int last_name_id_par, int dob_id_par, int gender_id_par, int e_mail_id_par, int teachers_address_id_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_update_teacher_by_teacher_id", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("teacher_id_par", teacher_id_par);
                    cmd.Parameters.AddWithValue("first_name_id_par", first_name_id_par);
                    cmd.Parameters.AddWithValue("last_name_id_par", last_name_id_par);
                    cmd.Parameters.AddWithValue("dob_id_par", dob_id_par);
                    cmd.Parameters.AddWithValue("gender_id_par", gender_id_par);
                    cmd.Parameters.AddWithValue("e_mail_id_par", e_mail_id_par);
                    cmd.Parameters.AddWithValue("teachers_address_id_par", teachers_address_id_par);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
