namespace SilBD
{
    partial class Form5
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
            this.silantev_StudBDDataSet6 = new SilBD.Silantev_StudBDDataSet6();
            this.supjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supjectTableAdapter = new SilBD.Silantev_StudBDDataSet6TableAdapters.SupjectTableAdapter();
            this.idObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silantev_StudBDDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idObjDataGridViewTextBoxColumn,
            this.nameObjDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.supjectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // silantev_StudBDDataSet6
            // 
            this.silantev_StudBDDataSet6.DataSetName = "Silantev_StudBDDataSet6";
            this.silantev_StudBDDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supjectBindingSource
            // 
            this.supjectBindingSource.DataMember = "Supject";
            this.supjectBindingSource.DataSource = this.silantev_StudBDDataSet6;
            // 
            // supjectTableAdapter
            // 
            this.supjectTableAdapter.ClearBeforeFill = true;
            // 
            // idObjDataGridViewTextBoxColumn
            // 
            this.idObjDataGridViewTextBoxColumn.DataPropertyName = "IdObj";
            this.idObjDataGridViewTextBoxColumn.HeaderText = "IdObj";
            this.idObjDataGridViewTextBoxColumn.Name = "idObjDataGridViewTextBoxColumn";
            // 
            // nameObjDataGridViewTextBoxColumn
            // 
            this.nameObjDataGridViewTextBoxColumn.DataPropertyName = "NameObj";
            this.nameObjDataGridViewTextBoxColumn.HeaderText = "NameObj";
            this.nameObjDataGridViewTextBoxColumn.Name = "nameObjDataGridViewTextBoxColumn";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silantev_StudBDDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supjectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Silantev_StudBDDataSet6 silantev_StudBDDataSet6;
        private System.Windows.Forms.BindingSource supjectBindingSource;
        private Silantev_StudBDDataSet6TableAdapters.SupjectTableAdapter supjectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameObjDataGridViewTextBoxColumn;
    }
}