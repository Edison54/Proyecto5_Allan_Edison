using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EntidadMatricula
    {
        //Atributos
        private int idMatricula;
        private int idEstudiante;
        private int id_curso_abierto;
        private int costo;
        private string estado;

        //Constructores
        public EntidadMatricula()
        {
        }

        public EntidadMatricula(int idMatricula, int idEstudiante, int id_curso_abierto, int costo, string estado)
        {
            this.IdMatricula = idMatricula;
            this.IdEstudiante = idEstudiante;
            this.Id_curso_abierto = id_curso_abierto;
            this.Costo = costo;
            this.Estado = estado;
        }

        //Metodos get y set de las clases
        public int IdMatricula { get => idMatricula; set => idMatricula = value; }
        public int IdEstudiante { get => idEstudiante; set => idEstudiante = value; }
        public int Id_curso_abierto { get => id_curso_abierto; set => id_curso_abierto = value; }
        public int Costo { get => costo; set => costo = value; }
        public string Estado { get => estado; set => estado = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
