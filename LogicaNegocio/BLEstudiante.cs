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
    public class BLEstudiante
    {

        //Variables necesarias en la capa de negocio
        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje
        {
            get => _mensaje;
        }

        //Creamos la cadena de conexion
        public BLEstudiante(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //Es donde se llaman el metodo para insertar datos
        public int Insertar(EntidadEstudiante estudiante)
        {
            int idEstudiante = 0;
            DAEstudiante accesoDatos = new DAEstudiante(_cadenaConexion);
            try
            {
                idEstudiante = accesoDatos.Insertar(estudiante);
            }
            catch (Exception)
            {
                throw;
            }

            return idEstudiante;

        }

        //Llamamos a los datos por medio del DataSet
        public DataSet ListarEstudiantes(string condicion, string orden = "")
        {
            DataSet DS;
            DAEstudiante accesoDatos = new DAEstudiante(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarEstudiantes(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return DS;
        }

        //Eliminamos un registro por el llamado de un procedimiento 
        public int EliminarConSP(EntidadEstudiante estudiante)
        {
            int resultado;
            DAEstudiante accesoDatos = new DAEstudiante(_cadenaConexion);
            try
            {
                resultado = accesoDatos.EliminarRegistroConSP(estudiante);
                _mensaje = accesoDatos.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        //Pedimos los datos de un solo registro
        public EntidadEstudiante ObtenerEstudiante(int id)
        {
            EntidadEstudiante estudiante;
            DAEstudiante accesoDatos = new DAEstudiante(_cadenaConexion);
            try
            {
                estudiante = accesoDatos.ObtenerEstudiante(id);
            }
            catch (Exception)
            {
                throw;
            }
            return estudiante;
        }

        //Modificamos los datos del registro
        public int Modificar(EntidadEstudiante estudiante)
        {
            int filasAfectadas = 0;
            DAEstudiante accesoDatos = new DAEstudiante(_cadenaConexion);
            try
            {
                filasAfectadas = accesoDatos.Modificar(estudiante);
            }
            catch (Exception)
            {
                throw;
            }
            return filasAfectadas;
        }
    }
}
