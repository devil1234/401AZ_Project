using MySqlConnector;
using System.Collections.Generic;
using System.Data;

namespace _401AZ_PROJECT.Models
{
    /// <summary>
    /// Class Classrooms.
    /// Implements the <see cref="_401AZ_PROJECT.Models.TimeTable" />
    /// </summary>
    /// <seealso cref="_401AZ_PROJECT.Models.TimeTable" />
    public class Classrooms : TimeTable
    {
        /// <summary>
        /// Gets or sets the classroom identifier.
        /// </summary>
        /// <value>The classroom identifier.</value>
        public int ClassroomId { get; set; }
        
        private readonly DataManager _c = new DataManager();

        /// <summary>
        /// Inserts the classroom.
        /// </summary>
        /// <param name="classroom_par">The classroom par.</param>
        public void InsertClassroom(string classroom_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_insert_classroom", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("classroom_par", classroom_par);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        /// <summary>
        /// Gets the classroom identifier.
        /// </summary>
        /// <param name="classroom_par">The classroom par.</param>
        /// <returns>List&lt;Classrooms&gt;.</returns>
        public List<Classrooms> GetClassroomId(string classroom_par)
        {
            var classroom = new List<Classrooms>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_select_classroom_by_name", connection))
                {
                    cmd.Parameters.AddWithValue("classroom_par", classroom_par);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            classroom.Add(new Classrooms
                            {
                                ClassroomId = reader.GetInt32(0)
                            });
                        }
                    }
                }
                return classroom;
            }
        }

        /// <summary>
        /// Updates the classroom.
        /// </summary>
        /// <param name="classroom_old_par">The classroom old par.</param>
        /// <param name="classroom_new_par">The classroom new par.</param>
        public void UpdateClassroom(string classroom_old_par, string classroom_new_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_update_classroom_by_name", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("classroom_old_par", classroom_old_par);
                    cmd.Parameters.AddWithValue("classroom_new_par", classroom_new_par);
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }
}
