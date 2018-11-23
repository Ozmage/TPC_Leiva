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
using System.Runtime.InteropServices;


namespace Presentacion
{    

    public partial class frmPresentacion : Form
    {
        //PARA TIMERS, CONTROL DE PANEL COLAPSADO
        private bool IsCollapsed;
        private bool IsCollapsed2;
        private bool IsCollapsed3;
        private bool IsCollapsed4;
        private bool IsCollapsed5;
        private bool IsCollapsed6;
        

        int nivel;

        
    
        
        public frmPresentacion(int nivel)
        {
            InitializeComponent();
            this.nivel = nivel;
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnRestaurar.Visible = true;
            
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMax.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mostrarContenidoHijo(new StartFrame());
        }
       

        private void bnSoporte_Click(object sender, EventArgs e)
        {
            mostrarContenidoHijo(new frmSoporte());
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            mostrarContenidoHijo(new frmAcercaDe());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
              

        public void mostrarContenidoHijo(object formHijo)
        {
            //cantidad de controles
            int CantControles = 0;
            //Si hay más de 0 hay que limpiar
            if (this.pnlCentral.Controls.Count > 0)
                // Igualo la variable a la cantidad que existan
                CantControles = pnlCentral.Controls.Count;
            //borro
            this.pnlCentral.Controls.RemoveAt(CantControles - 1);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlCentral.Controls.Add(fh);
            this.pnlCentral.Tag = fh;
            fh.Show();

        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            timer1.Start();            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnRestaurar.Visible = true;
        }       
       
        ///
        private void PresentacionPrueba_Load(object sender, EventArgs e)
        {
            if (nivel==0)
            {
                MessageBox.Show("Sin credenciales no puedes ingresar");
                Application.Exit();
                
            }
            //OCULTAMOS PANELES A USUARIOS
            
            //MessageBox.Show(nivel.ToString());
            if (nivel==2)            
            {
                pnlUsuarios.Hide();
                pnlBuscar.Hide();
            }
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsCollapsed)
            {
                //button5.Image = Resources.Collapse_Arrow_20px;
                pnlArchivo.Height += 10;
                if (pnlArchivo.Size == pnlArchivo.MaximumSize)
                {
                    timer1.Stop();
                    IsCollapsed = false;
                }
            }
            else
            {
                //button5.Image = Resources.Expand_Arrow_20px;
                pnlArchivo.Height -= 10;
                if (pnlArchivo.Size == pnlArchivo.MinimumSize)
                {
                    timer1.Stop();
                    IsCollapsed = true;
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (IsCollapsed2)
            {
                //button5.Image = Resources.Collapse_Arrow_20px;
                pnlAyuda.Height += 10;
                if (pnlAyuda.Size == pnlAyuda.MaximumSize)
                {
                    timer2.Stop();
                    IsCollapsed2 = false;
                }
            }
            else
            {
                //button5.Image = Resources.Expand_Arrow_20px;
                pnlAyuda.Height -= 10;
                if (pnlAyuda.Size == pnlAyuda.MinimumSize)
                {
                    timer2.Stop();
                    IsCollapsed2 = true;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (IsCollapsed3)
            {
                //button5.Image = Resources.Collapse_Arrow_20px;
                pnlBuscar.Height += 10;
                if (pnlBuscar.Size == pnlBuscar.MaximumSize)
                {
                    timer3.Stop();
                    IsCollapsed3 = false;
                }
            }
            else
            {
                //button5.Image = Resources.Expand_Arrow_20px;
                pnlBuscar.Height -= 10;
                if (pnlBuscar.Size == pnlBuscar.MinimumSize)
                {
                    timer3.Stop();
                    IsCollapsed3 = true;
                }
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (IsCollapsed4)
            {
                //button5.Image = Resources.Collapse_Arrow_20px;
                pnlUsuarios.Height += 10;
                if (pnlUsuarios.Size == pnlUsuarios.MaximumSize)
                {
                    timer4.Stop();
                    IsCollapsed4 = false;
                }
            }
            else
            {
                //button5.Image = Resources.Expand_Arrow_20px;
                pnlUsuarios.Height -= 10;
                if (pnlUsuarios.Size == pnlUsuarios.MinimumSize)
                {
                    timer4.Stop();
                    IsCollapsed4 = true;
                }
            }
        }

        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            mostrarContenidoHijo(new MostrarMarcas());
        }

        private void btnBuscarModelo_Click(object sender, EventArgs e)
        {
            mostrarContenidoHijo(new MostrarModelos());
        }

        private void btnVersion_Click(object sender, EventArgs e)
        {
            mostrarContenidoHijo(new frmPresupuestosAVencer());
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            mostrarContenidoHijo(new MostrarPersona());
        }

        private void timerFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoPresupuesto_Click(object sender, EventArgs e)
        {
            mostrarContenidoHijo(new frmAgregarPresupuesto());
        }

        private void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            mostrarContenidoHijo(new frmAgregarMarca());
        }

        private void btnNuevoModelo_Click(object sender, EventArgs e)
        {
            mostrarContenidoHijo(new frmAgregarModelo());
        }

        private void btnNuevaVersion_Click(object sender, EventArgs e)
        {
            mostrarContenidoHijo(new frmAgregarVersion());
        }

        private void btnArchivo_MouseHover(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnBuscar_MouseHover(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void btnAyuda_DragOver(object sender, DragEventArgs e)
        {
            timer2.Start();
        }

        private void btnUsuarios_MouseHover(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlCentral_Paint(object sender, PaintEventArgs e)
        {


        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (IsCollapsed5)
            {
                //button5.Image = Resources.Collapse_Arrow_20px;
                pnlEditar.Height += 10;
                if (pnlEditar.Size == pnlEditar.MaximumSize)
                {
                    timer5.Stop();
                    IsCollapsed5 = false;
                }
            }
            else
            {
                //button5.Image = Resources.Expand_Arrow_20px;
                pnlEditar.Height -= 10;
                if (pnlEditar.Size == pnlEditar.MinimumSize)
                {
                    timer5.Stop();
                    IsCollapsed5 = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mostrarContenidoHijo(new frmEditarModelo());
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            timer5.Start();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
                
        }

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {
            mostrarContenidoHijo(new frmEditarMarca());
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (IsCollapsed6)
            {
                //button5.Image = Resources.Collapse_Arrow_20px;
                pnlEliminar.Height += 10;
                if (pnlEliminar.Size == pnlEliminar.MaximumSize)
                {
                    timer6.Stop();
                    IsCollapsed6 = false;
                }
            }
            else
            {
                //button5.Image = Resources.Expand_Arrow_20px;
                pnlEliminar.Height -= 10;
                if (pnlEliminar.Size == pnlEliminar.MinimumSize)
                {
                    timer6.Stop();
                    IsCollapsed6 = true;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            timer6.Start();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            mostrarContenidoHijo(new frmEliminarMarca(nivel));
        }

        private void btnEliminarModelo_Click(object sender, EventArgs e)
        {
            mostrarContenidoHijo(new frmEliminarModelo(nivel));
        }

        private void btnEliminarVersion_Click(object sender, EventArgs e)
        {
            mostrarContenidoHijo(new frmEliminarVersion(nivel));
        }

        private void btnEliminarPresupuesto_Click(object sender, EventArgs e)
        {
            mostrarContenidoHijo(new frmEliminarPresupuesto());
        }

        private void btnEditarVersion_Click(object sender, EventArgs e)
        {
            mostrarContenidoHijo(new frmEditarVersion());
        }

        private void btnEditarPresupuesto_Click(object sender, EventArgs e)
        {
            mostrarContenidoHijo(new frmPresupuestosAVencer());
        }

        private void btnBuscarPresupuesto_Click(object sender, EventArgs e)
        {
            mostrarContenidoHijo(new frmMostrarPresupuesto());
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            nivel = 0;            
            this.Close();
        }

        ///////////// PARA PODER MOVER LA VENTANA //////////
        ///
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

