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
    public partial class frmAgregarVersion : Form
    {
        public frmAgregarVersion()
        {
            InitializeComponent();
        }

        public void mostrarVersion()
        {
            ConsultVersiones CV = new ConsultVersiones();

            try
            {
                dgvAgregarVersiones.DataSource = CV.listar();
                dgvAgregarVersiones.Columns["Estado"].Visible = false;
                dgvAgregarVersiones.Columns["Id"].Visible = false;
                dgvAgregarVersiones.Columns["IdModelo"].Visible = false;
                dgvAgregarVersiones.Columns["IdMarca"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lblModelos_Click(object sender, EventArgs e)
        {

        }

        private void frmAgregarVersion_Load(object sender, EventArgs e)
        {
            ConsultVersiones CV = new ConsultVersiones();
            ConsultMarca CM = new ConsultMarca();
            cboMarca.DataSource = CM.listar();
            cboMarca.DisplayMember = "Nombre";
            cboMarca.ValueMember = "id";
            cboMarca.SelectedIndex = 0;

            //ConsultModelo CMod = new ConsultModelo();
            //cboModelo.DataSource = CMod.listar();
            //cboModelo.DisplayMember = "Nombre";
            //cboModelo.ValueMember = "id";
            //cboModelo.SelectedIndex = 0;


            try
            {
                dgvAgregarVersiones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAgregarVersiones.DataSource = CV.listar();

                dgvAgregarVersiones.Columns["Estado"].Visible = false;                
                dgvAgregarVersiones.Columns["Id"].Visible = false;
                dgvAgregarVersiones.Columns["IdModelo"].Visible = false;
                dgvAgregarVersiones.Columns["IdMarca"].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvAgregarVersiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAceptarVersiones_Click(object sender, EventArgs e)
        {
            
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultModelo CMod = new ConsultModelo();

            if (cboMarca.SelectedIndex > -1)
            {

                //EL ID DE LA MARCA AUX VA A SER EL SELECCIONADO
                Marca marca = (Marca)cboMarca.SelectedItem;

                //COMPLETO LOS MODELOS CON EL ID DE LA MARCA
                cboModelo.DataSource = CMod.listarPorId(marca.Id.ToString());
                cboModelo.DisplayMember = "Nombre";
                cboModelo.ValueMember = "id";
            }
        }

        private void btnAgregarVersion_Click(object sender, EventArgs e)
        {
            string idVersion = null;
            string idModelo = null;
            string idMarca = null;

            ConsultVersiones cVersion = new ConsultVersiones();


            VersionA nuevo = new VersionA();

            try
            {
                nuevo.Nombre = txtBoxAgregarNombreDeVersiones.Text;
                idModelo = cboModelo.SelectedValue.ToString();
                idMarca = cboMarca.SelectedValue.ToString();

                if (txtBoxAgregarNombreDeVersiones.Text.Trim() == "")// || txtIdMarca.Text.Trim() == ""||txtIdModelo.Text.Trim()=="")
                {
                    MessageBox.Show("Obligatorio escribir nombre de Modelo,ID de Marca e ID de Modelo");
                    return;
                }

                //nuevo.Nombre = int.Parse(txtBoxAgregarNombreDeMarca.Text);
                cVersion.altaVersion(nuevo, idMarca, idModelo);
                mostrarVersion();


                txtBoxAgregarNombreDeVersiones.Clear();
                MessageBox.Show("Version agregada correctamente");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
