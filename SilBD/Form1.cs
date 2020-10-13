using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BD.Silantev_StudBDEntities entities = new BD.Silantev_StudBDEntities();

            comboBox1.DataSource = entities.Groups.ToList();
        }

        private void StartBut_Click(object sender, EventArgs e)
        {
            #region Test
            BD.Silantev_StudBDEntities entities = new BD.Silantev_StudBDEntities();
            //var s = entities.Studs.ToList();
            //MessageBox.Show(s[16].UserName);
            #endregion

            BD.Studs studs = new BD.Studs();

            studs.UserName = LogText.Text;

            studs.UserSurName = PasText.Text;

            var GR = comboBox1.SelectedItem as BD.Groups;


            studs.IdGr = GR.IdGr;

            entities.Studs.Add(studs);

            entities.SaveChanges();

            MessageBox.Show("Ученик добавлен!");

        }
        #region Text
        private void LogText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasText_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        #region Forms
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();

            form.Show();
        }

        private void GroupBut_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();

            form.Show();
        }

        private void TeachersBut_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();

            form.Show();
        }

        private void SupjectBut_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();

            form.Show();
        }

        private void ApparBut_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();

            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();

            form.Show();
        }
        #endregion
    }
}
