using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;
using System.Data.SqlClient;

namespace Negocio
{
    public class Busqueda
    {
        public string idAux;

        ///BUSCAR MARCA
        public string buscarId(string tabla, string valor)
        {
            AccesoDatos conexion;
            SqlDataReader lector;
            
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("select id from @tabla where name =@valor");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@tabla", tabla);
                conexion.Comando.Parameters.AddWithValue("@valor", valor);
                conexion.abrirConexion();
                conexion.ejecutarAccion();
                lector = conexion.Comando.ExecuteReader();


                while (lector.Read())
                {                    
                    idAux=lector.GetString(1);
                    return idAux;

                }
                return idAux;
            }

            catch (Exception ex)
            {

                throw ex;
                
            }
            
        }

        ///BUSCAR ULTIMO ID
        public int buscarUltimoIdCliente()
        {
            AccesoDatos conexion = null;
            SqlDataReader lector;

            int resultado;
            try
            {
                conexion = new AccesoDatos();
                //conexion.setearConsulta("select top 1 @columna from @tabla");
                conexion.setearConsulta("select top 1 idcliente from clientes order by idcliente desc");
                //conexion.Comando.Parameters.AddWithValue("@columna", columna);
                //conexion.Comando.Parameters.AddWithValue("@tabla", tabla);
                conexion.Comando.Parameters.Clear();
                

                conexion.abrirConexion();
                conexion.ejecutarAccion();

                lector = conexion.Comando.ExecuteReader();

                while (lector.Read())
                {
                    resultado = (int)lector["idcliente"];

                    return resultado;
                }
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
            return 0;
        }


        ///BUSCAR CLIENTE X DNI
        public Cliente buscarCliente(int dni)
        {
            AccesoDatos conexion = null;
            SqlDataReader lector;
            Cliente aux = new Cliente();

            
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("select * from clientes where dni=@dni");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@dni", dni);

                conexion.abrirConexion();
                conexion.ejecutarAccion();

                lector = conexion.Comando.ExecuteReader();

                while (lector.Read())
                {
                    
                    //INSTANCIO AUX CON MARCA
                    
                    //CONSTRUYO GRILLA CON EL LECTOR 
                    
                    aux.IdCliente = (int)lector["idCliente"];
                    aux.DNI = (int)lector["dni"];
                    aux.Nombre = lector.GetString(2);
                    aux.Apellido = lector.GetString(3);
                    aux.Direccion = lector.GetString(4);
                    aux.PisoPlanta = lector.GetString(5);
                    aux.Email = lector.GetString(6);
                    aux.Telefono = (int)lector["telefono"];
                    aux.CodPostal = lector.GetString(8);
                    aux.Localidad = lector.GetString(9);
                    aux.Provincia = lector.GetString(10);
                    aux.FechaDeNacimiento = (DateTime)lector["fechanacimiento"];
                    
                    return aux;
                }
                
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
            return aux;
        }




        ///LOGIN CHECK
        public int loginCheck(string usuario,string contra)
        {
            AccesoDatos conexion = null;
            SqlDataReader lector;

            int nivel = 0;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("select nivel from usuarios where username=@usuario and password=@contra");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@usuario", usuario);
                conexion.Comando.Parameters.AddWithValue("@contra", contra);          


                conexion.abrirConexion();
                conexion.ejecutarAccion();

                lector = conexion.Comando.ExecuteReader();

                while (lector.Read())
                {
                    nivel = (int)lector["nivel"];
                    return nivel;
                }
                nivel = 0;
                return nivel;

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

        //BUSCAR ULTIMO PRESUPUESTO
        public int buscarUltimoPresupuesto()
        {
            AccesoDatos conexion = null;
            SqlDataReader lector;

            int resultado;
            try
            {
                conexion = new AccesoDatos();                
                conexion.setearConsulta("select top 1 idpresupuesto from presupuestos order by idpresupuesto desc");                
                conexion.Comando.Parameters.Clear();

                conexion.abrirConexion();
                conexion.ejecutarAccion();

                lector = conexion.Comando.ExecuteReader();

                while (lector.Read())
                {
                    resultado = (int)lector["idpresupuesto"];

                    return resultado;
                }
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
            return 0;
        }

        //BUSCAR ULTIMO PRESUPUESTO
        public int buscarIdCLientePresupuesto(string idPresupuesto)
        {
            AccesoDatos conexion = null;
            SqlDataReader lector;

            int resultado;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("select idcliente from presupuestos where idpresupuesto=@idPresupuesto");
                conexion.Comando.Parameters.Clear();

                conexion.abrirConexion();
                conexion.ejecutarAccion();

                lector = conexion.Comando.ExecuteReader();

                while (lector.Read())
                {
                    resultado = (int)lector["idcliente"];

                    return resultado;
                }
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
            return 0;
        }




        //BUSCAR IDS DE AUTO
        public Auto buscarIds(Auto auto)
        {
            AccesoDatos conexion = null;
            SqlDataReader lector;
            Auto aux = new Auto();
            
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("select * from version where name=@nombreversion");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombreversion", auto.NombreVersion);

                conexion.abrirConexion();
                conexion.ejecutarAccion();

                lector = conexion.Comando.ExecuteReader();

                while (lector.Read())
                {
                    aux.IdVersion= (int)lector["id"];
                    aux.NombreVersion = lector.GetString(1);
                    aux.IdModelo = (int)lector["modelo_id"];
                    aux.IdMarca = (int)lector["marca_id"];

                    return aux;

                }
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
            return aux;
        }





    }
}
