using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class BLMatricula
    {

        //Variables necesarias en la capa de negocio
        private string _cadenaConexion;
        private string _mensaje;

        //Creamos la cadena de conexion
        public BLMatricula(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //Es donde se llaman el metodo para insertar datos 
        public int Insertar(EntidadMatricula matricula)
        {
            int idMatricula;
            DAMatricula accesoDatos = new DAMatricula(_cadenaConexion);
            try
            {
                idMatricula = accesoDatos.InsertarMatricula(matricula);
            }
            catch (Exception)
            {
                throw;
            }

            return idMatricula;

        }

        //Llamamos a los datos por medio del DataSet
        public DataSet ListarMatriculas(string condicion, string orden = "")
        {
            DataSet DS;
            DAMatricula accesoDatos = new DAMatricula(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarMatriculas(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return DS;
        }

        //Pedimos los datos de un solo registro
        public EntidadMatricula ObtenerMatricula(int id)
        {
            EntidadMatricula matricula;
            DAMatricula accesoDatos = new DAMatricula(_cadenaConexion);
            try
            {
                matricula = accesoDatos.ObtenerMatricula(id);
            }
            catch (Exception)
            {
                throw;
            }
            return matricula;
        }

        //Modificamos los datos del registro
        public int Modificar(EntidadMatricula matricula)
        {
            int filasAfectadas = 0;
            DAMatricula accesoDatos = new DAMatricula(_cadenaConexion);
            try
            {
                filasAfectadas = accesoDatos.Modificar(matricula);
            }
            catch (Exception)
            {
                throw;
            }
            return filasAfectadas;
        }
    }
}
