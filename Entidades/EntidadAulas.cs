using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EntidadAulas
    {
        //Atributos
        private int idAula;
        private int idCurso;
        private int capacidad;

        //Constructores
        public EntidadAulas()
        {
        }

        public EntidadAulas(int idAula, int idCurso, int capacidad)
        {
            this.IdAula = idAula;
            this.IdCurso = idCurso;
            this.Capacidad = capacidad;
        }

        //Metodos get y set de las clases
        public int IdAula { get => idAula; set => idAula = value; }
        public int IdCurso { get => idCurso; set => idCurso = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
