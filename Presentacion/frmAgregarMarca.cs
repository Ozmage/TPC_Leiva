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
    public partial class frmAgregarMarca : Form
    {
        public frmAgregarMarca()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void mostrarMarca()
        {
            ConsultMarca CM = new ConsultMarca();

            try
            {
                
                dgvAgregarMarca.DataSource = CM.listar();
                dgvAgregarMarca.Columns["Estado"].Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregarMarca_Load(object sender, EventArgs e)
        {
            ConsultMarca CM = new ConsultMarca();

            try
            {
                dgvAgregarMarca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAgregarMarca.DataSource = CM.listar();
                dgvAgregarMarca.Columns["Estado"].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        

        private void btnAgregarNombreDeMarca_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            ConsultMarca cMarca = new ConsultMarca();
            Marca nuevo = new Marca();

            try
            {
                nuevo.Nombre = txtBoxAgregarNombreDeMarca.Text;
                if (txtBoxAgregarNombreDeMarca.Text.Trim() == "")
                {
                    MessageBox.Show("Obligatorio escribir nombre de Marca");
                    return;
                }

                //nuevo.Nombre = int.Parse(txtBoxAgregarNombreDeMarca.Text);
                cMarca.altaMarca(nuevo);
                mostrarMarca();
                txtBoxAgregarNombreDeMarca.Clear();
                MessageBox.Show("Marca agregada correctamente");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
