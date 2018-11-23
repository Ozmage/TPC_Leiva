using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ConsultVersiones
    {

        public IList<Dominio.VersionA> listar()
        {

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Dominio.VersionA> lista = new List<Dominio.VersionA>();
            Dominio.VersionA aux;

            try
            {
                conexion.ConnectionString = @"initial catalog=autos2; data source=DIEGO-HOME\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select v.name as version ,mo.name as modelo,ma.name as marca from version as v inner join modelo as mo on v.modelo_id=mo.id inner join marca as ma on mo.marca_id=ma.id where v.estado=1 and mo.estado=1 and ma.estado=1";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                
                while (lector.Read())
                {
                    //INSTANCIO Y COMPLETO
                    aux = new Dominio.VersionA();
                    aux.Nombre = lector.GetString(0);
                    aux.NombreModelo = lector.GetString(1);
                    aux.NombreMarca = lector.GetString(2);



                    //GUARDO LO LEIDO
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





        ////SELECCIONAR POR ID

        public IList<VersionA> listarPorId(string IdModelo)
        {
            SqlDataReader lector;
            VersionA aux;
            IList<VersionA> lista = new List<VersionA>();

            AccesoDatos conexion = null;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("select * from version where modelo_id=@IdModelo and estado=1");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@IdModelo", IdModelo);

                conexion.abrirConexion();
                conexion.ejecutarAccion();

                lector = conexion.Comando.ExecuteReader();

                while (lector.Read())
                {
                    aux = new VersionA();
                    aux.Nombre = lector.GetString(1);
                    aux.Id = (int)lector["id"];
                    //aux.IdMarca = (int)lector["marca_id"];
                    aux.Estado = (int)lector["estado"];

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
                if (conexion != null)
                    conexion.cerrarConexion();
            }

        }






        ///ALTA VERSION
        public void altaVersion(VersionA nuevo, string IdMarca, string IdModelo)
        {
            AccesoDatos conexion = null;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("insert into version (name, marca_id,modelo_id,estado) values (@nombreMarca,@IdMarca, @IdModelo,1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombreMarca", nuevo.Nombre);
                conexion.Comando.Parameters.AddWithValue("@IdMarca", IdMarca);
                conexion.Comando.Parameters.AddWithValue("@idModelo", IdModelo);

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


        ///MODIFICAR VERSION
        public void modificarVersion(Auto auto, string nombreVersionNueva)
        {
            AccesoDatos conexion;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("update version set name = @name, marca_id = @idMarca, modelo_id=@idModelo Where id = @idVersion");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@name", nombreVersionNueva);
                conexion.Comando.Parameters.AddWithValue("@idModelo", auto.IdModelo);
                conexion.Comando.Parameters.AddWithValue("@idMarca", auto.IdMarca);
                conexion.Comando.Parameters.AddWithValue("@idVersion", auto.IdVersion);

                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        //ELIMINAR L
        public void eliminarL(Auto auto)
        {
            AccesoDatos conexion;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("update version set estado = 0 Where id =@IdVersion");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@IdVersion", auto.IdVersion);
                conexion.abrirConexion();
                conexion.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        ///ELIMINAR F
        public void eliminarF(Auto auto)
        {
            AccesoDatos conexion;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("delete from version Where id =@IdVersion");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@IdVersion", auto.IdVersion);
                conexion.abrirConexion();
                conexion.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
