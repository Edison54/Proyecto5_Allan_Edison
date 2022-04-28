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
    public class DAMatricula
    {
        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje
        {
            get => _mensaje;
        }

        public DAMatricula(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public DataSet ListarMatriculas(string condicion)
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "select id_matricula, id_estudiante, id_curso_abierto, costo, " +
                "estado from matricula";
            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }

            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);
                adapter.Fill(datos, "Matricula");
            }
            catch (Exception)
            {
                throw;
            }
            return datos;
        }

        /*public int Insertar(EntidadMatricula matricula)
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
        }*/

        public int InsertarMatricula(EntidadMatricula matricula)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "CREARMATRICULA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@idestudiante", matricula.IdEstudiante);
            comando.Parameters.AddWithValue("@idcursoabierto", matricula.Id_curso_abierto);
            comando.Parameters.AddWithValue("@estado", matricula.Estado);

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

        public int EliminarRegistroConSP(EntidadMatricula matricula)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "ELIMINARESTUDIANTE";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@idestudiante", matricula.IdEstudiante);
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

        public EntidadMatricula ObtenerMatricula(int id)
        {
            EntidadMatricula matricula = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;
            string sentencia = string.Format("select id_matricula, id_estudiante, id_curso_abierto, costo, " +
                "estado from matricula where id_matricula = {0}", id);
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    matricula = new EntidadMatricula();
                    dataReader.Read();
                    matricula.IdMatricula = dataReader.GetInt32(0);
                    matricula.IdEstudiante = dataReader.GetInt32(1);
                    matricula.Id_curso_abierto = dataReader.GetInt32(2);
                    matricula.Costo = dataReader.GetInt32(3);
                    matricula.Estado = dataReader.GetString(4);
                }
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return matricula;
        }

        public int Modificar(EntidadMatricula matricula)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "update matricula set id_estudiante = @id_estudiante, " +
                "id_curso_abierto = @id_curso_abierto, costo = @costo, estado = @estado where id_matricula = @id_matricula";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@id_matricula", matricula.IdMatricula);
            comando.Parameters.AddWithValue("@id_estudiante", matricula.IdEstudiante);
            comando.Parameters.AddWithValue("@id_curso_abierto", matricula.Id_curso_abierto);
            comando.Parameters.AddWithValue("@costo", matricula.Costo);
            comando.Parameters.AddWithValue("@estado", matricula.Estado);

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
