using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadUsuario
    {
        public int IDUsuario { get; set; }

        public String Nombre { get; set; }

        public String contrasennia { get; set; }

    

        public EntidadUsuario()
        {
        }

        public EntidadUsuario(int iDUsuario, string nombre, string contrasennia)
        {
            IDUsuario = iDUsuario;
            Nombre = nombre;
            this.contrasennia = contrasennia;
        }
    }
}
