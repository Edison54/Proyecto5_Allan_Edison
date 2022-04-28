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
    public class BLProfesor
    {

        //Variables necesarias en la capa de negocio
        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje
        {
            get => _mensaje;
        }

        //Creamos la cadena de conexion
        public BLProfesor(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //Es donde se llaman el metodo para insertar datos 
        public int Insertar(EntidadProfesor profesor)
        {
            int idProf = 0;
            DAProfesor accesoDatos = new DAProfesor(_cadenaConexion);
            try
            {
                idProf = accesoDatos.Insertar(profesor);
            }
            catch (Exception)
            {
                throw;
            }

            return idProf;

        }

        //Llamamos a los datos por medio del DataSet
        public DataSet ListarProfesores(string condicion, string orden = "")
        {
            DataSet DS;
            DAProfesor accesoDatos = new DAProfesor(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarProfesores(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return DS;
        }

        //Eliminamos un registro por el llamado de un procedimiento 
        public int Eliminar(EntidadProfesor profesor)
        {
            int resultado;
            DAProfesor accesoDatos = new DAProfesor(_cadenaConexion);
            try
            {
                resultado = accesoDatos.EliminarRegistro(profesor);
                _mensaje = accesoDatos.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        //Pedimos los datos de un solo registro
        public EntidadProfesor ObtenerProfesor(int id)
        {
            EntidadProfesor profesor;
            DAProfesor accesoDatos = new DAProfesor(_cadenaConexion);
            try
            {
                profesor = accesoDatos.ObtenerProfesor(id);
            }
            catch (Exception)
            {
                throw;
            }
            return profesor;
        }

        //Modificamos los datos del registro
        public int Modificar(EntidadProfesor profesor)
        {
            int filasAfectadas = 0;
            DAProfesor accesoDatos = new DAProfesor(_cadenaConexion);
            try
            {
                filasAfectadas = accesoDatos.Modificar(profesor);
            }
            catch (Exception)
            {
                throw;
            }
            return filasAfectadas;
        }
    }
}
