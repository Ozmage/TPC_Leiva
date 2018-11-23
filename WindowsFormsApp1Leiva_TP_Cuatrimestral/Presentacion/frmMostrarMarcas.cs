using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class frmMostrarMarcas : Form
    {
        public frmMostrarMarcas()
        {
            InitializeComponent();
        }

        private void Mostrar_Marcas_Load(object sender, EventArgs e)
        {
            MarcaNegocio MN = new MarcaNegocio();
            
            
            try
            {
                dgvMostrarMarcas.DataSource = MN.listar();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvMostrarMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMostrarMarcas_Load(object sender, EventArgs e)
        {
            
        }
    }
}
