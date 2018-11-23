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
    public partial class frmPresupuestosAVencer : Form
    {
        public frmPresupuestosAVencer()
        {
            InitializeComponent();
        }

        private void frmEditarPresupuesto_Load(object sender, EventArgs e)
        {
            dgvMostrarPresupuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConsultPresupuesto CP = new ConsultPresupuesto();
            try
            {
                dgvMostrarPresupuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMostrarPresupuestos.DataSource = CP.listadoAVencer();


                dgvMostrarPresupuestos.Columns["idcliente"].Visible = false;
                dgvMostrarPresupuestos.Columns["detalle"].Visible = false;
                dgvMostrarPresupuestos.Columns["coddesc"].Visible = false;
                dgvMostrarPresupuestos.Columns["idmarca"].Visible = false;
                dgvMostrarPresupuestos.Columns["idmodelo"].Visible = false;
                dgvMostrarPresupuestos.Columns["idversion"].Visible = false;
                dgvMostrarPresupuestos.Columns["patente"].Visible = false;
                dgvMostrarPresupuestos.Columns["cerokm"].Visible = false;
                dgvMostrarPresupuestos.Columns["anio"].Visible = false;
                dgvMostrarPresupuestos.Columns["gncgas"].Visible = false;

                dgvMostrarPresupuestos.Columns["formadepago"].Visible = false;
                dgvMostrarPresupuestos.Columns["direccion"].Visible = false;
                dgvMostrarPresupuestos.Columns["pisoplanta"].Visible = false;
                dgvMostrarPresupuestos.Columns["localidad"].Visible = false;
                dgvMostrarPresupuestos.Columns["provincia"].Visible = false;
                dgvMostrarPresupuestos.Columns["estadopersona"].Visible = false;
                dgvMostrarPresupuestos.Columns["estadopresupuesto"].Visible = false;
                dgvMostrarPresupuestos.Columns["dni"].Visible = false;
                dgvMostrarPresupuestos.Columns["fechadenacimiento"].Visible = false;
                dgvMostrarPresupuestos.Columns["codpostal"].Visible = false;
                dgvMostrarPresupuestos.Columns["fechapresupuesto"].Visible = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
