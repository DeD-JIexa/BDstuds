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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "silantev_StudBDDataSet7.Appar". При необходимости она может быть перемещена или удалена.
            this.apparTableAdapter.Fill(this.silantev_StudBDDataSet7.Appar);

        }
    }
}
