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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "silantev_StudBDDataSet5.Teachers". При необходимости она может быть перемещена или удалена.
            this.teachersTableAdapter.Fill(this.silantev_StudBDDataSet5.Teachers);

        }
    }
}
