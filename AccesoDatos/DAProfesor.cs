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
    public class DAProfesor
    {
        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje
        {
            get => _mensaje;
        }

        public DAProfesor(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int Insertar(EntidadProfesor profesor)
        {
            int id = 0;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            string sentencia = "insert into profesor(cedula, nombre, correo, direccion, telefono, sueldo, idioma) " +
                "values (@cedula, @nombre, @correo, @direccion, @telefono, @sueldo, @idioma) select @@IDENTITY";
            comando.Parameters.AddWithValue("@cedula", profesor.Cedula);
            comando.Parameters.AddWithValue("@nombre", profesor.Nombre);
            comando.Parameters.AddWithValue("@correo", profesor.Correo);
            comando.Parameters.AddWithValue("@direccion", profesor.Direccion);
            comando.Parameters.AddWithValue("@telefono", profesor.Telefono);
            comando.Parameters.AddWithValue("@sueldo", profesor.Sueldo);
            comando.Parameters.AddWithValue("@idioma", profesor.Idioma);
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

        public DataSet ListarProfesores(string condicion)
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "select id_profesor, cedula, nombre, correo, " +
                "direccion, telefono, sueldo, idioma from profesor";
            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }

            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);
                adapter.Fill(datos, "Profesor");
            }
            catch (Exception)
            {
                throw;
            }
            return datos;
        }

        public int EliminarRegistro(EntidadProfesor profesor)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "ELIMINARPROF";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@idprof", profesor.IdProfesor);
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

        public EntidadProfesor ObtenerProfesor(int id)
        {
            EntidadProfesor profesor = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;
            string sentencia = string.Format("select id_profesor, cedula, nombre, correo, " +
                "direccion, telefono, sueldo, idioma from profesor where id_profesor = {0}", id);
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    profesor = new EntidadProfesor();
                    dataReader.Read();
                    profesor.IdProfesor = dataReader.GetInt32(0);
                    profesor.Cedula = dataReader.GetString(1);
                    profesor.Nombre = dataReader.GetString(2);
                    profesor.Correo = dataReader.GetString(3);
                    profesor.Direccion = dataReader.GetString(4);
                    profesor.Telefono = dataReader.GetInt32(5);
                    profesor.Sueldo = dataReader.GetInt32(6);
                    profesor.Idioma = dataReader.GetString(7);
                }
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return profesor;
        }

        public int Modificar(EntidadProfesor profesor)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "update profesor set cedula = @cedula, nombre = @nombre, " +
                "correo = @correo, direccion = @direccion, telefono = @telefono, sueldo = @sueldo, " +
                "idioma = @idioma where id_profesor = @id_profesor";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@id_profesor", profesor.IdProfesor);
            comando.Parameters.AddWithValue("@cedula", profesor.Cedula);
            comando.Parameters.AddWithValue("@nombre", profesor.Nombre);
            comando.Parameters.AddWithValue("@correo", profesor.Correo);
            comando.Parameters.AddWithValue("@direccion", profesor.Direccion);
            comando.Parameters.AddWithValue("@telefono", profesor.Telefono);
            comando.Parameters.AddWithValue("@sueldo", profesor.Sueldo);
            comando.Parameters.AddWithValue("@idioma", profesor.Idioma);

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
