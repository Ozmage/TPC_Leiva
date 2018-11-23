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
    public partial class MostrarPersona : Form
    {
        public MostrarPersona()
        {
            InitializeComponent();
        }
        
        

        private void dgvMostrarPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMostrarPersona_Load(object sender, EventArgs e)
        {
            ConsultPersona CP = new ConsultPersona();

            try
            {
                dgvMostrarClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMostrarClientes.DataSource = CP.listar();
                dgvMostrarClientes.Columns["EstadoCliente"].Visible = false;
                dgvMostrarClientes.Columns["EstadoPersona"].Visible = false;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
