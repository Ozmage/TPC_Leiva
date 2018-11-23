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
using Dominio;

namespace Presentacion
{
    public partial class MostrarMarcas : Form
    {
        private List<Marca> listaMarcas;

        public MostrarMarcas()
        {
            InitializeComponent();
        }

        

        private void MostrarMarcas_Load(object sender, EventArgs e)
        {
            ConsultMarca CM = new ConsultMarca();

            try
            {
                dgvMostrarMarca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMostrarMarca.DataSource = CM.listar();
                dgvMostrarMarca.Columns["Estado"].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBoxBuscarPorId_TextChanged(object sender, EventArgs e)
        {           
                       
        }

        private void txtBoxBuscarPorNombre_TextChanged(object sender, EventArgs e)
        {
            ConsultMarca CM = new ConsultMarca();

            if (txtBoxBuscarPorNombre.Text == "")
            {
                dgvMostrarMarca.DataSource = CM.listar();
                dgvMostrarMarca.Columns["Estado"].Visible = false;
            }

            List<Marca> listaMarca;
            listaMarca = listaMarcas.FindAll(PEPE => PEPE.Nombre.Contains(txtBoxBuscarPorNombre.Text));
            dgvMostrarMarca.DataSource = CM.listar();
            dgvMostrarMarca.Columns["Estado"].Visible = false;
        }
    }
}
