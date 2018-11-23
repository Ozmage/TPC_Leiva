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
    public partial class frmAgregarModelo : Form
    {
        public frmAgregarModelo()
        {
            InitializeComponent();
        }

        public void mostrarModelo()
        {
            ConsultModelo CM = new ConsultModelo();

            try
            {
                dgvAgregarModelos.DataSource = CM.listar();
                dgvAgregarModelos.Columns["Estado"].Visible = false;
                //dgvAgregarModelos.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void frmAgregarModelo_Load(object sender, EventArgs e)
        {           
                ConsultModelo CM = new ConsultModelo();
            ConsultMarca CMarca = new ConsultMarca();
            cboMarca.DataSource = CMarca.listar();
            cboMarca.DisplayMember = "Nombre";
            cboMarca.ValueMember = "id";
            cboMarca.SelectedIndex = 0;

            try
                {
                dgvAgregarModelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAgregarModelos.DataSource = CM.listar();
                dgvAgregarModelos.Columns["Estado"].Visible = false;
                dgvAgregarModelos.Columns["Id"].Visible = false;
                dgvAgregarModelos.Columns["IdMarca"].Visible = false;

                //
                dgvAgregarModelos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;              
                dgvAgregarModelos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;


            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }            
        }

        private void dgvAgregarModelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAceptarModelos_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAgregarModelo_Click(object sender, EventArgs e)
        {
            string IdMarca = null;
            ConsultModelo cModelo = new ConsultModelo();
            Modelo nuevo = new Modelo();

            try
            {
                nuevo.Nombre = txtBoxAgregarNombreDeModelo.Text;
                IdMarca = cboMarca.SelectedValue.ToString();

                if (txtBoxAgregarNombreDeModelo.Text.Trim() == "")// || txtIdMarca.Text.Trim() =="")
                {
                    MessageBox.Show("Obligatorio escribir nombre de Modelo o ID de Marca");
                    return;
                }

                //nuevo.Nombre = int.Parse(txtBoxAgregarNombreDeMarca.Text);
                cModelo.altaModelo(nuevo, IdMarca);
                mostrarModelo();
                txtBoxAgregarNombreDeModelo.Clear();

                MessageBox.Show("Marca agregada correctamente");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
