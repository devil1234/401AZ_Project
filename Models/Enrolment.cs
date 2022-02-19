using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    /// <summary>
    /// Class Enrolment.
    /// </summary>
    public class Enrolment
    {
        /// <summary>
        /// Gets or sets the student identifier.
        /// </summary>
        /// <value>The student identifier.</value>
        public int StudentId { get; set; } //0
        
        /// <summary>
        /// Gets or sets the class identifier.
        /// </summary>
        /// <value>The class identifier.</value>
        public int ClassId { get; set; } // 1
        
        /// <summary>
        /// Gets or sets the name of the student f.
        /// </summary>
        /// <value>The name of the student f.</value>
        public string StudentFName { get; set; } // 2
        
        /// <summary>
        /// Gets or sets the name of the student l.
        /// </summary>
        /// <value>The name of the student l.</value>
        public string StudentLName { get; set; } // 3
        
        /// <summary>
        /// Gets or sets the classroom.
        /// </summary>
        /// <value>The classroom.</value>
        public string Classroom { get; set; } // 4
        
        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>The subject.</value>
        public string Subject { get; set; } // 5 
        
        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>The start date.</value>
        public DateTime StartDate { get; set; } //6
        
        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>The end date.</value>
        public DateTime EndDate { get; set; } //7
       
        /// <summary>
        /// Gets or sets the teacher identifier.
        /// </summary>
        /// <value>The teacher identifier.</value>
        public int TeacherId { get; set; } //8
        
        private readonly DataManager _c = new DataManager();

        /// <summary>
        /// Gets the enrolments.
        /// </summary>
        /// <returns>List&lt;Enrolment&gt;.</returns>
        public List<Enrolment> GetEnrolments()
        {
            var e = new List<Enrolment>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();

                using (var cmd = new MySqlCommand("sp_select_enrolments", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            e.Add(new Enrolment
                            {
                                StudentId = reader.GetInt32(0),
                                ClassId = reader.GetInt32(1),
                                StudentFName = reader.GetString(2),
                                StudentLName = reader.GetString(3),
                                Classroom = reader.GetString(4),
                                Subject = reader.GetString(5),
                                StartDate = reader.GetDateTime(6),
                                EndDate = reader.GetDateTime(7),
                                TeacherId = reader.GetInt32(8)

                            });
                        }
                    }
                }
                return e;
            }
        }

        /// <summary>
        /// Gets the enrolments by student identifier.
        /// </summary>
        /// <param name="studentId">The student identifier.</param>
        /// <returns>List&lt;Enrolment&gt;.</returns>
        public List<Enrolment> GetEnrolmentsByStudentId(int studentId)
        {
            var e = new List<Enrolment>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();

                using (var cmd = new MySqlCommand("sp_select_enrolments_by_student_id", connection))
                {
                    cmd.Parameters.AddWithValue("student_id_par", studentId);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            e.Add(new Enrolment
                            {
                                StudentId = reader.GetInt32(0),
                                ClassId = reader.GetInt32(1),
                                StudentFName = reader.GetString(2),
                                StudentLName = reader.GetString(3),
                                Classroom = reader.GetString(4),
                                Subject = reader.GetString(5),
                                StartDate = reader.GetDateTime(6),
                                EndDate = reader.GetDateTime(7),
                                TeacherId = reader.GetInt32(8)

                            });
                        }
                    }
                }
                return e;
            }
        }

        /// <summary>
        /// Deletes the enrolment.
        /// </summary>
        /// <param name="classId">The class identifier.</param>
        public void DeleteEnrolment(int classId)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_delete_enrolment_by_class_id", connection))
                {
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("class_id_par", classId);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                }
            }

        }

        /// <summary>
        /// Inserts the enrolment.
        /// </summary>
        /// <param name="student_id_par">The student identifier par.</param>
        /// <param name="class_id_par">The class identifier par.</param>
        /// <param name="date_start_id_par">The date start identifier par.</param>
        /// <param name="date_end_id_par">The date end identifier par.</param>
        public async void InsertEnrolment(int student_id_par, int class_id_par, int date_start_id_par, int date_end_id_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                await connection.OpenAsync();
                using (var cmd = new MySqlCommand("sp_insert_enrolments", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("student_id_par", student_id_par);
                    cmd.Parameters.AddWithValue("class_id_par", class_id_par);
                    cmd.Parameters.AddWithValue("date_start_id_par", date_start_id_par);
                    cmd.Parameters.AddWithValue("date_end_id_par", date_end_id_par);
                    await cmd.ExecuteNonQueryAsync();
                }

            }

        }

        /// <summary>
        /// Updates the enrolment.
        /// </summary>
        /// <param name="student_id_par">The student identifier par.</param>
        /// <param name="class_id_par">The class identifier par.</param>
        /// <param name="date_start_id_par">The date start identifier par.</param>
        /// <param name="date_end_id_par">The date end identifier par.</param>
        public void UpdateEnrolment(int student_id_par, int class_id_par, int date_start_id_par, int date_end_id_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_update_enrolments_by_student_id", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("student_id_par", student_id_par);
                    cmd.Parameters.AddWithValue("class_id_par", class_id_par);
                    cmd.Parameters.AddWithValue("date_start_id_par", date_start_id_par);
                    cmd.Parameters.AddWithValue("date_end_id_par", date_end_id_par);
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }

}
