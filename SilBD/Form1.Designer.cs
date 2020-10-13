namespace SilBD
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartBut = new System.Windows.Forms.Button();
            this.PasText = new System.Windows.Forms.TextBox();
            this.LogText = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.GroupBut = new System.Windows.Forms.Button();
            this.TeachersBut = new System.Windows.Forms.Button();
            this.SupjectBut = new System.Windows.Forms.Button();
            this.ApparBut = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartBut
            // 
            this.StartBut.Location = new System.Drawing.Point(327, 136);
            this.StartBut.Name = "StartBut";
            this.StartBut.Size = new System.Drawing.Size(187, 52);
            this.StartBut.TabIndex = 0;
            this.StartBut.Text = "Добавить";
            this.StartBut.UseVisualStyleBackColor = true;
            this.StartBut.Click += new System.EventHandler(this.StartBut_Click);
            // 
            // PasText
            // 
            this.PasText.Location = new System.Drawing.Point(327, 110);
            this.PasText.Name = "PasText";
            this.PasText.Size = new System.Drawing.Size(187, 20);
            this.PasText.TabIndex = 1;
            this.PasText.TextChanged += new System.EventHandler(this.PasText_TextChanged);
            // 
            // LogText
            // 
            this.LogText.Location = new System.Drawing.Point(72, 110);
            this.LogText.Name = "LogText";
            this.LogText.Size = new System.Drawing.Size(187, 20);
            this.LogText.TabIndex = 2;
            this.LogText.TextChanged += new System.EventHandler(this.LogText_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(265, 110);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Фамилия";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(37, 110);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(29, 13);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Группа";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ученики";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // GroupBut
            // 
            this.GroupBut.Location = new System.Drawing.Point(112, 247);
            this.GroupBut.Name = "GroupBut";
            this.GroupBut.Size = new System.Drawing.Size(94, 36);
            this.GroupBut.TabIndex = 9;
            this.GroupBut.Text = "Группы";
            this.GroupBut.UseVisualStyleBackColor = true;
            this.GroupBut.Click += new System.EventHandler(this.GroupBut_Click);
            // 
            // TeachersBut
            // 
            this.TeachersBut.Location = new System.Drawing.Point(212, 247);
            this.TeachersBut.Name = "TeachersBut";
            this.TeachersBut.Size = new System.Drawing.Size(94, 36);
            this.TeachersBut.TabIndex = 10;
            this.TeachersBut.Text = "Преподаватели";
            this.TeachersBut.UseVisualStyleBackColor = true;
            this.TeachersBut.Click += new System.EventHandler(this.TeachersBut_Click);
            // 
            // SupjectBut
            // 
            this.SupjectBut.Location = new System.Drawing.Point(312, 247);
            this.SupjectBut.Name = "SupjectBut";
            this.SupjectBut.Size = new System.Drawing.Size(94, 36);
            this.SupjectBut.TabIndex = 11;
            this.SupjectBut.Text = "Предметы";
            this.SupjectBut.UseVisualStyleBackColor = true;
            this.SupjectBut.Click += new System.EventHandler(this.SupjectBut_Click);
            // 
            // ApparBut
            // 
            this.ApparBut.Location = new System.Drawing.Point(412, 247);
            this.ApparBut.Name = "ApparBut";
            this.ApparBut.Size = new System.Drawing.Size(94, 36);
            this.ApparBut.TabIndex = 12;
            this.ApparBut.Text = "Оценки";
            this.ApparBut.UseVisualStyleBackColor = true;
            this.ApparBut.Click += new System.EventHandler(this.ApparBut_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "Журнал";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 295);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ApparBut);
            this.Controls.Add(this.SupjectBut);
            this.Controls.Add(this.TeachersBut);
            this.Controls.Add(this.GroupBut);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LogText);
            this.Controls.Add(this.PasText);
            this.Controls.Add(this.StartBut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBut;
        private System.Windows.Forms.TextBox PasText;
        private System.Windows.Forms.TextBox LogText;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button GroupBut;
        private System.Windows.Forms.Button TeachersBut;
        private System.Windows.Forms.Button SupjectBut;
        private System.Windows.Forms.Button ApparBut;
        private System.Windows.Forms.Button button2;
    }
}

