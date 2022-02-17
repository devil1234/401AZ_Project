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
using _401AZ_PROJECT.Models;

namespace _401AZ_PROJECT
{
    public partial class Teaching_materials_form : Form
    {
        readonly DataManager DM = new DataManager();
        readonly TeachingMaterials tm = new TeachingMaterials();
        readonly FileExtension fe = new FileExtension();

        public Teaching_materials_form()
        {
            InitializeComponent();
        }

        private void Fd_Upload_FileOk(object sender, CancelEventArgs e)
        {
            UInt32 FileSize;
            byte[] rawData;
            FileStream fs;

            TeachingMaterials t = new TeachingMaterials();
            FileExtension FE = new FileExtension();

            Fd_Upload.Filter = "all file|*.*";
            var filepath = Fd_Upload.FileName;
            
            t.Filename = Path.GetFileNameWithoutExtension(filepath);
            FE.File_Extension = Path.GetExtension(filepath);
            t.Description = Txt_Description.Text;

            fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            FileSize = Convert.ToUInt32(fs.Length);

            rawData = new byte[FileSize];
            fs.Read(rawData, 0, (Convert.ToInt32(FileSize)));
            fs.Close();

            t.Teacher_id = Int32.Parse(Num_TeacherId.Value.ToString());

            if (DM.ToDataTable(FE.GetFileExtensionId(FE.File_Extension)).Rows.Count == 0)
            {
                FE.InsertFileExtension(FE);
            }

            var file_extension_id = DM.ToDataTable(FE.GetFileExtensionId(FE.File_Extension)).Rows[0].Field<string>("file_extension_id");
            if (Txt_Description.Text.Length < 0)
            {
                Txt_Description.Text = "No Description";
            }

            try {t.InsertTeachingMaterial(t.Filename, Convert.ToInt32(file_extension_id), t.Description, rawData, t.Teacher_id);}
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }


            Btn_Cancel.PerformClick();
            Btn_Refresh.PerformClick();

        }

        private void HideButtons()
        {
            Btn_ChooseFile.Visible = true;
            Btn_Download.Visible = false;
            Lbl_TeacherId.Visible = true;
            Num_TeacherId.Visible = true;
            Num_TeacherId.ReadOnly = false;
            Btn_Refresh.Visible = false;
            Btn_Cancel.Visible = true;
            Lbl_Description.Visible = true;
            Txt_Description.Visible = true;
            Btn_Upload.Visible = false;
        }

        private void ShowButtons()
        {
            Btn_ChooseFile.Visible = false;
            Btn_Download.Visible = true;
            Lbl_TeacherId.Visible = false;
            Num_TeacherId.Visible = false;
            Num_TeacherId.ReadOnly = true;
            Btn_Refresh.Visible = true;
            Btn_Cancel.Visible = false;
            Btn_Upload.Visible = true;
            Lbl_Description.Visible = false;
            Txt_Description.Visible = false;
        }

        private void Btn_Upload_Click(object sender, EventArgs e)
        {
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
            Dgv_TeachingMaterials.DataSource = DM.ToDataTable(tm.GetTeachingMaterials());
            Dgv_TeachingMaterials.Columns["FileContent"].Visible = false;
        }


        private void Teaching_materials_form_Load(object sender, EventArgs e)
        {
            Dgv_TeachingMaterials.DataSource = DM.ToDataTable(tm.GetTeachingMaterials());
            Dgv_TeachingMaterials.Columns["FileContent"].Visible = false;
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
                    tm.DeleteTeachingMaterial(index);
                    Btn_Refresh.PerformClick();
                }
            }

        }

        private void Btn_Download_Click(object sender, EventArgs e)
        {
            if(Dgv_TeachingMaterials.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {

                string fn_no_ext = Dgv_TeachingMaterials.SelectedCells[1].Value.ToString();
                string fe = Dgv_TeachingMaterials.SelectedCells[2].Value.ToString();
                
                sv_Download.Filter = fn_no_ext + fe + "|*" + fe;
                sv_Download.Title = "Get a file from database";
                sv_Download.FileName = fn_no_ext + fe;
                sv_Download.DefaultExt = fe;
                sv_Download.ShowDialog();
            }
        }

        private void sv_Download_FileOk(object sender, CancelEventArgs e)
        {
            int index = Int32.Parse(Dgv_TeachingMaterials.SelectedCells[0].Value.ToString());
            TeachingMaterials downloadData = tm.GetTeachingMaterialsWithFileContentByTeachingId(index);
            try 
            {   
                File.WriteAllBytes(sv_Download.FileName, downloadData.FileContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
