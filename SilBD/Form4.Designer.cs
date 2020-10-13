namespace SilBD
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.silantev_StudBDDataSet5 = new SilBD.Silantev_StudBDDataSet5();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new SilBD.Silantev_StudBDDataSet5TableAdapters.TeachersTableAdapter();
            this.idPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namePDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surNamePDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silantev_StudBDDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPDataGridViewTextBoxColumn,
            this.namePDataGridViewTextBoxColumn,
            this.surNamePDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teachersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // silantev_StudBDDataSet5
            // 
            this.silantev_StudBDDataSet5.DataSetName = "Silantev_StudBDDataSet5";
            this.silantev_StudBDDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.silantev_StudBDDataSet5;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // idPDataGridViewTextBoxColumn
            // 
            this.idPDataGridViewTextBoxColumn.DataPropertyName = "IdP";
            this.idPDataGridViewTextBoxColumn.HeaderText = "IdP";
            this.idPDataGridViewTextBoxColumn.Name = "idPDataGridViewTextBoxColumn";
            // 
            // namePDataGridViewTextBoxColumn
            // 
            this.namePDataGridViewTextBoxColumn.DataPropertyName = "NameP";
            this.namePDataGridViewTextBoxColumn.HeaderText = "NameP";
            this.namePDataGridViewTextBoxColumn.Name = "namePDataGridViewTextBoxColumn";
            // 
            // surNamePDataGridViewTextBoxColumn
            // 
            this.surNamePDataGridViewTextBoxColumn.DataPropertyName = "SurNameP";
            this.surNamePDataGridViewTextBoxColumn.HeaderText = "SurNameP";
            this.surNamePDataGridViewTextBoxColumn.Name = "surNamePDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silantev_StudBDDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Silantev_StudBDDataSet5 silantev_StudBDDataSet5;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private Silantev_StudBDDataSet5TableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surNamePDataGridViewTextBoxColumn;
    }
}