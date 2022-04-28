using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EntidadPago
    {
        //Atributos
        private int idPago;
        private int idMatricula;
        private int monto;
        private int montoRestante;
        private string descripcion;

        //Constructores
        public EntidadPago()
        {
        }

        public EntidadPago(int idPago, int idMatricula, int monto, int montoRestante, string descripcion)
        {
            this.IdPago = idPago;
            this.IdMatricula = idMatricula;
            this.Monto = monto;
            this.MontoRestante = montoRestante;
            this.Descripcion = descripcion;
        }

        //Metodos get y set de las clases
        public int IdPago { get => idPago; set => idPago = value; }
        public int IdMatricula { get => idMatricula; set => idMatricula = value; }
        public int Monto { get => monto; set => monto = value; }
        public int MontoRestante { get => montoRestante; set => montoRestante = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
