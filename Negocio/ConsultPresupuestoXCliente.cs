using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ConsultPresupuestoXCliente
    {
        public IList<PresupuestoXCliente> listar()
        {

            SqlDataReader lector;
            IList<PresupuestoXCliente> lista = new List<PresupuestoXCliente>();
            PresupuestoXCliente aux;

            AccesoDatos conexion = null;

            try
            {
                conexion = new AccesoDatos();

                conexion.setearConsulta("select * from presupuestos_x_cliente where estado=1");
                conexion.Comando.Parameters.Clear();
                lector = conexion.Comando.ExecuteReader();

                while (lector.Read())
                {
                    //INSTANCIO AUX CON MARCA
                    aux = new PresupuestoXCliente();
                    //CONSTRUYO GRILLA CON EL LECTOR 
                    
                    aux.Id = (int)lector["id"];
                    aux.IdPresupuesto = (int)lector["id"];
                    aux.IdCliente = (int)lector["id"];
                    aux.Estado = (int)lector["id"];
                    
                    
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
                conexion.cerrarConexion();
            }

        }

        ///ALTA 
        public void altaPresupuestoXCliente (string IdCliente, string IdPresupuesto)
        {
            AccesoDatos conexion = null;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("insert into presupuestos_x_cliente (idcliente, idpresupuesto,estado) values (@IdCliente,@IdPresupuesto, 1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@IdCliente", IdCliente);
                conexion.Comando.Parameters.AddWithValue("@IdPresupuesto", IdPresupuesto);

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
