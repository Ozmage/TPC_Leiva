using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ConsultPersona
    {


        public IList<Cliente> listar()
        {

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Cliente> lista = new List<Cliente>();
            Cliente cliente;

            try
            {
                conexion.ConnectionString = @"initial catalog=autos2; data source=DIEGO-HOME\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM clientes where estado=1";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    //INSTANCIO AUX CON CLIENTE
                    cliente = new Cliente();
                    //cliente.Persona = new Persona();
                   

                    //CONSTRUYO GRILLA CON EL LECTOR 
                    cliente.IdCliente = (int)lector["idCliente"];
                    cliente.DNI = (int)lector["dni"];                    
                    cliente.Nombre = lector.GetString(2);
                    cliente.Apellido = lector.GetString(3);
                    cliente.Direccion = lector.GetString(4);
                    cliente.PisoPlanta = lector.GetString(5);
                    cliente.Email = lector.GetString(6);
                    cliente.Telefono = (int)lector["telefono"];
                    cliente.CodPostal = lector.GetString(8);
                    cliente.Localidad = lector.GetString(9);
                    cliente.Provincia = lector.GetString(10);
                    cliente.FechaDeNacimiento = (DateTime)lector["fechaNacimiento"];
                    cliente.EstadoPersona = (int)lector["estado"];


                    lista.Add(cliente);
                    
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                lector = null;
                conexion.Close();
            }

        }
                       


        ///ALTA PERSONA
        public void altaCliente(Presupuesto nuevo)
        {
            AccesoDatos conexion = null;
                       
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("insert into clientes (dni,nombre,apellido,direccion,pisoplanta,email,telefono,codpostal,localidad,provincia,fechanacimiento,estado) values (@dni,@nombre,@apellido,@direccion,@pisoplanta,@email,@telefono,@codpostal,@localidad,@provincia,@fechanacimiento, 1)");
                conexion.Comando.Parameters.Clear();
                //conexion.Comando.Parameters.AddWithValue("@idcliente", valor);
                conexion.Comando.Parameters.AddWithValue("@dni", nuevo.DNI);
                conexion.Comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
                conexion.Comando.Parameters.AddWithValue("@apellido", nuevo.Apellido);
                conexion.Comando.Parameters.AddWithValue("@direccion", nuevo.Direccion);
                conexion.Comando.Parameters.AddWithValue("@pisoplanta", nuevo.PisoPlanta);
                conexion.Comando.Parameters.AddWithValue("@email", nuevo.Email);
                conexion.Comando.Parameters.AddWithValue("@telefono", nuevo.Telefono);
                conexion.Comando.Parameters.AddWithValue("@codpostal", nuevo.CodPostal);
                conexion.Comando.Parameters.AddWithValue("@localidad", nuevo.Localidad);
                conexion.Comando.Parameters.AddWithValue("@provincia", nuevo.Provincia);
                conexion.Comando.Parameters.AddWithValue("@fechanacimiento", nuevo.FechaDeNacimiento);

                conexion.abrirConexion();
                conexion.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null)
                    conexion.cerrarConexion();
            }
        }












    }
}
