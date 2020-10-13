namespace SilBD
{
    partial class Form7
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
            this.silantev_StudBDDataSet8 = new SilBD.Silantev_StudBDDataSet8();
            this.dnevnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dnevnikTableAdapter = new SilBD.Silantev_StudBDDataSet8TableAdapters.DnevnikTableAdapter();
            this.idDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silantev_StudBDDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnevnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDDataGridViewTextBoxColumn,
            this.idSDataGridViewTextBoxColumn,
            this.idObjDataGridViewTextBoxColumn,
            this.idPDataGridViewTextBoxColumn,
            this.idODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dnevnikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // silantev_StudBDDataSet8
            // 
            this.silantev_StudBDDataSet8.DataSetName = "Silantev_StudBDDataSet8";
            this.silantev_StudBDDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dnevnikBindingSource
            // 
            this.dnevnikBindingSource.DataMember = "Dnevnik";
            this.dnevnikBindingSource.DataSource = this.silantev_StudBDDataSet8;
            // 
            // dnevnikTableAdapter
            // 
            this.dnevnikTableAdapter.ClearBeforeFill = true;
            // 
            // idDDataGridViewTextBoxColumn
            // 
            this.idDDataGridViewTextBoxColumn.DataPropertyName = "idD";
            this.idDDataGridViewTextBoxColumn.HeaderText = "idD";
            this.idDDataGridViewTextBoxColumn.Name = "idDDataGridViewTextBoxColumn";
            this.idDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSDataGridViewTextBoxColumn
            // 
            this.idSDataGridViewTextBoxColumn.DataPropertyName = "IdS";
            this.idSDataGridViewTextBoxColumn.HeaderText = "IdS";
            this.idSDataGridViewTextBoxColumn.Name = "idSDataGridViewTextBoxColumn";
            // 
            // idObjDataGridViewTextBoxColumn
            // 
            this.idObjDataGridViewTextBoxColumn.DataPropertyName = "IdObj";
            this.idObjDataGridViewTextBoxColumn.HeaderText = "IdObj";
            this.idObjDataGridViewTextBoxColumn.Name = "idObjDataGridViewTextBoxColumn";
            // 
            // idPDataGridViewTextBoxColumn
            // 
            this.idPDataGridViewTextBoxColumn.DataPropertyName = "IdP";
            this.idPDataGridViewTextBoxColumn.HeaderText = "IdP";
            this.idPDataGridViewTextBoxColumn.Name = "idPDataGridViewTextBoxColumn";
            // 
            // idODataGridViewTextBoxColumn
            // 
            this.idODataGridViewTextBoxColumn.DataPropertyName = "IdO";
            this.idODataGridViewTextBoxColumn.HeaderText = "IdO";
            this.idODataGridViewTextBoxColumn.Name = "idODataGridViewTextBoxColumn";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silantev_StudBDDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnevnikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Silantev_StudBDDataSet8 silantev_StudBDDataSet8;
        private System.Windows.Forms.BindingSource dnevnikBindingSource;
        private Silantev_StudBDDataSet8TableAdapters.DnevnikTableAdapter dnevnikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idODataGridViewTextBoxColumn;
    }
}