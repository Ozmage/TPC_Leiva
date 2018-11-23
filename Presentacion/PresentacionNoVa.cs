using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void tsbNuevoTurno_Click(object sender, EventArgs e)
        {

                 //      COMO HACER QUE SE ABRA SOLO UNA VENTANA EN EL ESPACOP DEL MENU RPINCIPAL
       
                     
        }

        private void tsbEliminarDatos_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbModificarTurnos_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbBuscarTurno_Click(object sender, EventArgs e)
        {
            MostrarMarcas marca = new MostrarMarcas();
                
            marca.Show();
        }

        private void dgvMenuPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void porMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarMarcas marca = new MostrarMarcas();

            marca.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //NuevoPresupuesto NP = new NuevoPresupuesto();
            //NP.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void porModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarModelos modelo = new MostrarModelos();
            modelo.Show();
        }

        private void porVersiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarVersiones versiones = new MostrarVersiones();
            versiones.Show();
        }

        private void tsbPropiedades_Click(object sender, EventArgs e)
        {
           
            
        }

        private void presupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NuevoPresupuesto NP = new NuevoPresupuesto();
            //NP.Show();
        }
    }
}
