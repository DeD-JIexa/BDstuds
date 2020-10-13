namespace SilBD
{
    partial class Form2
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
            this.idSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userSurNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silantev_StudBDDataSet3 = new SilBD.Silantev_StudBDDataSet3();
            this.studsTableAdapter = new SilBD.Silantev_StudBDDataSet3TableAdapters.StudsTableAdapter();
            this.DelUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silantev_StudBDDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.userSurNameDataGridViewTextBoxColumn,
            this.idGrDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(70, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(678, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idSDataGridViewTextBoxColumn
            // 
            this.idSDataGridViewTextBoxColumn.DataPropertyName = "IdS";
            this.idSDataGridViewTextBoxColumn.HeaderText = "IdS";
            this.idSDataGridViewTextBoxColumn.Name = "idSDataGridViewTextBoxColumn";
            this.idSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // userSurNameDataGridViewTextBoxColumn
            // 
            this.userSurNameDataGridViewTextBoxColumn.DataPropertyName = "UserSurName";
            this.userSurNameDataGridViewTextBoxColumn.HeaderText = "UserSurName";
            this.userSurNameDataGridViewTextBoxColumn.Name = "userSurNameDataGridViewTextBoxColumn";
            // 
            // idGrDataGridViewTextBoxColumn
            // 
            this.idGrDataGridViewTextBoxColumn.DataPropertyName = "IdGr";
            this.idGrDataGridViewTextBoxColumn.HeaderText = "IdGr";
            this.idGrDataGridViewTextBoxColumn.Name = "idGrDataGridViewTextBoxColumn";
            // 
            // studsBindingSource
            // 
            this.studsBindingSource.DataMember = "Studs";
            this.studsBindingSource.DataSource = this.silantev_StudBDDataSet3;
            // 
            // silantev_StudBDDataSet3
            // 
            this.silantev_StudBDDataSet3.DataSetName = "Silantev_StudBDDataSet3";
            this.silantev_StudBDDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studsTableAdapter
            // 
            this.studsTableAdapter.ClearBeforeFill = true;
            // 
            // DelUsers
            // 
            this.DelUsers.Location = new System.Drawing.Point(70, 395);
            this.DelUsers.Name = "DelUsers";
            this.DelUsers.Size = new System.Drawing.Size(175, 37);
            this.DelUsers.TabIndex = 1;
            this.DelUsers.Text = "Del";
            this.DelUsers.UseVisualStyleBackColor = true;
            this.DelUsers.Click += new System.EventHandler(this.DelUsers_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 454);
            this.Controls.Add(this.DelUsers);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silantev_StudBDDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Silantev_StudBDDataSet3 silantev_StudBDDataSet3;
        private System.Windows.Forms.BindingSource studsBindingSource;
        private Silantev_StudBDDataSet3TableAdapters.StudsTableAdapter studsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userSurNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button DelUsers;
    }
}