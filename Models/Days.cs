using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    public class Days : TimeTable
    {
        public int DayIdPk { get; set; }

        readonly DataManager _c = new DataManager();

        public List<Days> GetDays()
        {
            List<Days> day = new List<Days>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("sp_select_day", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            day.Add(new Days
                            {
                                DayIdPk = reader.GetInt32(0),
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