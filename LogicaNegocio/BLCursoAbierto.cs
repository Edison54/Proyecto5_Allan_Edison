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
    public class BLCursoAbierto
    {
        //Variables necesarias en la capa de negocio
        private string _cadenaConexion;
        private string _mensaje;

        //Creamos la cadena de conexion
        public BLCursoAbierto(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //Es donde se llaman el metodo para insertar datos 
        public int Insertar(EntidadCursoAbierto curso)
        {
            int idCurso = 0;
            DACursoAbierto accesoDatos = new DACursoAbierto(_cadenaConexion);
            try
            {
                idCurso = accesoDatos.Insertar(curso);
            }
            catch (Exception)
            {
                throw;
            }

            return idCurso;

        }

        //Llamamos a los datos por medio del DataSet
        public DataSet ListarCursos(string condicion, string orden = "")
        {
            DataSet DS;
            DACursoAbierto accesoDatos = new DACursoAbierto(_cadenaConexion);
            try
            {
                DS = accesoDatos.Listar(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return DS;
        }

        //Eliminamos un registro por el llamado de un procedimiento 
        public int Eliminar(EntidadCursoAbierto curso)
        {
            int resultado;
            DACursoAbierto accesoDatos = new DACursoAbierto(_cadenaConexion);
            try
            {
                resultado = accesoDatos.Eliminar(curso);
                _mensaje = accesoDatos.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        //Pedimos los datos de un solo registro
        public EntidadCursoAbierto ObtenerCurso(int id)
        {
            EntidadCursoAbierto curso;
            DACursoAbierto accesoDatos = new DACursoAbierto(_cadenaConexion);
            try
            {
                curso = accesoDatos.ObtenerCurso(id);
            }
            catch (Exception)
            {
                throw;
            }
            return curso;
        }

        //Modificamos los datos del registro
        public int Modificar(EntidadCursoAbierto curso)
        {
            int filasAfectadas = 0;
            DACursoAbierto accesoDatos = new DACursoAbierto(_cadenaConexion);
            try
            {
                filasAfectadas = accesoDatos.Modificar(curso);
            }
            catch (Exception)
            {
                throw;
            }
            return filasAfectadas;
        }
    }
}
