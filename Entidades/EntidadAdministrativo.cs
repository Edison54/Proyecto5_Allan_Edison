using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EntidadAdministrativo : ClasePadre
    {
        //Atributos
        private int idAdmin;
        private int idPrograma;
        private string cargo;
        private string departamento;

        //Constructores
        public EntidadAdministrativo()
        {
        }

        public EntidadAdministrativo(int idAdmin, int idPrograma, string nombre, string correo, string direccion, int telefono, string cargo, string departamento)
        {
            this.IdAdmin = idAdmin;
            this.IdPrograma = idPrograma;
            this.Nombre = nombre;
            this.Correo = correo;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Cargo = cargo;
            this.Departamento = departamento;
        }

        //Metodos get y set de las clases
        public int IdAdmin { get => idAdmin; set => idAdmin = value; }

        public int IdPrograma { get => idPrograma; set => idPrograma = value; }

        public string Cargo { get => cargo; set => cargo = value; }

        public string Departamento { get => departamento; set => departamento = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
