using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EntidadAsistencia
    {
        //Atributos
        private int idAsistencia;
        private int idCurso;
        private int idEstudiante;
        private DateTime fechaAsistencia;
        private string presente;

        //Constructores
        public EntidadAsistencia()
        {
        }

        public EntidadAsistencia(int idAsistencia, int idCurso, int idEstudiante, DateTime fechaAsistencia, string presente)
        {
            this.IdAsistencia = idAsistencia;
            this.IdCurso = idCurso;
            this.IdEstudiante = idEstudiante;
            this.FechaAsistencia = fechaAsistencia;
            this.Presente = presente;
        }

        //Metodos get y set de las clases
        public int IdAsistencia { get => idAsistencia; set => idAsistencia = value; }
        public int IdCurso { get => idCurso; set => idCurso = value; }
        public int IdEstudiante { get => idEstudiante; set => idEstudiante = value; }
        public DateTime FechaAsistencia { get => fechaAsistencia; set => fechaAsistencia = value; }
        public string Presente { get => presente; set => presente = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
