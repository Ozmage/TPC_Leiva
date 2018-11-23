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
    public partial class frmEditarModelo : Form
    {
        private Modelo modelo = null;
        private bool Editar = false;

        public frmEditarModelo()
        {
            InitializeComponent();
        }

        public frmEditarModelo(Modelo modi)
        {
            InitializeComponent();
            modelo = modi;
        }

        public void mostrarModelo()
        {
            ConsultModelo CM = new ConsultModelo();

            try
            {
                dgvMostrarModelo.DataSource = CM.listar();
                dgvMostrarModelo.Columns["Estado"].Visible = false;
                dgvMostrarModelo.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmEditarModelo_Load(object sender, EventArgs e)
        {
            ConsultModelo CM = new ConsultModelo();
            txtModelo.Enabled = false;
            txtModeloNuevo.Enabled = false;
            cboMarca.Enabled = false;

            try
            {
                dgvMostrarModelo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMostrarModelo.DataSource = CM.listar();
                dgvMostrarModelo.Columns["Estado"].Visible = false;
                dgvMostrarModelo.Columns["Id"].Visible = false;
                dgvMostrarModelo.Columns["IdMarca"].Visible = false;

            }
            catch (Exception ex)            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvMostrarModelo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditarModelo_Click(object sender, EventArgs e)
        {
            ConsultMarca CM = new ConsultMarca();

            if (dgvMostrarModelo.SelectedRows.Count > 0)
            {
                ///Si logra entrar a editar, cambio la flag a true
                Editar = true;
                //txtId.Text = dgvMostrarModelo.CurrentRow.Cells["id"].Value.ToString();
                txtModelo.Text = dgvMostrarModelo.CurrentRow.Cells["Nombre"].Value.ToString();
                //txtIdMarca.Text = dgvMostrarModelo.CurrentRow.Cells["IdMarca"].Value.ToString();


                //EL ID DE LA MARCA AUX VA A SER EL SELECCIONADO
                Marca marca = (Marca)cboMarca.SelectedItem;

                //COMPLETO LOS MODELOS CON EL ID DE LA MARCA
                cboMarca.DataSource = CM.listar();
                cboMarca.DisplayMember = "Nombre";
                cboMarca.ValueMember = "id";
                
                txtModeloNuevo.Enabled = true;
                cboMarca.Enabled = true;

            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnGuardarModelo_Click(object sender, EventArgs e)
        {
            //REVISO QUE TODOS LOS CAMPOS ESTÉN COMPLETOS
            if (txtModelo.Text.Trim()==""||txtModeloNuevo.Text.Trim()==""||cboMarca.SelectedIndex<0)
            {
                MessageBox.Show("Obligatorio completar todos los campos");
                return;
            }


            if (Editar == true)
            {
                string IdModelo = null;
                string IdMarca = null;
                ConsultModelo cModelo = new ConsultModelo();
                Modelo editar = new Modelo();

                try
                {
                    editar.Nombre = txtModeloNuevo.Text;
                    IdModelo = dgvMostrarModelo.CurrentRow.Cells["Id"].Value.ToString();
                    //IdMarca = dgvMostrarModelo.CurrentRow.Cells["IdMarca"].Value.ToString();
                    IdMarca = cboMarca.SelectedValue.ToString();


                    if (txtModelo.Text.Trim() == "" || txtModeloNuevo.Text.Trim()=="")
                    {
                        MessageBox.Show("Obligatorio completar todos los campos");
                        return;
                    }

                    //GUARDO
                    //cModelo.modificarModelo(editar, IdModelo,IdMarca);
                    cModelo.modificarModelo(editar, IdModelo, IdMarca);
                    mostrarModelo();
                    txtModelo.Clear();
                    txtModeloNuevo.Clear();
                    cboMarca.ResetText();

                    txtModelo.Enabled = false;
                    cboMarca.Enabled = false;
                    txtModeloNuevo.Enabled = false;
                    MessageBox.Show("Modelo editado correctamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            txtModelo.Enabled = false;
            txtModeloNuevo.Enabled = false;
            cboMarca.Enabled = false;
        }
    }
}
