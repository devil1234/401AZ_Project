using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace _401AZ_PROJECT.Models
{
    /// <summary>
    /// Class DataManager.
    /// </summary>
    public class DataManager
    {
        /// <summary>
        /// The MySQL connection details
        /// </summary>
        private string _connDetails = "Server=localhost; User ID=root;Password=Joyride2!;Database=test2";
        public string ConnectionDetails { get { return _connDetails; } set { _connDetails = value; } }
        /// <summary>
        /// Converts to data table.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items">The items.</param>
        /// <returns>DataTable.</returns>
        public DataTable ToDataTable<T>(List<T> items)
        {
            var dataTable = new DataTable(typeof(T).Name);
            var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var prop in props)
            {
                dataTable.Columns.Add(prop.Name);
            }
            foreach (var item in items)
            {
                var values = new Object[props.Length];
                for (var i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
    }
    
}
