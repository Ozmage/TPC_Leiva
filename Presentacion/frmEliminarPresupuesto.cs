using System;
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
    public partial class frmEliminarPresupuesto : Form
    {
        public frmEliminarPresupuesto()
        {
            InitializeComponent();
        }

        private void frmEliminarPresupuesto_Load(object sender, EventArgs e)
        {
            dgvMostrarPresupuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
