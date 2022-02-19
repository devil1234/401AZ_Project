using MySqlConnector;
using System.Collections.Generic;
using System.Data;

namespace _401AZ_PROJECT.Models
{
    /// <summary>
    /// Class Days.
    /// Implements the <see cref="_401AZ_PROJECT.Models.TimeTable" />
    /// </summary>
    /// <seealso cref="_401AZ_PROJECT.Models.TimeTable" />
    public class Days : TimeTable
    {
        private readonly DataManager _c = new DataManager();

        /// <summary>
        /// Gets the days.
        /// </summary>
        /// <returns>List&lt;Days&gt;.</returns>
        public List<Days> GetDays()
        {
            var day = new List<Days>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();

                using (var cmd = new MySqlCommand("sp_select_day", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            day.Add(new Days
                            {
                                DayId = reader.GetInt32(0),
                                DayName = reader.GetString(1),

                            });
                        }
                    }
                }
                return day;
            }
        }
    }
}