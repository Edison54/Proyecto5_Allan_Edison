using System;

namespace Entidades
{
    public class EntidadPrograma
    {        
        //Atributos
        private int idPrograma;
        private string nombre;
        private string descripcion;

        //Constructores
        public EntidadPrograma()
        {
        }

        public EntidadPrograma(int idPrograma, string nombre, string descripcion)
        {
            this.IdPrograma = idPrograma;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        //Metodos get y set de las clases
        public int IdPrograma { get => idPrograma; set => idPrograma = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
