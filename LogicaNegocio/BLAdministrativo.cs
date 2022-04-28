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
    public class BLAdministrativo
    {

        //Variables necesarias en la capa de negocio
        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje
        {
            get => _mensaje;
        }

        //Creamos la cadena de conexion
        public BLAdministrativo(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        //Es donde se llaman el metodo para insertar datos 
        public int Insertar(EntidadAdministrativo administrativo)
        {
            int idAdmin = 0;
            DAAdministrativo accesoDatos = new DAAdministrativo(_cadenaConexion);
            try
            {
                idAdmin = accesoDatos.Insertar(administrativo);
            }
            catch (Exception)
            {
                throw;
            }

            return idAdmin;

        }

        //Llamamos a los datos por medio del DataSet
        public DataSet ListarAdministrativos(string condicion, string orden = "")
        {
            DataSet DS;
            DAAdministrativo accesoDatos = new DAAdministrativo(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarAdministrativos(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return DS;
        }

        //Eliminamos un registro por el llamado de un procedimiento 
        public int EliminarConSP(EntidadAdministrativo administrativo)
        {
            int resultado;
            DAAdministrativo accesoDatos = new DAAdministrativo(_cadenaConexion);
            try
            {
                resultado = accesoDatos.EliminarRegistroConSP(administrativo);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        //Pedimos los datos de un solo registro
        public EntidadAdministrativo ObtenerAdmin(int id)
        {
            EntidadAdministrativo administrativo;
            DAAdministrativo accesoDatos = new DAAdministrativo(_cadenaConexion);
            try
            {
                administrativo = accesoDatos.ObtenerAdmin(id);
            }
            catch (Exception)
            {
                throw;
            }
            return administrativo;
        }

        //Modificamos los datos del registro
        public int Modificar(EntidadAdministrativo administrativo)
        {
            int filasAfectadas = 0;
            DAAdministrativo accesoDatos = new DAAdministrativo(_cadenaConexion);
            try
            {
                filasAfectadas = accesoDatos.Modificar(administrativo);
            }
            catch (Exception)
            {
                throw;
            }
            return filasAfectadas;
        }
    }
}
