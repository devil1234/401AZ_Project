using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _401AZ_PROJECT
{
    public class classes
    {
        public int Class_Id { get; set; }
        public string Classroom { get; set; }
        public string Start_Time_Day { get; set; }
        public string End_Time_Day { get; set;}
        public string Day { get; set; }
    }
    public class DBCon
    {
        private string connection_string = "Server=localhost; User ID=root;Password=Joyride2!;Database=coursework2";

        public DataTable GetClasses()
        {
            using (var connection = new MySqlConnection(connection_string))
            {
                connection.Open();
                DataTable classesDt = new DataTable();
                List<classes> classes = new List<classes>();
                using (var command = new MySqlCommand("CALL select_classes();", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            classes.Add(new classes
                            {
                                Class_Id = reader.GetInt32(0),
                                Classroom = reader.GetString(1),
                                Start_Time_Day = reader.GetString(2),
                                End_Time_Day = reader.GetString(3),
                                Day = reader.GetString(4)
                            });
                        }
                    }
                }
                classesDt.Columns.Add("Class_Id");
                classesDt.Columns.Add("Classroom");
                classesDt.Columns.Add("Start_Time_Day");
                classesDt.Columns.Add("End_Time_Day");
                classesDt.Columns.Add("Day");

                foreach (var c in classes)
                {
                    var row = classesDt.NewRow();
                    row["Class_Id"] = c.Class_Id;
                    row["Classroom"] = c.Classroom;
                    row["Start_Time_Day"] = c.Start_Time_Day;
                    row["End_Time_Day"] = c.End_Time_Day;
                    row["Day"] = c.Day;

                    classesDt.Rows.Add(row);
                }
                return classesDt;
            }
        }

    }
}
