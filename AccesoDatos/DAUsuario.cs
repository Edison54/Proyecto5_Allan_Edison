using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class DAUsuario
    {
        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje
        {
            get => _mensaje;
        }

        public DAUsuario(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public EntidadUsuario ObtenerUser(String userName, String contrasennia)
        {
            EntidadUsuario usuario = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;
            string sentencia = string.Format("select id_user, nombre_user, contrasennia from usuario where nombre_user = '{0}' and contrasennia = '{1}'", userName, contrasennia);
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    usuario = new EntidadUsuario();
                    dataReader.Read();
                    usuario.IDUsuario = dataReader.GetInt32(0);
                    usuario.Nombre = dataReader.GetString(1);
                    usuario.contrasennia = dataReader.GetString(2);
                   
                }
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return usuario;
        }
    }
}
