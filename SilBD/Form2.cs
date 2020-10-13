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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "silantev_StudBDDataSet3.Studs". При необходимости она может быть перемещена или удалена.
            this.studsTableAdapter.Fill(this.silantev_StudBDDataSet3.Studs);

        }

        private void DelUsers_Click(object sender, EventArgs e)
        {
            var c = dataGridView1.SelectedCells;

            int idrow;

            if (c.Count==0)
            {
                return;
            }

            idrow = c[0].RowIndex;


            var s = dataGridView1.Rows[idrow];


            var dels = (int)s.Cells[0].Value;

               BD.Silantev_StudBDEntities entities = new BD.Silantev_StudBDEntities();

               BD.Studs dt = entities.Studs.Find( dels);

                entities.Studs.Remove(dt);

                entities.SaveChanges();

                MessageBox.Show("Ученик удалён!");

        }
    }
}
