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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "silantev_StudBDDataSet4.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.silantev_StudBDDataSet4.Groups);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            BD.Silantev_StudBDEntities entities = new BD.Silantev_StudBDEntities();

            BD.Groups groups = new BD.Groups();

            groups.GroupName = textBox1.Text;

            entities.Groups.Add(groups);

            entities.SaveChanges();

            MessageBox.Show("Группа добавлена!");
        }
    }
}
