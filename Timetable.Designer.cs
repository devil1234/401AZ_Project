namespace _401AZ_PROJECT
{
    partial class Timetable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mySqlDataAdapter1 = new MySqlConnector.MySqlDataAdapter();
            this.mySqlDataAdapter2 = new MySqlConnector.MySqlDataAdapter();
            this.dgv_classes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_search_timetable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classes)).BeginInit();
            this.SuspendLayout();
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateBatchSize = 0;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // mySqlDataAdapter2
            // 
            this.mySqlDataAdapter2.DeleteCommand = null;
            this.mySqlDataAdapter2.InsertCommand = null;
            this.mySqlDataAdapter2.SelectCommand = null;
            this.mySqlDataAdapter2.UpdateBatchSize = 0;
            this.mySqlDataAdapter2.UpdateCommand = null;
            // 
            // dgv_classes
            // 
            this.dgv_classes.AllowUserToAddRows = false;
            this.dgv_classes.AllowUserToDeleteRows = false;
            this.dgv_classes.AllowUserToResizeColumns = false;
            this.dgv_classes.AllowUserToResizeRows = false;
            this.dgv_classes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_classes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_classes.Location = new System.Drawing.Point(9, 158);
            this.dgv_classes.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_classes.Name = "dgv_classes";
            this.dgv_classes.ReadOnly = true;
            this.dgv_classes.RowHeadersWidth = 51;
            this.dgv_classes.RowTemplate.Height = 24;
            this.dgv_classes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_classes.Size = new System.Drawing.Size(843, 382);
            this.dgv_classes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Classroom name search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_search_timetable
            // 
            this.btn_search_timetable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search_timetable.Enabled = false;
            this.btn_search_timetable.ForeColor = System.Drawing.Color.Black;
            this.btn_search_timetable.Location = new System.Drawing.Point(424, 72);
            this.btn_search_timetable.Name = "btn_search_timetable";
            this.btn_search_timetable.Size = new System.Drawing.Size(99, 22);
            this.btn_search_timetable.TabIndex = 3;
            this.btn_search_timetable.Text = "Search";
            this.btn_search_timetable.UseVisualStyleBackColor = false;
            this.btn_search_timetable.Click += new System.EventHandler(this.btn_search_timetable_Click);
            // 
            // Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(863, 548);
            this.Controls.Add(this.btn_search_timetable);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_classes);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Timetable";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Time table";
            this.Load += new System.EventHandler(this.Timetable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MySqlConnector.MySqlDataAdapter mySqlDataAdapter1;
        private MySqlConnector.MySqlDataAdapter mySqlDataAdapter2;
        private System.Windows.Forms.DataGridView dgv_classes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_search_timetable;
    }
}