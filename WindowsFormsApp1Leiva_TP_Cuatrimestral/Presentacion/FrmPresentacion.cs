﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPresentacion : Form
    {
        public FrmPresentacion()
        {
            InitializeComponent();
        }

        private void porMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrarMarcas marca = new frmMostrarMarcas();
            
            marca.Show();
        }
    }
}
