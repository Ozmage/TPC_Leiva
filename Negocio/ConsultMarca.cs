using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ConsultMarca
    {
        public IList<Marca> listar()
        {
            
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;
        IList<Marca> lista = new List<Marca>();
        Marca aux;

            try
            {
                conexion.ConnectionString = @"initial catalog=autos2; data source=DIEGO-HOME\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM marca where estado=1";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {    
                    //INSTANCIO AUX CON MARCA
                    aux = new Marca();
                    //CONSTRUYO GRILLA CON EL LECTOR 
                    aux.Nombre = lector.GetString(1);
                    aux.Id = (int)lector["id"];
                    aux.Estado = (int)lector["estado"];

                    lista.Add(aux);                              
                }                                                

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally {
                lector = null;
                conexion.Close();
            }
            
        }


        ///ALTA MARCA
        public void altaMarca(Marca nuevo)
        {
            AccesoDatos conexion = null;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("insert into marca (name, estado) values (@nombreMarca, 1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombreMarca",nuevo.Nombre);

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

        ///MODIFICAR MARCA
        public void modificar(string marca, string id)
        {
            AccesoDatos conexion;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("update marca set name = @name Where id = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@name", marca);
                conexion.Comando.Parameters.AddWithValue("@id", id);

                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ///ELIMINAR L
        public void eliminarL(Marca marca,string id)
        {
            AccesoDatos conexion;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("update marca set estado = 0 Where id =@id");
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

        ///ELIMINAR F
        public void eliminarF(Marca marca, string id)
        {
            AccesoDatos conexion;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("delete from marca Where id =@id");
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



        //BUSCAR SI EXISTE ID
        public int buscarSiExisteId(string id)
        {
            AccesoDatos conexion = null;
            SqlDataReader lector;

            try
            {
                conexion = new AccesoDatos();

                conexion.setearConsulta("select id from marca where id=@id and estado=1");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", id);
                

                conexion.abrirConexion();
                conexion.ejecutarAccion();

                lector = conexion.Comando.ExecuteReader();

                while (lector.Read())
                {

                    return 1;
                }

                return 0;

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