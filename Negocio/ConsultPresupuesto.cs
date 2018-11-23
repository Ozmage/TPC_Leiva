using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class ConsultPresupuesto
    {
        public IList<Presupuesto> listar()
        {

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Presupuesto> lista = new List<Presupuesto>();
            Presupuesto aux;

            try
            {
                conexion.ConnectionString = @"initial catalog=autos2; data source=DIEGO-HOME\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select p.idpresupuesto, c.idcliente, c.nombre,c.apellido, c.dni,p.fechapresupuesto from presupuestos as p inner join clientes as c on c.idcliente=p.idcliente where p.estado=1 and c.estado=1";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    //INSTANCIO AUX CON MARCA
                    aux = new Presupuesto();
                    //CONSTRUYO GRILLA CON EL LECTOR 
                   

                    aux.IdPresupuesto = (int)lector["idPresupuesto"];
                    aux.IdCliente = (int)lector["idCliente"];
                    aux.Nombre = lector.GetString(2);
                    aux.Apellido = lector.GetString(3);
                    aux.DNI = (int)lector["dni"];
                    aux.FechaPresupuesto = (DateTime)lector["fechaPresupuesto"];
                    

                    lista.Add(aux);
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

        ///ALTA PRESUPUESTO
        public void altaPresupuesto(Presupuesto Presu, int idcliente)
        {
            AccesoDatos conexion = null;
            try
            {
                                
                conexion = new AccesoDatos();
                conexion.setearConsulta("insert into presupuestos (idcliente,marca_id,modelo_id,version_id,fechaPresupuesto,fechaVencimiento,patente,cerokm,anio,gncgas,formadepago,detalle,coddescuento,estado) values (@idcliente,@marcaid,@modeloid,@versionid,@fechaPresupuesto,@fechaVencimiento,@patente,@cerokm,@anio,@gncgas,@formadepago,@detalle,@coddescuento,1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idcliente", idcliente);
                conexion.Comando.Parameters.AddWithValue("@cerokm", Presu.CeroKm);
                conexion.Comando.Parameters.AddWithValue("@patente", Presu.Patente);
                conexion.Comando.Parameters.AddWithValue("@anio", Presu.Anio);
                conexion.Comando.Parameters.AddWithValue("@gncgas", Presu.GncGas);
                conexion.Comando.Parameters.AddWithValue("@formadepago", Presu.FormaDePago);
                conexion.Comando.Parameters.AddWithValue("@detalle", Presu.Detalle);
                conexion.Comando.Parameters.AddWithValue("@coddescuento", Presu.CodDesc);
                conexion.Comando.Parameters.AddWithValue("@marcaid", Presu.IdMarca);
                conexion.Comando.Parameters.AddWithValue("@modeloid", Presu.IdModelo);
                conexion.Comando.Parameters.AddWithValue("@versionid", Presu.IdVersion);
                conexion.Comando.Parameters.AddWithValue("@fechaVencimiento", Presu.FechaVencimiento);
                conexion.Comando.Parameters.AddWithValue("@fechaPresupuesto", Presu.FechaPresupuesto);
                


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



        public IList<Presupuesto> listadoAVencer()
        {

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Presupuesto> lista = new List<Presupuesto>();
            Presupuesto aux;

            try
            {
                conexion.ConnectionString = @"initial catalog=autos2; data source=DIEGO-HOME\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT fechapresupuesto, p.idPresupuesto, p.fechaVencimiento, c.email,c.telefono, nombre,c.apellido from Presupuestos as p inner join clientes as c on p.idcliente=c.idcliente WHERE fechavencimiento >= getdate() AND fechavencimiento <= DATEADD(dd, 5, GETDATE())";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    //INSTANCIO AUX CON MARCA
                    aux = new Presupuesto();
                    //CONSTRUYO GRILLA CON EL LECTOR 

                    aux.FechaPresupuesto = (DateTime)lector["fechapresupuesto"];
                    aux.IdPresupuesto = (int)lector["idPresupuesto"];
                    aux.FechaVencimiento = (DateTime)lector["fechavencimiento"];
                    aux.Email = lector.GetString(3);
                    aux.Telefono = (int)lector["telefono"];
                    aux.Nombre = lector.GetString(5);
                    aux.Apellido = lector.GetString(6);
                    


                    lista.Add(aux);
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





    }
}
