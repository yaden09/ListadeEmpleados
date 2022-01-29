using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class gerente : empleado
    {
        private String altura;
        private String sexo;
        private int salario;
        private String accion;

        public string Altura { get => altura; set => altura = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Salario1 { get => salario; set => salario = value; }
        public string Accion { get => accion; set => accion = value; }
    }
}
