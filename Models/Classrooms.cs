using MySqlConnector;
using System.Collections.Generic;
using System.Data;

namespace _401AZ_PROJECT.Models
{
    public class Classrooms : TimeTable
    {
        public int ClassroomId { get; set; }

        readonly DataManager _c = new DataManager();

        public void InsertClassroom(string classroom_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_insert_classroom", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("classroom_par", classroom_par);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        public List<Classrooms> GetClassroomId(string classroom_par)
        {
            List<Classrooms> classroom = new List<Classrooms>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_select_classroom_by_name", connection))
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

        public void UpdateClassroom(string classroom_old_par, string classroom_new_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_update_classroom_by_name", connection))
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
