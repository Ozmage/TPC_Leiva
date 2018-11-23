using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class frmAgregarPresupuesto : Form
    {
        public frmAgregarPresupuesto()
        {
            InitializeComponent();
        }
        int clienteExist = 0;
        Cliente aux = new Cliente();
        ConsultMarca CM = new ConsultMarca();
        ConsultModelo CMo = new ConsultModelo();
        ConsultVersiones CV = new ConsultVersiones();
        //string idMarcaAux;
        string idModeloAux;
        string idVersionAux;

        public void enviarPresupuestoMail()
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
            mmsg.To.Add(txtEmail.Text);
            mmsg.Subject = "Presupuesto Auto";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            mmsg.Bcc.Add(txtEmail.Text);
            mmsg.Body = "Sus datos del formulario de Presupuesto son: Nombre: " + txtNombre.Text + " Apellido: " + txtApellido.Text + " DNI: " + txtDni.Text + " Direccion: " + txtDireccion.Text + " Piso:" + txtPisoPlanta.Text + " Localidad:" + txtLocalidad.Text + " Codigo Postal: " + txtCodPostal.Text + " Provincia: " + txtProvincia.Text + " Teléfono: " + txtTelefono.Text + "Fecha de Nacimiento: " + dtpFechaNac.Text + " Marca de su auto: " + cboMarca.Text + " Modelo de su auto: " + cboModelo.Text + " Versión de su auto: " + cboVersion.Text + " GNC/GAS: " + cboGncGas.Text + " 0KM : " + cboCeroKm.Text + " Año: " + txtAnio.Text + " Forma de pago: " + cboFDePago.Text + " Código de descuento:" + txtCodDesc.Text + "Detalle: " + txtDetalle.Text;

            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new System.Net.Mail.MailAddress("diegoleiva.1986@gmail.com");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("diegoleiva.1986@gmail.com", "*******");

            cliente.Port = 587;
            cliente.EnableSsl = true;

            cliente.Host = "smtp.gmail.com";

            try
            {
                cliente.Send(mmsg);
            }
            catch (Exception)
            {
                MessageBox.Show("error");
                throw;
            }
        }

        public void resetearCampos()
        {
            txtDNIBuscar.Clear();
            clienteExist = 0;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDni.Enabled = true;
            txtDireccion.Enabled = true;
            txtPisoPlanta.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefono.Enabled = true;
            txtCodPostal.Enabled = true;
            txtLocalidad.Enabled = true;
            txtProvincia.Enabled = true;
            dtpFechaNac.Enabled = true;

            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtDireccion.Clear();
            txtPisoPlanta.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtCodPostal.Clear();
            txtLocalidad.Clear();
            txtProvincia.Clear();
            dtpFechaNac.ResetText();

            cboMarca.SelectedIndex = -1;
            cboModelo.SelectedIndex = -1;
            cboVersion.SelectedIndex = -1;
            txtPatente.Clear();

            cboCeroKm.SelectedIndex = -1;
            txtAnio.Clear();
            cboGncGas.SelectedIndex = -1;
            cboFDePago.SelectedIndex = -1;
            txtCodDesc.Clear();
            txtDetalle.Clear();

            //REINICO

            //Desactivo campos
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDni.Enabled = false;
            txtDireccion.Enabled = false;
            txtPisoPlanta.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefono.Enabled = false;
            txtCodPostal.Enabled = false;
            txtLocalidad.Enabled = false;
            txtProvincia.Enabled = false;
            dtpFechaNac.Enabled = false;

            cboMarca.Enabled = false;
            cboModelo.Enabled = false;
            cboVersion.Enabled = false;
            txtPatente.Enabled = false;
            cboCeroKm.Enabled = false;
            txtAnio.Enabled = false;
            cboGncGas.Enabled = false;
            cboFDePago.Enabled = false;
            txtCodDesc.Enabled = false;
            txtDetalle.Enabled = false;

            btnAgregarPresupuesto.Enabled = false;
            btnResetCampos.Enabled = false;



            cboMarca.DataSource = CM.listar();
            cboMarca.DisplayMember = "Nombre";
            cboMarca.ValueMember = "id";
            cboMarca.SelectedIndex = -1;



        }



        private void button1_Click(object sender, EventArgs e)
        {
            ConsultPresupuesto cPresupuesto = new ConsultPresupuesto();
            ConsultPersona cPersona = new ConsultPersona();
            Presupuesto Presu = new Presupuesto();
            ConsultPresupuestoXCliente cPresuXCliente = new ConsultPresupuestoXCliente();
            Busqueda Bus = new Busqueda();
            HerramientasVentana enviarCorreo = new HerramientasVentana();
            string correo = "diegoleiva.1986@gmail.com";
                        
            try
            {
                string MarcaAux;
                string ModeloAux;
                string VersionAux;
                int ultimoPresuAux;

                if (clienteExist>0)
                {
                    Presu.Detalle = txtDetalle.Text;
                    
                    Presu.FechaPresupuesto = DateTime.Today;
                    Presu.FechaVencimiento = DateTime.Today.AddMonths(2);       

                    

                    MarcaAux = cboMarca.SelectedValue.ToString();
                    ModeloAux = cboModelo.SelectedValue.ToString();
                    VersionAux = cboVersion.SelectedValue.ToString();

                    Presu.IdMarca = int.Parse(MarcaAux);
                    Presu.IdModelo = int.Parse(ModeloAux);
                    Presu.IdVersion = int.Parse(VersionAux);

                    Presu.Patente = txtPatente.Text;
                    Presu.CeroKm = cboCeroKm.Text;
                    Presu.Anio = int.Parse(txtAnio.Text);
                    Presu.GncGas = cboGncGas.Text;
                    Presu.FormaDePago = cboFDePago.Text;
                    Presu.CodDesc = txtCodDesc.Text;
                    Presu.Detalle = txtDetalle.Text;
                                        
                    Presu.IdCliente = aux.IdCliente;
                    
                    cPresupuesto.altaPresupuesto(Presu, Presu.IdCliente);
                    
                    ultimoPresuAux = Bus.buscarUltimoPresupuesto();
                    cPresuXCliente.altaPresupuestoXCliente(Presu.IdCliente.ToString(),ultimoPresuAux.ToString());
                    enviarPresupuestoMail();
                    MessageBox.Show("Presupuesto guardado y enviado por Correo satisfactoriamente");
                    resetearCampos();

                    return;
                }

                Presu.Detalle = txtDetalle.Text;
                Presu.FechaPresupuesto = DateTime.Today;
                Presu.FechaVencimiento = DateTime.Today.AddMonths(2);



                MarcaAux = cboMarca.SelectedValue.ToString();
                ModeloAux = cboModelo.SelectedValue.ToString();
                VersionAux = cboVersion.SelectedValue.ToString();

                Presu.IdMarca = int.Parse(MarcaAux);
                Presu.IdModelo = int.Parse(ModeloAux);
                Presu.IdVersion = int.Parse(VersionAux);

                Presu.Patente = txtPatente.Text;
                Presu.CeroKm = cboCeroKm.Text;
                Presu.Anio = int.Parse(txtAnio.Text);
                Presu.GncGas = cboGncGas.Text;
                Presu.FormaDePago = cboFDePago.Text;
                Presu.CodDesc = txtCodDesc.Text;
                Presu.Detalle = txtDetalle.Text;

                Presu.Nombre = txtNombre.Text;
                Presu.Apellido = txtApellido.Text;
                Presu.DNI = int.Parse(txtDni.Text);
                Presu.Direccion = txtDireccion.Text;
                Presu.PisoPlanta = txtPisoPlanta.Text;
                Presu.Email = txtEmail.Text;
                Presu.Telefono = int.Parse(txtTelefono.Text);
                Presu.CodPostal = txtCodDesc.Text;
                Presu.Localidad = txtLocalidad.Text;
                Presu.Provincia = txtProvincia.Text;
                Presu.FechaDeNacimiento = DateTime.Parse(dtpFechaNac.Text);


                
                //-----
                Busqueda buscar = new Busqueda();                
                int valor;              
                valor = buscar.buscarUltimoIdCliente() + 1;
                //--
                
                //ALTA CLIENTE
                cPersona.altaCliente(Presu);
                //ALTA PRESUPUESTO
                cPresupuesto.altaPresupuesto(Presu, valor);

                //BUSCO ULTIMO PRESUPUESTO GUARDADO                            
                ultimoPresuAux = Bus.buscarUltimoPresupuesto();

                //BUSCO EL ID DEL CLIENTE INGRESADO EN EL PRESUPUESTO


                //GUARDO PRESUPUESTO X CLIENTE
                cPresuXCliente.altaPresupuestoXCliente(valor.ToString(), ultimoPresuAux.ToString());



            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {

        }


        private void frmAgregarPresupuesto_Load(object sender, EventArgs e)
        {
            resetearCampos();
            
                        
        }

        private void lblVersion_Click(object sender, EventArgs e)
        {

        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
                        /////////////////////////////
            ///SI CAMBIA LA MARCA COLOCO MODELOS Y VERSION EN 0
            ///

           if(cboMarca.SelectedIndex > -1)
            {
                idModeloAux = "0";
                idVersionAux = "0";

                //EL ID DE LA MARCA AUX VA A SER EL SELECCIONADO
                Marca marca = (Marca)cboMarca.SelectedItem;

                //COMPLETO LOS MODELOS CON EL ID DE LA MARCA
                cboModelo.DataSource = CMo.listarPorId(marca.Id.ToString());
                cboModelo.DisplayMember = "Nombre";
                cboModelo.ValueMember = "id";
            }
        }

        private void cboVersion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            Busqueda bus = new Busqueda();
            
            aux = bus.buscarCliente(int.Parse(txtDNIBuscar.Text));

            //SI EXISTE EL USUARIO
            if (aux.DNI>0)
            {
                clienteExist = 1;

                //Completo los campos del usuario existente
                txtNombre.Text = aux.Nombre;
                txtApellido.Text = aux.Apellido;
                txtDni.Text = aux.DNI.ToString();
                txtDireccion.Text = aux.Direccion;
                txtPisoPlanta.Text = aux.PisoPlanta;
                txtEmail.Text = aux.Email;
                txtTelefono.Text = aux.Telefono.ToString();
                txtCodPostal.Text = aux.CodPostal;
                txtLocalidad.Text = aux.Localidad;
                txtProvincia.Text = aux.Provincia;                

                //Si existe el cliente, desactivo los campos
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                txtDni.Enabled = false;
                txtDireccion.Enabled = false;
                txtPisoPlanta.Enabled = false;
                txtEmail.Enabled = false;
                txtTelefono.Enabled = false;
                txtCodPostal.Enabled = false;
                txtLocalidad.Enabled = false;
                txtProvincia.Enabled = false;
                dtpFechaNac.Enabled = false;

                //Activo los campos a completar

                cboMarca.Enabled = true;
                cboModelo.Enabled = true;
                cboVersion.Enabled = true;
                txtPatente.Enabled = true;
                cboCeroKm.Enabled = true;
                txtAnio.Enabled = true;
                cboGncGas.Enabled = true;
                cboFDePago.Enabled = true;
                txtCodDesc.Enabled = true;
                txtDetalle.Enabled = true;

                btnAgregarPresupuesto.Enabled = true;
                btnResetCampos.Enabled = true;

                

            }

            //SINO EXISTE
            else
            {
                clienteExist = 0;
                //CAMPO DNI CON EL INGRESADO EN CAMPO BUSQUEDA
                txtDni.Text = txtDNIBuscar.Text;
                //BLOQUEO EL CAMPO A MENOS QUE SE RESETEE EN  LA BUSQUEDA
                txtDni.Enabled = false;
                
              
                //Si NO existe el cliente, ACTIVO los campos
                txtNombre.Enabled = true;
                txtApellido.Enabled = true;
                //txtDni.Enabled = true;
                txtDireccion.Enabled = true;
                txtPisoPlanta.Enabled = true;
                txtEmail.Enabled = true;
                txtTelefono.Enabled = true;
                txtCodPostal.Enabled = true;
                txtLocalidad.Enabled = true;
                txtProvincia.Enabled = true;
                dtpFechaNac.Enabled = true;

                //COMPLETO el DNI con el ingresado
                //txtDni.Text = txtDNIBuscar.Text;

                //DESACTIVO EL CAMPO
                //txtDni.Enabled = false;

                //Activo los campos a completar
                cboMarca.Enabled = true;
                cboModelo.Enabled = true;
                cboVersion.Enabled = true;
                txtPatente.Enabled = true;
                cboCeroKm.Enabled = true;
                txtAnio.Enabled = true;
                cboGncGas.Enabled = true;
                cboFDePago.Enabled = true;
                txtCodDesc.Enabled = true;
                txtDetalle.Enabled = true;

                btnAgregarPresupuesto.Enabled = true;
                btnResetCampos.Enabled = true;
            }
            


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resetearCampos();
        }

        private void cboModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModelo.SelectedIndex > -1)
            {
                Modelo modelo = (Modelo)cboModelo.SelectedItem;

                //COMPLETO LOS MODELOS CON EL ID DE LA MARCA
                cboVersion.DataSource = CV.listarPorId(modelo.Id.ToString());
                cboVersion.DisplayMember = "Nombre";
                cboVersion.ValueMember = "id";
            }
        }

        private void cboCeroKm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
           
        }

        private void cboCeroKm_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SI EL AUTO ES 0KM
            if (cboCeroKm.SelectedIndex == 0)
            {
                txtAnio.Enabled = false;
                txtAnio.Text = DateTime.Today.Year.ToString();
            }
            else
            {
                txtAnio.Enabled = true;
                txtAnio.Text = "";
            }

        }

        private void btnResetCampos_Click(object sender, EventArgs e)
        {
            resetearCampos();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
