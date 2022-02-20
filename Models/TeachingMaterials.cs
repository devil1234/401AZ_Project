using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    /// <summary>
    /// Class TeachingMaterials.
    /// </summary>
    public class TeachingMaterials
    {
        /// <summary>
        /// Gets or sets the teaching identifier.
        /// </summary>
        /// <value>The teaching identifier.</value>
        public int TeachingId { get; set; }
        /// <summary>
        /// Gets or sets the filename.
        /// </summary>
        /// <value>The filename.</value>
        public string Filename { get; set; }
        /// <summary>
        /// Gets or sets the file extension.
        /// </summary>
        /// <value>The file extension.</value>
        public string FileExtension { get; set; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the teacher identifier.
        /// </summary>
        /// <value>The teacher identifier.</value>
        public int TeacherId { get; set; }
        /// <summary>
        /// Gets or sets the content of the file.
        /// </summary>
        /// <value>The content of the file.</value>
        public byte[] FileContent { get; set; }
        /// <summary>
        /// Gets or sets the name of the teacher f.
        /// </summary>
        /// <value>The name of the teacher f.</value>
        public string TeacherFName { get; set;}
        /// <summary>
        /// Gets or sets the name of the teacher l.
        /// </summary>
        /// <value>The name of the teacher l.</value>
        public string TeacherLName { get;set;}
        
        private readonly DataManager _c = new DataManager();

        /// <summary>
        /// Gets the teaching materials.
        /// </summary>
        /// <returns>List&lt;TeachingMaterials&gt;.</returns>
        public List<TeachingMaterials> GetTeachingMaterials()
        {
            var teachingMaterials = new List<TeachingMaterials>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();

                using (var cmd = new MySqlCommand("sp_select_teaching_material", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            teachingMaterials.Add(new TeachingMaterials
                            {
                                TeachingId = reader.GetInt32(0),
                                Filename = reader.GetString(1),
                                FileExtension = reader.GetString(2),
                                Description = reader.GetString(3),
                                TeacherId = reader.GetInt32(4),
                                TeacherFName = reader.GetString(5),
                                TeacherLName = reader.GetString(6)
                            });
                        }
                    }
                }
                return teachingMaterials;
            }
        }

        /// <summary>
        /// Gets the file content by teaching identifier.
        /// </summary>
        /// <param name="teaching_id">The teaching identifier.</param>
        /// <returns>TeachingMaterials.</returns>
        public TeachingMaterials GetFileContentByTeachingId(int teaching_id)
        {
            var tmFilecontent = new TeachingMaterials();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();

                using (var cmd = new MySqlCommand("sp_select_teaching_material_with_file_content_by_teaching_id", connection))
                {

                    cmd.Parameters.AddWithValue("teaching_id_par", teaching_id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tmFilecontent.FileContent = (byte[])(reader[4]);
                        }
                    }
                }
                return tmFilecontent;
            }
        }

        /// <summary>
        /// Inserts the teaching material.
        /// </summary>
        /// <param name="file_name">Name of the file.</param>
        /// <param name="file_extension_id">The file extension identifier.</param>
        /// <param name="description">The description.</param>
        /// <param name="file_content">Content of the file.</param>
        /// <param name="teacher_id">The teacher identifier.</param>
        public void InsertTeachingMaterial(string file_name, int file_extension_id, string description, Byte[] file_content, int teacher_id)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_insert_teaching_material", connection))
                {
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("file_name_par", file_name);
                    cmd.Parameters.AddWithValue("file_extension_id_par", file_extension_id);
                    cmd.Parameters.AddWithValue("description_par", description);
                    cmd.Parameters.AddWithValue("file_content_par", MySqlDbType.VarBinary).Value = file_content;
                    cmd.Parameters.AddWithValue("teacher_id_par", teacher_id);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Deletes the teaching material.
        /// </summary>
        /// <param name="teachingId">The teaching identifier.</param>
        public void DeleteTeachingMaterial(int teachingId)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_delete_teaching_material_by_teaching_id", connection))
                {
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("teaching_id_par", teachingId);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
