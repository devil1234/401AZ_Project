using MySqlConnector;
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
    public partial class Timetable_form : Form
    {

        readonly DataManager DM = new DataManager();
        readonly Time_Table_Db_Con timetable = new Time_Table_Db_Con();
        readonly Days day = new Days();


        public Timetable_form()
        {
            InitializeComponent();
        }

        //Disable or enable Search button based on input
        private void Txt_class_search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_class_search.Text))
            {
                Btn_search_timetable.Enabled = false;
            }
            else
            {
                Btn_search_timetable.Enabled = true;
            }
        }

        //Search the database by textbox entry
        private void Btn_search_timetable_Click(object sender, EventArgs e)
        {
            dgv_classes.DataSource = DM.ToDataTable(timetable.GetTimeTable_By_Classroom(Txt_class_search.Text));

        }

        //Load the database data on load
        private void Timetable_Load(object sender, EventArgs e)
        {
            dgv_classes.DataSource = DM.ToDataTable(timetable.GetTimeTable());
            Populate_Form();
        }

        private void Btn_EnableSearch_Click(object sender, EventArgs e)
        {
            if(Btn_search_timetable.Visible == false)
            {
                Txt_class_search.Enabled = true;
                Btn_search_timetable.Visible = true;
                //dgv_classes.DataSource = null;
            }
            else
            {
                Txt_class_search.Enabled = false;
                Btn_search_timetable.Visible=false;
            }


        }

        private void Txt_class_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_search_timetable.PerformClick();
                Txt_class_search.Clear();
            }    
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            dgv_classes.DataSource = DM.ToDataTable(timetable.GetTimeTable());
            Populate_Form();
        }


        //Set the values of boxes based on the selected row
        private void dgv_classes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_classes.SelectedRows.Count > 0)
            {
                Populate_Form();
            }
            else
            {
                Unpopulate_Form();
            }
        }

        private void Populate_Form()
        {
            if (dgv_classes.SelectedRows.Count > 0)
            {
                //Class Id text
                Tb_ClassId.Text = dgv_classes.SelectedCells[0].Value.ToString();

                // Day text with combobox
                cb_Day.Items.Insert(0, dgv_classes.SelectedCells[1].Value.ToString());
                cb_Day.SelectedIndex = 0;
                cb_Day.Text = dgv_classes.SelectedCells[1].Value.ToString();

                //Start Time Day
                Dtp_Start_Time.Text = dgv_classes.SelectedCells[2].Value.ToString();

                //End Time Day
                Dtp_End_Time.Text = dgv_classes.SelectedCells[3].Value.ToString();

                //Classroom name
                Txt_class_search.Text = dgv_classes.SelectedCells[4].Value.ToString();

                //Teacher First name
                Cb_T_Fname.Items.Insert(0, dgv_classes.SelectedCells[5].Value.ToString());
                Cb_T_Fname.SelectedIndex = 0;
                Cb_T_Fname.Text = dgv_classes.SelectedCells[5].Value.ToString();

                //Teacher Last name
                Cb_T_Lname.Items.Insert(0, dgv_classes.SelectedCells[6].Value.ToString());
                Cb_T_Lname.SelectedIndex = 0;
                Cb_T_Lname.Text = dgv_classes.SelectedCells[6].Value.ToString();

                //Subject
                Cb_Subject.Items.Insert(0, dgv_classes.SelectedCells[7].Value.ToString());
                Cb_Subject.SelectedIndex = 0;
                Cb_Subject.Text = dgv_classes.SelectedCells[7].Value.ToString();

            }
        }

        private void Unpopulate_Form()
        {
            //Class Id text
            Tb_ClassId.Clear();
            // Day text with combobox

            cb_Day.DataSource = null;

            //Start Time Day
            Dtp_Start_Time.Text = null;
           
            //End Time Day
            Dtp_End_Time.Text = null;

            //Classroom name
            Txt_class_search.Text = null;
            
            //Teacher First name
            Cb_T_Fname.DataSource = null;
           
            //Teacher Last name
            Cb_T_Lname.DataSource = null;

            //Subject
            Cb_Subject.DataSource = null;

        }

        private void btn_InsertNew_Click(object sender, EventArgs e)
        {
            //Unpopulate_Form();
            cb_Day.Enabled = true;
            Dtp_Start_Time.Enabled = true;
            Dtp_End_Time.Enabled = true;
            Txt_class_search.Enabled = true;
            Cb_T_Fname.Enabled = true;
            Cb_T_Lname.Enabled = true;
            Cb_Subject.Enabled = true;
            btn_InsertNew.Enabled = false;
            Btn_Delete.Enabled = false;
            Btn_Update.Enabled = false;
            Btn_SaveNew.Enabled = true;
            Btn_Refresh.Enabled = false;
            btn_EnableSearch.Enabled = false;
            Btn_Cancel.Enabled = true;
            dgv_classes.Enabled = false ;

            //cb_Day
            cb_Day.DataSource = DM.ToDataTable(day.GetDays());
            cb_Day.DisplayMember = "Day_Name";
            cb_Day.ValueMember = "Day_Id_pk";

            //Dtp_End_Time.Text = 


        }

        private void Button_Reset()
        {
            Unpopulate_Form();
            cb_Day.Enabled = false;
            Dtp_Start_Time.Enabled = false;
            Dtp_End_Time.Enabled = false;
            Txt_class_search.Enabled = false;
            Cb_T_Fname.Enabled = false;
            Cb_T_Lname.Enabled = false;
            Cb_Subject.Enabled = false;
            btn_InsertNew.Enabled = true;
            Btn_Delete.Enabled = true;
            Btn_Update.Enabled = true;
            Btn_SaveNew.Enabled = false;
            Btn_Refresh.Enabled = true;
            btn_EnableSearch.Enabled = true;
            Btn_Cancel.Enabled = false;
            dgv_classes.Enabled = true;
            Populate_Form();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Button_Reset();
        }

        private void Btn_SaveNew_Click(object sender, EventArgs e)
        {
            Button_Reset();
        }
    }
}
