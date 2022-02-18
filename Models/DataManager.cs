using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace _401AZ_PROJECT.Models
{
    public class DataManager
    {
        private string _connDetails = "Server=localhost; User ID=root;Password=Joyride2!;Database=test2";
        public string ConnectionDetails { get { return _connDetails; } set { _connDetails = value; } }
        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in props)
            {
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new Object[props.Length];
                for (int i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
    }
    
}
