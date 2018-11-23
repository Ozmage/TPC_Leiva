using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class MarcaNegocio
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
                conexion.ConnectionString = @"initial catalog=autos; data source=DIEGO-HOME\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM marca";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {                            //LUEGO DE LA CONEXION HAY QUE HACER EL WHILE PARA
                                             //IR LEYENDO LOS DATOS DE LA TABLA
                    aux = new Modelo();
                    aux.Name = lector.GetString(1);
                    aux.Id = (int)lector["Id"];

                    lista.Add(aux);                              //POR ULTIMO AGREGAR SIEMPRE EL .ADD(AUX) PARA QUE LO QUE SE LEYO
                }                                                //LO GUARDE EN LA LISTA Y LO MUESTRE POR PANTALLA.

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
