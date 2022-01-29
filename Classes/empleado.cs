using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class empleado : persona
    {
        //Atributos
        private String puesto;
        private String lugar_trabajo;
        private String tiempo_trabajo;


        //Propiedades
        public string Puesto { get => puesto; set => puesto = value; }
        public string Lugar_trabajo { get => lugar_trabajo; set => lugar_trabajo = value; }
        public string Tiempo_trabajo { get => tiempo_trabajo; set => tiempo_trabajo = value; }
    }

   

}
