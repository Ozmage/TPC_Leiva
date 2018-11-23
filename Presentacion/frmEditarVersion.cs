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
    public partial class frmEditarVersion : Form
    {
        public frmEditarVersion()
        {
            InitializeComponent();
        }
        ConsultMarca CM = new ConsultMarca();
        ConsultModelo CMo = new ConsultModelo();
        ConsultVersiones CV = new ConsultVersiones();
        VersionA editar = new VersionA();
        Auto auto = new Auto();
        Busqueda bus = new Busqueda();

        private System.Version version = null;
        private bool Editar = false;

        public void listarVersiones()
        {
            try
            {
                dgvMostrarVersion.DataSource = CV.listar();
                dgvMostrarVersion.Columns["Id"].Visible = false;
                dgvMostrarVersion.Columns["IdModelo"].Visible = false;
                dgvMostrarVersion.Columns["IdMarca"].Visible = false;
                dgvMostrarVersion.Columns["Estado"].Visible = false;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        public frmEditarVersion(System.Version modi)
        {
            InitializeComponent();
            version = modi;
        }
        

        private void frmEditarVersion_Load(object sender, EventArgs e)
        {
            txtVersion.Enabled = false;
            txtVersionNueva.Enabled = false;
            cboMarca.Enabled = false;
            cboModelo.Enabled = false;

            //
            dgvMostrarVersion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listarVersiones();

        }

        

        private void btnGuardarVersion_Click(object sender, EventArgs e)
        {
         
        }

        private void btnSeleccionarModelo_Click(object sender, EventArgs e)
        {

            txtVersion.Enabled = false;
            txtVersion.Text = dgvMostrarVersion.CurrentRow.Cells["Nombre"].Value.ToString();

            cboMarca.Enabled = true;
            cboModelo.Enabled = true;

            //COMPLETO EL COMBO MARCA
            auto.NombreVersion = txtVersion.Text;
            //BUSCO EL ID DE MARCA Y MODELO DE LA VERSION SELECCIONADA
            auto = bus.buscarIds(auto);            


            //COMPLETO COMBO DE MARCAS
            cboMarca.DataSource = CM.listar();
            cboMarca.DisplayMember = "Nombre";
            cboMarca.ValueMember = "id";
            cboMarca.SelectedIndex = auto.IdMarca-1;

            txtVersionNueva.Enabled = true;

            /////
            ///

            string cboMarcaSeleccionada = cboMarca.SelectedValue.ToString();


            //EL ID DE LA MARCA AUX VA A SER EL SELECCIONADO
            Marca marca = (Marca)cboMarca.SelectedItem;

            //COMPLETO LOS MODELOS CON EL ID DE LA MARCA
            cboModelo.DataSource = CMo.listarPorId(marca.Id.ToString());
            cboModelo.DisplayMember = "Nombre";
            cboModelo.ValueMember = "id";



        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            /////////////////////////////
            ///SI CAMBIA LA MARCA COLOCO MODELOS Y VERSION EN 0
            ///

            if (cboMarca.SelectedIndex > -1)
            {


                //EL ID DE LA MARCA AUX VA A SER EL SELECCIONADO
                Marca marca = (Marca)cboMarca.SelectedItem;

                //COMPLETO LOS MODELOS CON EL ID DE LA MARCA
                cboModelo.DataSource = CMo.listarPorId(marca.Id.ToString());
                cboModelo.DisplayMember = "Nombre";
                cboModelo.ValueMember = "id";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            auto.NombreVersion = txtVersion.Text;
            auto=bus.buscarIds(auto);
            MessageBox.Show(auto.IdMarca.ToString());

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtVersion.Enabled = false;
            txtVersionNueva.Enabled = false;
            cboMarca.Enabled = false;
            cboModelo.Enabled = false;

        }

        private void btnAceptarVersiones_Click(object sender, EventArgs e)
        {
            string versionNuevaAux = txtVersionNueva.Text;
            //REVISO QUE TODOS LOS CAMPOS ESTÉN COMPLETOS
            if (txtVersion.Text.Trim() == "" || txtVersionNueva.Text.Trim() == "" || cboMarca.SelectedIndex < 0)
            {
                MessageBox.Show("Obligatorio completar todos los campos");
                return;
            }


            try
            {                
                CV.modificarVersion(auto, versionNuevaAux);
                txtVersion.Clear();
                txtVersionNueva.Clear();
                cboModelo.ResetText();
                cboMarca.ResetText();
                
                MessageBox.Show("Marca editada correctamente");
                listarVersiones();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }
    }
}
