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
    public partial class frmLogin : Form
    {
        

        public frmLogin()
        {
            InitializeComponent();            
        }

        int nivel;
        

        private void btnAgregarPresupuesto_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Busqueda bus = new Busqueda();            
                        
            int login;
            login=bus.loginCheck(txtUsuario.Text,txtContraseña.Text);
            nivel = login;
            //MessageBox.Show(login.ToString());

            if (nivel<1)
            {
                MessageBox.Show("Credenciales incorrectas, intente nuevamente");
                txtContraseña.Clear();
                txtUsuario.Clear();
                return;
            }
            frmPresentacion presentacion = new frmPresentacion(nivel);
            
            presentacion.ShowDialog();
            this.Close();




        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
