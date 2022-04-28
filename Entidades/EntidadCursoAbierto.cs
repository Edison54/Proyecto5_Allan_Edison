using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EntidadCursoAbierto
    {
        //Atributos
        private int idCursoAbierto;
        private int idCurso;
        private int idProfesor;
        private int horaInicio;
        private int horaFin;
        private string dia;

        //Constructores
        public EntidadCursoAbierto()
        {
        }

        public EntidadCursoAbierto(int idCursoAbierto, int idCurso, int idProfesor, int horaInicio, int horaFin, string dia)
        {
            this.IdCursoAbierto = idCursoAbierto;
            this.IdCurso = idCurso;
            this.IdProfesor = idProfesor;
            this.HoraInicio = horaInicio;
            this.HoraFin = horaFin;
            this.Dia = dia;
        }

        //Metodos get y set de las clases
        public int IdCursoAbierto { get => idCursoAbierto; set => idCursoAbierto = value; }
        public int IdCurso { get => idCurso; set => idCurso = value; }
        public int IdProfesor { get => idProfesor; set => idProfesor = value; }
        public int HoraInicio { get => horaInicio; set => horaInicio = value; }
        public int HoraFin { get => horaFin; set => horaFin = value; }
        public string Dia { get => dia; set => dia = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
