using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _401AZ_PROJECT.Classes.Teaching_Materials;
using _401AZ_PROJECT.Classes.Teaching_Materials.TeachingMaterial;
using _401AZ_PROJECT.Classes_Methods.Teachers.Teacher;
using _401AZ_PROJECT.Models;

namespace _401AZ_PROJECT
{
    public partial class TeachingMaterialsForm : Form
    {
        readonly DataManager _dm = new DataManager();
        readonly TeachingMaterials _tm = new TeachingMaterials();
        readonly FileExtension _fe = new FileExtension();
        readonly Teachers _teacher = new Teachers();

        public TeachingMaterialsForm()
        {
            InitializeComponent();
        }

        private void Fd_Upload_FileOk(object sender, CancelEventArgs e)
        {
            UInt32 fileSize;
            byte[] rawData;
            FileStream fs;

            TeachingMaterials t = new TeachingMaterials();
            FileExtension fe = new FileExtension();

            Fd_Upload.Filter = "all file|*.*";
            var filepath = Fd_Upload.FileName;
            
            t.Filename = Path.GetFileNameWithoutExtension(filepath);
            fe.FileExtension = Path.GetExtension(filepath);
            t.Description = Txt_Description.Text;

            fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            fileSize = Convert.ToUInt32(fs.Length);

            rawData = new byte[fileSize];
            fs.Read(rawData, 0, (Convert.ToInt32(fileSize)));
            fs.Close();

            int teacherId = Int32.Parse(Cb_TeacherId.SelectedValue.ToString());

            if (_dm.ToDataTable(fe.GetFileExtensionId(fe.FileExtension)).Rows.Count == 0)
            {
                fe.InsertFileExtension(fe);
            }

            var fileExtensionId = _dm.ToDataTable(fe.GetFileExtensionId(fe.FileExtension)).Rows[0].Field<string>("file_extension_id");
            if (Txt_Description.Text.Length < 0)
            {
                Txt_Description.Text = "No Description";
            }

            try {t.InsertTeachingMaterial(t.Filename, Convert.ToInt32(fileExtensionId), t.Description, rawData, teacherId);}
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }


            Btn_Cancel.PerformClick();
            Btn_Refresh.PerformClick();

        }

        private void HideButtons()
        {
            Btn_ChooseFile.Visible = true;
            Btn_Download.Visible = false;
            Lbl_TeacherId.Visible = true;
            Cb_TeacherId.Visible = true;
            Cb_TeacherId.Enabled = true;
            Btn_Refresh.Visible = false;
            Btn_Cancel.Visible = true;
            Lbl_Description.Visible = true;
            Txt_Description.Visible = true;
            Btn_Upload.Visible = false;
            Btn_DeleteRecord.Visible = false;
            Lbl_TeacherFName.Visible = true;
            Lbl_TeacherLName.Visible = true;
            Cb_TFName.Visible = true;
            Cb_TLName.Visible = true;
        }

        private void ShowButtons()
        {
            Btn_ChooseFile.Visible = false;
            Btn_Download.Visible = true;
            Lbl_TeacherId.Visible = false;
            Cb_TeacherId.Visible = false;
            Cb_TeacherId.Enabled = false;
            Btn_Refresh.Visible = true;
            Btn_Cancel.Visible = false;
            Btn_Upload.Visible = true;
            Lbl_Description.Visible = false;
            Txt_Description.Visible = false;
            Btn_DeleteRecord.Visible = true;
            Lbl_TeacherFName.Visible= false;
            Lbl_TeacherLName.Visible = false;
            Cb_TFName.Visible = false;
            Cb_TLName.Visible = false;
        }

        private void Btn_Upload_Click(object sender, EventArgs e)
        {
            Cb_TeacherId.DataSource = _dm.ToDataTable(_teacher.GetTeacher_FName_LName());
            Cb_TeacherId.DisplayMember = "Teacher_Id";
            if (Dgv_TeachingMaterials.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {
                Cb_TeacherId.SelectedValue = Int32.Parse(Dgv_TeachingMaterials.SelectedCells[4].Value.ToString());
            }
            HideButtons();
        }

        private void Btn_ChooseFile_Click(object sender, EventArgs e)
        {
            Fd_Upload.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Fd_Upload.ShowDialog();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            ShowButtons();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            Dgv_TeachingMaterials.DataSource = _dm.ToDataTable(_tm.GetTeachingMaterials());
            Dgv_TeachingMaterials.Columns["FileContent"].Visible = false;
        }


        private void Teaching_materials_form_Load(object sender, EventArgs e)
        {
            Dgv_TeachingMaterials.DataSource = _dm.ToDataTable(_tm.GetTeachingMaterials());
            Dgv_TeachingMaterials.Columns["FileContent"].Visible = false;
            Dgv_TeachingMaterials.Columns["Teacher_id"].Visible = false;
        }

        private void Btn_DeleteRecord_Click(object sender, EventArgs e)
        {
            if (Dgv_TeachingMaterials.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {
                int index = Int32.Parse(Dgv_TeachingMaterials.SelectedCells[0].Value.ToString());
                string caption = "Are you sure you want to delete?";
                string message = "Do you want to delete the file with the record Id of" + " " + index + " ?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    _tm.DeleteTeachingMaterial(index);
                    Btn_Refresh.PerformClick();
                }
            }

        }

        private void Btn_Download_Click(object sender, EventArgs e)
        {
            if(Dgv_TeachingMaterials.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {

                string fnNoExt = Dgv_TeachingMaterials.SelectedCells[1].Value.ToString();
                string fe = Dgv_TeachingMaterials.SelectedCells[2].Value.ToString();
                
                sv_Download.Filter = fnNoExt + fe + "|*" + fe;
                sv_Download.Title = "Get a file from database";
                sv_Download.FileName = fnNoExt + fe;
                sv_Download.DefaultExt = fe;
                sv_Download.ShowDialog();
            }
        }

        private void sv_Download_FileOk(object sender, CancelEventArgs e)
        {
            int index = Int32.Parse(Dgv_TeachingMaterials.SelectedCells[0].Value.ToString());
            TeachingMaterials downloadData = _tm.GetTeachingMaterialsWithFileContentByTeachingId(index);
            try 
            {   
                File.WriteAllBytes(sv_Download.FileName, downloadData.FileContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cb_TeacherId_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cb_TFName.DataSource = Cb_TeacherId.DataSource;
            Cb_TLName.DataSource = Cb_TeacherId.DataSource;
            Cb_TFName.DisplayMember = "First_Name";
            Cb_TFName.ValueMember = "Teacher_Id";

            Cb_TLName.DisplayMember = "Last_Name";
            Cb_TLName.ValueMember = "Teacher_Id";

            Cb_TeacherId.DisplayMember = "Teacher_Id";
            Cb_TeacherId.ValueMember = "Teacher_Id";
        }
    }
}
