using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _401AZ_PROJECT
{
    public partial class Timetable : Form
    {
        classes_db_con class_db_connection = new classes_db_con();
        public Timetable()
        {
            InitializeComponent();
        }

        //Disable or enable Search button based on input
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                btn_search_timetable.Enabled = false;
            }
            else
            {
                btn_search_timetable.Enabled = true;
            }
        }

        //Search the database by textbox entry
        private void btn_search_timetable_Click(object sender, EventArgs e)
        {
            classes_db_con classes_Db_Con = new classes_db_con();
            dgv_classes.DataSource = classes_Db_Con.GetClasses_by_classroom(textBox1.Text); 
        }

        //Load the database data on load
        private void Timetable_Load(object sender, EventArgs e)
        {
            classes_db_con classes_Db_Con = new classes_db_con();
            dgv_classes.DataSource = classes_Db_Con.GetClasses();
        }
    }
}
