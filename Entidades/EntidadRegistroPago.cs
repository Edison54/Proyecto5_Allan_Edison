using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EntidadRegistroPago
    {
        //Atributos
        private int idRegistro;
        private int idPago;
        private DateTime fechaPago;
        private string medioPago;

        //Constructores
        public EntidadRegistroPago()
        {
        }

        public EntidadRegistroPago(int idRegistro, int idPago, DateTime fechaPago, string medioPago)
        {
            this.IdRegistro = idRegistro;
            this.IdPago = idPago;
            this.FechaPago = fechaPago;
            this.MedioPago = medioPago;
        }

        //Metodos get y set de las clases
        public int IdRegistro { get => idRegistro; set => idRegistro = value; }
        public int IdPago { get => idPago; set => idPago = value; }
        public DateTime FechaPago { get => fechaPago; set => fechaPago = value; }
        public string MedioPago { get => medioPago; set => medioPago = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
