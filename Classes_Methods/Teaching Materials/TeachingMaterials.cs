﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using _401AZ_PROJECT.Models;

namespace _401AZ_PROJECT.Classes.Teaching_Materials.TeachingMaterial
{
    public class TeachingMaterials
    {
        public int TeachingId { get; set; }
        public string Filename { get; set; }
        public string File_Extension { get; set; }
        public string Description { get; set; }
        public int Teacher_id { get; set; } 
        public byte[] FileContent { get; set; }
        public string Teacher_FName { get; set;}
        public string Teacher_LName { get;set;}

        readonly DataManager c = new DataManager();

        public List<TeachingMaterials> GetTeachingMaterials()
        {
            List<TeachingMaterials> teachingMaterials = new List<TeachingMaterials>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("CALL sp_select_teaching_material()", connection))
                {
                    //cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            teachingMaterials.Add(new TeachingMaterials
                            {
                                TeachingId = reader.GetInt32(0),
                                Filename = reader.GetString(1),
                                File_Extension = reader.GetString(2),
                                Description = reader.GetString(3),
                                Teacher_id = reader.GetInt32(4),
                                Teacher_FName = reader.GetString(5),
                                Teacher_LName = reader.GetString(6)
                            });
                        }
                    }
                }
                return teachingMaterials;
            }
        }

        public TeachingMaterials GetTeachingMaterialsWithFileContentByTeachingId(int teaching_id)
        {
            TeachingMaterials tm_filecontent = new TeachingMaterials();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("sp_select_teaching_material_with_file_content_by_teaching_id", connection))
                {

                    cmd.Parameters.AddWithValue("teaching_id_par", teaching_id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tm_filecontent.TeachingId = reader.GetInt32(0);
                            tm_filecontent.Filename = reader.GetString(1);
                            tm_filecontent.File_Extension = reader.GetString(2);
                            tm_filecontent.Description = reader.GetString(3);
                            tm_filecontent.FileContent = (byte[])reader.GetValue(4);
                            tm_filecontent.Teacher_id = reader.GetInt32(5);
                            tm_filecontent.Teacher_FName = reader.GetString(6);
                            tm_filecontent.Teacher_LName = reader.GetString(7);
                        }
                    }
                }
                return tm_filecontent;
            }
        }

        public void InsertTeachingMaterial(string file_name, int file_extension_id, string description, Byte[] file_content, int teacher_id)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_insert_teaching_material", connection))
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

        public void DeleteTeachingMaterial(int teachingId)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_delete_teaching_material_by_teaching_id", connection))
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
