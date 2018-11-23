using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ConsultModelo
    {
        public IList<Modelo> listar()
        {

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            IList<Modelo> lista = new List<Modelo>();
            Modelo aux;

            try
            {
                conexion.ConnectionString = @"initial catalog=autos2; data source=DIEGO-HOME\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                //comando.CommandText = "SELECT * FROM modelo";
                comando.CommandText = "select modelo.name, marca.name, modelo.id as idmodelo,marca.id from modelo inner join marca on marca.id=modelo.marca_id where modelo.estado=1";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {                            
                                             
                    aux = new Modelo();
                    aux.Nombre = lector.GetString(0);
                    aux.NombreMarca = lector.GetString(1);
                    aux.Id = (int)lector["idmodelo"];
                    aux.IdMarca = (int)lector["Id"];                    
                    //aux.Estado = (int)lector["estado"];

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

        public IList<Modelo> listarPorId(string IdMarca)
        {
            SqlDataReader lector;
            Modelo aux;
            IList<Modelo> lista = new List<Modelo>();

            AccesoDatos conexion = null;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("select * from modelo where marca_id=@IdMarca and estado=1");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@IdMarca", IdMarca);

                conexion.abrirConexion();
                conexion.ejecutarAccion();

                lector = conexion.Comando.ExecuteReader();

                while (lector.Read())
                {
                    aux = new Modelo();
                    aux.Nombre = lector.GetString(1);
                    aux.Id = (int)lector["id"];
                    //aux.IdMarca = (int)lector["marca_id"];
                    //aux.Estado = (int)lector["estado"];

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


        ///ALTA MODELO
        public void altaModelo(Modelo nuevo, string IdMarca)
        {
            AccesoDatos conexion = null;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("insert into modelo (name, marca_id,estado,vDP) values (@nombreMarca,@IdMarca, 1,1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombreMarca", nuevo.Nombre);
                conexion.Comando.Parameters.AddWithValue("@IdMarca", IdMarca);

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

        ///MODIFICAR MODELO
        public void modificarModelo (Modelo modelo, string idModelo,string idMarca)
        {
            AccesoDatos conexion;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("update modelo set name = @name, marca_id = @idMarca Where id = @idModelo");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@name", modelo.Nombre);
                conexion.Comando.Parameters.AddWithValue("@idModelo", idModelo);
                conexion.Comando.Parameters.AddWithValue("@idMarca", idMarca);

                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //ELIMINAR L
        public void eliminarL(Modelo modelo, string IdModelo,string IdMarca)
        {
            AccesoDatos conexion;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("update modelo set estado = 0 Where id =@IdModelo");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@IdModelo", IdModelo);
                conexion.abrirConexion();
                conexion.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        ///ELIMINAR F
        public void eliminarF(Modelo modelo, string id)
        {
            AccesoDatos conexion;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("delete from modelo Where id =@id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", id);
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
