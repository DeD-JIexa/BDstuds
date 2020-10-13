namespace SilBD
{
    partial class Form6
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
            this.silantev_StudBDDataSet7 = new SilBD.Silantev_StudBDDataSet7();
            this.apparBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apparTableAdapter = new SilBD.Silantev_StudBDDataSet7TableAdapters.ApparTableAdapter();
            this.idODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silantev_StudBDDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apparBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idODataGridViewTextBoxColumn,
            this.nameODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.apparBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // silantev_StudBDDataSet7
            // 
            this.silantev_StudBDDataSet7.DataSetName = "Silantev_StudBDDataSet7";
            this.silantev_StudBDDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apparBindingSource
            // 
            this.apparBindingSource.DataMember = "Appar";
            this.apparBindingSource.DataSource = this.silantev_StudBDDataSet7;
            // 
            // apparTableAdapter
            // 
            this.apparTableAdapter.ClearBeforeFill = true;
            // 
            // idODataGridViewTextBoxColumn
            // 
            this.idODataGridViewTextBoxColumn.DataPropertyName = "IdO";
            this.idODataGridViewTextBoxColumn.HeaderText = "IdO";
            this.idODataGridViewTextBoxColumn.Name = "idODataGridViewTextBoxColumn";
            // 
            // nameODataGridViewTextBoxColumn
            // 
            this.nameODataGridViewTextBoxColumn.DataPropertyName = "NameO";
            this.nameODataGridViewTextBoxColumn.HeaderText = "NameO";
            this.nameODataGridViewTextBoxColumn.Name = "nameODataGridViewTextBoxColumn";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silantev_StudBDDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apparBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Silantev_StudBDDataSet7 silantev_StudBDDataSet7;
        private System.Windows.Forms.BindingSource apparBindingSource;
        private Silantev_StudBDDataSet7TableAdapters.ApparTableAdapter apparTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameODataGridViewTextBoxColumn;
    }
}