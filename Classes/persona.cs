using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class persona
    {
        //atributos
        private String nombre;
        private String cedula;
        private String curp;
        private int Edad;

        //Propiedades

        public string Nombre { get => nombre; set => nombre = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Curp { get => curp; set => curp = value; }
        public int Edad1 { get => Edad; set => Edad = value; }
    }
}
