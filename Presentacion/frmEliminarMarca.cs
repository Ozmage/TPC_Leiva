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
    public partial class frmEliminarMarca : Form
    {
        bool Eliminar = false;
        public frmEliminarMarca(int nivel)
        {
            InitializeComponent();
            this.nivel = nivel;
        }

        int nivel;

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

        private void frmEliminarMarca_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtMarca.Enabled = false;

            if (nivel==2)
            {
                btnEliminarFisico.Hide();
            }
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            

            if (dgvMostrarMarca.SelectedRows.Count > 0)
            {
                ///Si logra entrar a Eliminar, cambio la flag a true
                Eliminar = true;
                txtId.Text = dgvMostrarMarca.CurrentRow.Cells["id"].Value.ToString();
                txtMarca.Text = dgvMostrarMarca.CurrentRow.Cells["Nombre"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una celda por favor");
            }
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            if (Eliminar == true)
            {
                string Id = null;
                ConsultMarca cMarca = new ConsultMarca();
                Marca eliminarL = new Marca();

                try
                {
                    eliminarL.Nombre = txtMarca.Text;
                    Id = dgvMostrarMarca.CurrentRow.Cells["Id"].Value.ToString();

                    if (txtMarca.Text.Trim() == "")
                    {
                        MessageBox.Show("Obligatorio escribir nombre de Marca");
                        return;
                    }

                    cMarca.eliminarL(eliminarL, Id);
                    mostrarMarca();
                    txtMarca.Clear();
                    txtId.Clear();
                    MessageBox.Show("Marca borrada L correctamente");

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
                string Id = null;
                ConsultMarca cMarca = new ConsultMarca();
                Marca eliminarF = new Marca();

                try
                {
                    eliminarF.Nombre = txtMarca.Text;
                    Id = dgvMostrarMarca.CurrentRow.Cells["Id"].Value.ToString();

                    if (txtMarca.Text.Trim() == "")
                    {
                        MessageBox.Show("Obligatorio escribir nombre de Marca");
                        return;
                    }

                    cMarca.eliminarF(eliminarF, Id);
                    mostrarMarca();
                    txtMarca.Clear();
                    txtId.Clear();
                    MessageBox.Show("Marca borrada F correctamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void dgvMostrarMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
