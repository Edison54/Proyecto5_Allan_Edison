using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EntidadEstudiante : ClasePadre
    {
        //Atributos
        private int idEstudiante;

        //Constructores
        public EntidadEstudiante()
        {
        }

        public EntidadEstudiante(int idEstudiante, string cedula, string nombre, string correo, string direccion, int telefono)
        {
            this.IdEstudiante = idEstudiante;
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Correo = correo;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }

        //Metodos get y set de las clases
        public int IdEstudiante { get => idEstudiante; set => idEstudiante = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
