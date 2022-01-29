using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;

namespace Empleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var haciendo = "";

            empleado empleado1 = new empleado();
            empleado1.Puesto = cboPuesto.Text;
            empleado1.Nombre = tbxNombre.Text;
            empleado1.Cedula = txbCedula.Text;
            empleado1.Tiempo_trabajo = cmbAños.Text;
            empleado1.Lugar_trabajo = haciendo;



            gerente gerente1 = new gerente();
            const string accion1 = "Entrevistando a Recluta";
            gerente1.Accion = accion1;

            intendente intendente1 = new intendente();
            const string accion2 = "Limpiando Lobby";
            intendente1.Accion = accion2;

            oficinista oficinista1 = new oficinista();
            const string accion3 = "Llenando un reporte";
            oficinista1.Accion = accion3;

            recepcionista recepcionista1 = new recepcionista();
            const string accion4 = "Atendiendo una llamada";
            recepcionista1.Accion = accion4;

            recluta recluta1 = new recluta();
            const string accion5 = "En entrevista";
            recluta1.Accion = accion5;



            if (empleado1.Puesto == "Gerente")
            {
                haciendo = accion1;
            }

            if (empleado1.Puesto == "Intendente")
            {
                haciendo = accion2;
            }

            if (empleado1.Puesto == "Oficinista")
            {
                haciendo = accion3;
            }

            if (empleado1.Puesto == "Recepcionista")
            {
                haciendo = accion4;
            }

            if (empleado1.Puesto == "Recluta")
            {
                haciendo = accion5;
            }

            dgvEmpleados.Rows.Insert(0, empleado1.Puesto, empleado1.Nombre, empleado1.Cedula, empleado1.Tiempo_trabajo, empleado1.Lugar_trabajo);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cboPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
