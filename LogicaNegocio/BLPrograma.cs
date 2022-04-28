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
    public class BLPrograma
    {
        private string _cadenaConexion;
        private string _mensaje;

        public BLPrograma(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public DataSet ListarProgramas(string condicion, string orden = "")
        {
            DataSet DS;
            DAPrograma accesoDatos = new DAPrograma(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarProgramas(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return DS;
        }

    }
}
