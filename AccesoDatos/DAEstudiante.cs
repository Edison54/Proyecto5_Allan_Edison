using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class DAEstudiante
    {
        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje
        {
            get => _mensaje;
        }

        public DAEstudiante(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int Insertar(EntidadEstudiante estudiante)
        {
            int id = 0;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            string sentencia = "insert into estudiante(cedula, nombre, correo, direccion, telefono) " +
                "values (@cedula, @nombre, @correo, @direccion, @telefono) select @@IDENTITY";
            comando.Parameters.AddWithValue("@cedula", estudiante.Cedula);
            comando.Parameters.AddWithValue("@nombre", estudiante.Nombre);
            comando.Parameters.AddWithValue("@correo", estudiante.Correo);
            comando.Parameters.AddWithValue("@direccion", estudiante.Direccion);
            comando.Parameters.AddWithValue("@telefono", estudiante.Telefono);
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                id = Convert.ToInt32(comando.ExecuteScalar());
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return id;
        }

        public DataSet ListarEstudiantes(string condicion)
        {
            DataSet datos = new DataSet(); 
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "select id_estudiante, cedula, nombre, correo, " +
                "direccion, telefono from estudiante";
            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }

            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion); 
                adapter.Fill(datos, "Estudiante");
            }
            catch (Exception)
            {
                throw;
            }
            return datos;
        }

        public int EliminarRegistroConSP(EntidadEstudiante estudiante)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "ELIMINARESTUDIANTE";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@idestudiante", estudiante.IdEstudiante);
            comando.Parameters.Add("@msj", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
            comando.Parameters.Add("@retorno", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); 
                resultado = Convert.ToInt32(comando.Parameters["@retorno"].Value);
                _mensaje = comando.Parameters["@msj"].Value.ToString();
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public EntidadEstudiante ObtenerEstudiante(int id)
        {
            EntidadEstudiante estudiante = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;
            string sentencia = string.Format("select id_estudiante, cedula, nombre, correo, " +
                "direccion, telefono from estudiante where id_estudiante = {0}", id);
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    estudiante = new EntidadEstudiante();
                    dataReader.Read();
                    estudiante.IdEstudiante = dataReader.GetInt32(0);
                    estudiante.Cedula = dataReader.GetString(1);
                    estudiante.Nombre = dataReader.GetString(2);
                    estudiante.Correo = dataReader.GetString(3);
                    estudiante.Direccion = dataReader.GetString(4);
                    estudiante.Telefono = dataReader.GetInt32(5);
                }
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return estudiante;
        }

        public int Modificar(EntidadEstudiante estudiante)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "update estudiante set cedula = @cedula, nombre = @nombre, " +
                "correo = @correo, direccion = @direccion, telefono = @telefono where id_estudiante = @id_estudiante";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@id_estudiante", estudiante.IdEstudiante);
            comando.Parameters.AddWithValue("@cedula", estudiante.Cedula);
            comando.Parameters.AddWithValue("@nombre", estudiante.Nombre);
            comando.Parameters.AddWithValue("@correo", estudiante.Correo);
            comando.Parameters.AddWithValue("@direccion", estudiante.Direccion);
            comando.Parameters.AddWithValue("@telefono", estudiante.Telefono);
            try
            {
                conexion.Open();
                filasAfectadas = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return filasAfectadas;
        }
    }
}
