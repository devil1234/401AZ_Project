using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    /// <summary>
    /// Class FileExtension.
    /// Implements the <see cref="_401AZ_PROJECT.Models.TeachingMaterials" />
    /// </summary>
    /// <seealso cref="_401AZ_PROJECT.Models.TeachingMaterials" />
    public class FileExtension : TeachingMaterials
    {
        /// <summary>
        /// Gets or sets the file extension identifier.
        /// </summary>
        /// <value>The file extension identifier.</value>
        public int FileExtensionId { get; set; }

        /// <summary>
        /// The c
        /// </summary>
        private readonly DataManager _c = new DataManager();

        /// <summary>
        /// Inserts the file extension.
        /// </summary>
        /// <param name="fe">The fe.</param>
        public void InsertFileExtension(FileExtension fe)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand())
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

        /// <summary>
        /// Gets the file extension identifier.
        /// </summary>
        /// <param name="extension">The extension.</param>
        /// <returns>List&lt;FileExtension&gt;.</returns>
        public List<FileExtension> GetFileExtensionId(string extension)
        {
            var fe = new List<FileExtension>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_select_file_extension_by_file_extension", connection))
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