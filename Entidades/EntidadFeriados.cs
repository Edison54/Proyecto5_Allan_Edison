using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EntidadFeriados
    {
        //Atributos
        private int idFeriado;
        private DateTime fecha;
        private string motivo;

        //Constructores
        public EntidadFeriados()
        {
        }

        public EntidadFeriados(int idFeriado, DateTime fecha, string motivo)
        {
            this.IdFeriado = idFeriado;
            this.Fecha = fecha;
            this.Motivo = motivo;
        }


        //Metodos get y set de las clases
        public int IdFeriado { get => idFeriado; set => idFeriado = value; }

        public DateTime Fecha { get => fecha; set => fecha = value; }

        public string Motivo { get => motivo; set => motivo = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
