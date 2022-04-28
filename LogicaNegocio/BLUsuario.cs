using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class BLUsuario
    {
        private string _cadenaConexion;
        private string _mensaje;



        public BLUsuario(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            Mensaje = string.Empty;
        }

        public string Mensaje { get => _mensaje; set => _mensaje = value; }

        public EntidadUsuario Loguear(String nombre, String pass)
        {
            EntidadUsuario usuario;
            DAUsuario accesoDatos = new DAUsuario(_cadenaConexion);
            try
            {
                usuario = accesoDatos.ObtenerUser(nombre, pass);
                if (usuario != null) {
                    Mensaje = "Logeado con exito";

                }
                else
                {
                    Mensaje = "Datos incorrectos";
                }
            }
            catch (Exception)
            {
                throw;
            }
            return usuario;
        }
    }
}
