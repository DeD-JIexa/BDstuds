﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "silantev_StudBDDataSet6.Supject". При необходимости она может быть перемещена или удалена.
            this.supjectTableAdapter.Fill(this.silantev_StudBDDataSet6.Supject);

        }
    }
}
