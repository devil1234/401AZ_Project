using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    public class FileExtension : TeachingMaterials
    {
        public int FileExtensionId { get; set; }

        readonly DataManager _c = new DataManager();

        public void InsertFileExtension(FileExtension fe)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "CALL sp_insert_file_extension(@p1)";
                    //cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p1", fe.FileExtension);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public List<FileExtension> GetFileExtensionId(string extension)
        {
            List<FileExtension> fe = new List<FileExtension>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_select_file_extension_by_file_extension", connection))
                {
                    cmd.Parameters.AddWithValue("file_extension_par", extension);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            fe.Add(new FileExtension
                            {
                                FileExtensionId = reader.GetInt32(0)
                            });
                        }
                    }
                }
                connection.Close();
                return fe;
            }
        }

    }
}