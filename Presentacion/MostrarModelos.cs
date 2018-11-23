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
    public partial class MostrarModelos : Form
    {
        public MostrarModelos()
        {
            InitializeComponent();
        }

        private void Mostrar_Modelos_Load(object sender, EventArgs e)
        {
            
            ConsultModelo CM = new ConsultModelo();

            try
            {
                dgvMostrarModelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMostrarModelos.DataSource = CM.listar();
                dgvMostrarModelos.Columns["Estado"].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvMostrarModelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
