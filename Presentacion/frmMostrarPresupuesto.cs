using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class frmMostrarPresupuesto : Form
    {
        public frmMostrarPresupuesto()
        {
            InitializeComponent();
        }

        private void frmEliminarPresupuesto_Load(object sender, EventArgs e)
        {
            ConsultPresupuesto CP = new ConsultPresupuesto();
            try
            {
                dgvMostrarPresupuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMostrarPresupuestos.DataSource = CP.listar();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
