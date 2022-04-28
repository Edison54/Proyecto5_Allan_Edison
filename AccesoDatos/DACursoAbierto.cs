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
    public class DACursoAbierto
    {

        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje
        {
            get => _mensaje;
        }

        public DACursoAbierto(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int Insertar(EntidadCursoAbierto curso)
        {
            int id = 0;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            string sentencia = "insert into curso_abierto(id_curso, id_profesor, hora_inicio, hora_fin, dia) " +
                "values (@id_curso, @id_profesor, @hora_inicio, @hora_fin, @dia) select @@IDENTITY";
            comando.Parameters.AddWithValue("@id_curso", curso.IdCurso);
            comando.Parameters.AddWithValue("@id_profesor", curso.IdProfesor);
            comando.Parameters.AddWithValue("@hora_inicio", curso.HoraInicio);
            comando.Parameters.AddWithValue("@hora_fin", curso.HoraFin);
            comando.Parameters.AddWithValue("@dia", curso.Dia);
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

        public DataSet Listar(string condicion)
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "select id_curso_abierto, id_curso, id_profesor, " +
                "hora_inicio, hora_fin, dia from curso_abierto";
            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }

            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);
                adapter.Fill(datos, "curso_abierto");
            }
            catch (Exception)
            {
                throw;
            }
            return datos;
        }

        public int Eliminar(EntidadCursoAbierto curso)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "ELIMINARCURSOABIERTO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@idcursoabierto", curso.IdCursoAbierto);
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

        public EntidadCursoAbierto ObtenerCurso(int id)
        {
            EntidadCursoAbierto curso = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;
            string sentencia = string.Format("select id_curso_abierto, id_curso, id_profesor, " +
                "hora_inicio, hora_fin, dia  from curso_abierto where id_curso_abierto = {0}", id);
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    curso = new EntidadCursoAbierto();
                    dataReader.Read();
                    curso.IdCursoAbierto = dataReader.GetInt32(0);
                    curso.IdCurso = dataReader.GetInt32(1);
                    curso.IdProfesor = dataReader.GetInt32(2);
                    curso.HoraInicio = dataReader.GetInt32(3);
                    curso.HoraFin = dataReader.GetInt32(4);
                    curso.Dia = dataReader.GetString(5);
                }
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return curso;
        }

        public int Modificar(EntidadCursoAbierto curso)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "update curso_abierto set id_curso = @id_curso, id_profesor = @id_profesor, " +
                "hora_inicio = @hora_inicio, hora_fin = @hora_fin, dia = @dia where id_curso_abierto = @id_curso_abierto";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@id_curso_abierto", curso.IdCursoAbierto);
            comando.Parameters.AddWithValue("@id_curso", curso.IdCurso);
            comando.Parameters.AddWithValue("@id_profesor", curso.IdProfesor);
            comando.Parameters.AddWithValue("@hora_inicio", curso.HoraInicio);
            comando.Parameters.AddWithValue("@hora_fin", curso.HoraFin);
            comando.Parameters.AddWithValue("@dia", curso.Dia);

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
