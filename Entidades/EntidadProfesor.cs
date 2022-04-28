using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EntidadProfesor : ClasePadre
    {
        //Atributos
        private int idProfesor;
        private int sueldo;
        private string idioma;

        //Constructores
        public EntidadProfesor()
        {

        }

        public EntidadProfesor(int idProfesor, string cedula, string nombre, string correo, string direccion, int telefono, int sueldo, string idioma)
        {
            this.IdProfesor = idProfesor;
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Correo = correo;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Sueldo = sueldo;
            this.Idioma = idioma;
        }

        //Metodos get y set de las clases
        public int IdProfesor { get => idProfesor; set => idProfesor = value; }

        public int Sueldo { get => sueldo; set => sueldo = value; }

        public string Idioma { get => idioma; set => idioma = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
