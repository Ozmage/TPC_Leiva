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
    public partial class frmEditarMarca : Form
    {
        private Marca marca = null;
        private bool Editar = false;
        


        public void mostrarMarca()
        {
            ConsultMarca CM = new ConsultMarca();

            try
            {
                dgvMostrarMarca.DataSource = CM.listar();
                dgvMostrarMarca.Columns["Estado"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public frmEditarMarca()
        {
            InitializeComponent();
        }

        public frmEditarMarca(Marca modi)
        {
            InitializeComponent();
            marca = modi;
        }

        private void frmEditarMarca_Load(object sender, EventArgs e)
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

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMostrarMarca.SelectedRows.Count > 0)
            {
                ///Si logra entrar a editar, cambio la flag a true
                Editar = true;
                txtId.Text = dgvMostrarMarca.CurrentRow.Cells["id"].Value.ToString();
                txtMarca.Text = dgvMostrarMarca.CurrentRow.Cells["Nombre"].Value.ToString();
                txtId.Enabled = false;

            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            ConsultMarca CM = new ConsultMarca();                        
            Marca editar = new Marca();
            int idAux;
            string Id = null;

            //SI SE CARGAN DATOS SELECCIONANDO EL BOTON SELECCIONAR
            if (Editar==true)
            {     
                try
                {
                    editar.Nombre = txtMarca.Text;
                    Id = dgvMostrarMarca.CurrentRow.Cells["Id"].Value.ToString();

                    if (txtMarca.Text.Trim() == "")
                    {
                        MessageBox.Show("Obligatorio escribir nombre de Marca");
                        return;
                    }

                    //GUARDO
                    CM.modificar(txtMarca.Text,Id);                    
                    mostrarMarca();
                    txtMarca.Clear();
                    txtId.Clear();
                    MessageBox.Show("Marca editada correctamente");
                    txtId.Enabled = true;
                    Editar = false;
                    return;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

            Id = txtId.Text;

            //REVISO SI EL ID ESCRITO MANUALMENTE EXISTE       
            idAux = CM.buscarSiExisteId(txtId.Text);

            //SI ES 0 ES QUE NO EXISTE EL ID
            if (idAux == 0)
            {
                MessageBox.Show("No existe el ID de la Marca, Intente nuevamente");
                return;
            }
            //SI NO ES 0 ES QUE EXISTE
            else
            {
                if (txtMarca.Text.Trim() == "" || txtId.Text.Trim()=="")
                {
                    MessageBox.Show("Obligatorio escribir nombre de Marca");
                    return;
                }

                //GUARDO
                CM.modificar(txtMarca.Text, Id);
                mostrarMarca();
                txtMarca.Clear();
                txtId.Clear();
                MessageBox.Show("Marca editada correctamente");
                txtId.Enabled = true;
                return;

            }


        }
    }
}
