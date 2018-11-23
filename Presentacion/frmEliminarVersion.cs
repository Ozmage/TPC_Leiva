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
    public partial class frmEliminarVersion : Form
    {
        bool Eliminar = false;
        public frmEliminarVersion(int nivel)
        {
            InitializeComponent();
            this.nivel = nivel;
        }
        int nivel;

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

        private void frmEliminarVersion_Load(object sender, EventArgs e)
        {
            if (nivel==2)
            {
                btnEliminarFisico.Hide();
            }

            txtVersion.Enabled = false;           
            cboMarca.Enabled = false;
            cboModelo.Enabled = false;

            //
            dgvMostrarVersion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listarVersiones();


        }


        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {                          
                ConsultVersiones cVersion = new ConsultVersiones();
                VersionA eliminarL = new VersionA();
                
                //REVISO QUE TODOS LOS CAMPOS ESTÉN COMPLETOS
                if (txtVersion.Text.Trim() == "" )//|| txtVersionNueva.Text.Trim() == "" || cboMarca.SelectedIndex < 0)
                {
                    MessageBox.Show("Obligatorio completar todos los campos");
                    return;
                }

                try
                {
                    cVersion.eliminarL(auto);
                    MessageBox.Show("Eliminado Logico correctamente");

                    txtVersion.Clear();                    
                    cboModelo.ResetText();
                    cboMarca.ResetText();                                    
                    listarVersiones();                

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            
                
                ConsultVersiones cVersion = new ConsultVersiones();
                VersionA eliminarF = new VersionA();

                try
                {
                    eliminarF.Nombre = txtVersion.Text;                    

                    if (txtVersion.Text.Trim() == "")// || txt.Text.Trim() == "" || txtMarca.Text.Trim() == "" || txtIdVersion.Text.Trim() == "")
                    {
                        MessageBox.Show("Obligatorio completar todos los campos");
                        return;
                    }

                    cVersion.eliminarF(auto);
                    MessageBox.Show("Eliminado Fisico correctamente");
                    listarVersiones();

                    txtVersion.Clear();

                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            
        }

        private void btnSeleccionarModelo_Click(object sender, EventArgs e)
        {
            txtVersion.Enabled = false;
            txtVersion.Text = dgvMostrarVersion.CurrentRow.Cells["Nombre"].Value.ToString();
            

            cboMarca.Enabled = false;
            cboModelo.Enabled = false;

            //COMPLETO EL COMBO MARCA
            auto.NombreVersion = txtVersion.Text;
            //BUSCO EL ID DE MARCA Y MODELO DE LA VERSION SELECCIONADA
            auto = bus.buscarIds(auto);
            //MessageBox.Show(auto.IdVersion.ToString());            

            //COMPLETO COMBO DE MARCAS
            cboMarca.DataSource = CM.listar();
            cboMarca.DisplayMember = "Nombre";
            cboMarca.ValueMember = "id";
            cboMarca.SelectedIndex = auto.IdMarca - 1;
            
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtVersion.Enabled = false;
            //txtVersionNueva.Enabled = false;
            cboMarca.Enabled = false;
            cboModelo.Enabled = false;
        }
    }
}
