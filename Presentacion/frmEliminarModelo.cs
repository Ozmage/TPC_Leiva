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
    public partial class frmEliminarModelo : Form
    {
        bool Eliminar = false;
        public frmEliminarModelo(int nivel)
        {
            InitializeComponent();
            this.nivel = nivel;
        }
        int nivel;
        public void mostrarModelo()
        {
            ConsultModelo CM = new ConsultModelo();
            try
            {
                dgvMostrarModelos.DataSource = CM.listar();
                dgvMostrarModelos.Columns["Estado"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //Si se seleccionó una fila
            if (dgvMostrarModelos.SelectedRows.Count > 0)
            {
                ///Si logra entrar a Eliminar, cambio la flag a true
                Eliminar = true;
                txtIdModelos.Text = dgvMostrarModelos.CurrentRow.Cells["Id"].Value.ToString();
                txtMarca.Text = dgvMostrarModelos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtModelo.Text = dgvMostrarModelos.CurrentRow.Cells["IdMarca"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una celda por favor");
            }
        }

        private void frmEliminarModelo_Load(object sender, EventArgs e)
        {
            txtIdModelos.Enabled = false;
            txtMarca.Enabled = false;
            txtModelo.Enabled = false;

            if (nivel == 2)
            {
                btnEliminarFisico.Hide();
            }
            ConsultModelo CM = new ConsultModelo();
            try
            {
                dgvMostrarModelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMostrarModelos.DataSource = CM.listar();
                dgvMostrarModelos.Columns["Estado"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            if (Eliminar == true)
            {
                string IdMarca = null;
                string IdModelo = null;
                ConsultModelo cModelo = new ConsultModelo();
                Modelo eliminarL = new Modelo();

                try
                {
                    eliminarL.Nombre = txtMarca.Text;
                    IdModelo = dgvMostrarModelos.CurrentRow.Cells["Id"].Value.ToString();
                    IdMarca = dgvMostrarModelos.CurrentRow.Cells["IdMarca"].Value.ToString();

                    if (txtIdModelos.Text.Trim() == ""|| txtMarca.Text.Trim() == ""|| txtModelo.Text.Trim() == "")
                    {
                        MessageBox.Show("Obligatorio completar todos los campos");
                        return;
                    }

                    cModelo.eliminarL(eliminarL, IdModelo,IdMarca);
                    mostrarModelo();
                    txtMarca.Clear();
                    txtIdModelos.Clear();
                    txtModelo.Clear();
                    MessageBox.Show("Modelo borrada L correctamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            if (Eliminar == true)
            {
                string IdMarca = null;
                string IdModelo = null;
                ConsultModelo cModelo = new ConsultModelo();
                Modelo eliminarF = new Modelo();

                try
                {
                    eliminarF.Nombre = txtMarca.Text;
                    IdModelo = dgvMostrarModelos.CurrentRow.Cells["Id"].Value.ToString();
                    IdMarca = dgvMostrarModelos.CurrentRow.Cells["IdMarca"].Value.ToString();

                    if (txtIdModelos.Text.Trim() == "" || txtMarca.Text.Trim() == "" || txtModelo.Text.Trim() == "")
                    {
                        MessageBox.Show("Obligatorio completar todos los campos");
                        return;
                    }

                    cModelo.eliminarF(eliminarF, IdModelo);
                    mostrarModelo();
                    txtMarca.Clear();
                    txtIdModelos.Clear();
                    txtModelo.Clear();
                    MessageBox.Show("Modelo borrada F correctamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void dgvMostrarModelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
