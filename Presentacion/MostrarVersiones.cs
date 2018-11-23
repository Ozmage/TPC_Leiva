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
    public partial class MostrarVersiones : Form
    {
        public MostrarVersiones()
        {
            InitializeComponent();
        }

        
        private void dgvMostrarVersion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void MostrarVersiones_Load(object sender, EventArgs e)
        {
            ConsultVersiones CV = new ConsultVersiones();

            try
            {
                dgvMostrarVersiones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMostrarVersiones.DataSource = CV.listar();
                dgvMostrarVersiones.Columns["Estado"].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
