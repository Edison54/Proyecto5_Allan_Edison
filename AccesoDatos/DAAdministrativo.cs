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
    public class DAAdministrativo
    {
        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje
        {
            get => _mensaje;
        }

        public DAAdministrativo(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int Insertar(EntidadAdministrativo administrativo)
        {
            int id = 0;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            string sentencia = "insert into administrativo(id_programa, nombre, correo, direccion, telefono, cargo, departamento) " +
                "values (@id_programa, @nombre, @correo, @direccion, @telefono, @cargo, @departamento) select @@IDENTITY";
            comando.Parameters.AddWithValue("@id_programa", administrativo.IdPrograma);
            comando.Parameters.AddWithValue("@nombre", administrativo.Nombre);
            comando.Parameters.AddWithValue("@correo", administrativo.Correo);
            comando.Parameters.AddWithValue("@direccion", administrativo.Direccion);
            comando.Parameters.AddWithValue("@telefono", administrativo.Telefono);
            comando.Parameters.AddWithValue("@cargo", administrativo.Cargo);
            comando.Parameters.AddWithValue("@departamento", administrativo.Departamento);
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

        public DataSet ListarAdministrativos(string condicion)
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "select id_admin, id_programa, nombre, correo, " +
                "direccion, telefono, cargo, departamento from administrativo";
            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }

            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);
                adapter.Fill(datos, "Administrativo");
            }
            catch (Exception)
            {
                throw;
            }
            return datos;
        }

        public int EliminarRegistroConSP(EntidadAdministrativo administrativo)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "ELIMINARADMIN";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@idadmin", administrativo.IdAdmin);
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

        public EntidadAdministrativo ObtenerAdmin(int id)
        {
            EntidadAdministrativo administrativo = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;
            string sentencia = string.Format("select id_admin, id_programa, nombre, correo, " +
                "direccion, telefono, cargo, departamento from administrativo where id_admin = {0}", id);
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    administrativo = new EntidadAdministrativo();
                    dataReader.Read();
                    administrativo.IdAdmin = dataReader.GetInt32(0);
                    administrativo.IdPrograma = dataReader.GetInt32(1);
                    administrativo.Nombre = dataReader.GetString(2);
                    administrativo.Correo = dataReader.GetString(3);
                    administrativo.Direccion = dataReader.GetString(4);
                    administrativo.Telefono = dataReader.GetInt32(5);
                    administrativo.Cargo = dataReader.GetString(6);
                    administrativo.Departamento = dataReader.GetString(7);
                }
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return administrativo;
        }

        public int Modificar(EntidadAdministrativo administrativo)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "update administrativo set id_programa = @id_programa, nombre = @nombre, " +
                "correo = @correo, direccion = @direccion, telefono = @telefono, cargo = @cargo, departamento = @departamento " +
                "where id_admin = @id_admin";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@id_admin", administrativo.IdAdmin);
            comando.Parameters.AddWithValue("@id_programa", administrativo.IdPrograma);
            comando.Parameters.AddWithValue("@nombre", administrativo.Nombre);
            comando.Parameters.AddWithValue("@correo", administrativo.Correo);
            comando.Parameters.AddWithValue("@direccion", administrativo.Direccion);
            comando.Parameters.AddWithValue("@telefono", administrativo.Telefono);
            comando.Parameters.AddWithValue("@cargo", administrativo.Cargo);
            comando.Parameters.AddWithValue("@departamento", administrativo.Departamento);
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
