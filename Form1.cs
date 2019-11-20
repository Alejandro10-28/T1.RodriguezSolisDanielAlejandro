using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excepcion2
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
            this.Text = "AGREGAR ALUMNOS";
            this.BackColor = Color.Aqua;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //Se usa la condicion para cuando las cajas de texto esten vacias este le diga al usuario
            //Que no se han llenado.
            if (txtMatricula.Text == "")
                //El Ep.setError cabe destacar que sirve para que marque la caja de texto donde
                //No se ingreso el valor
                EP.SetError(txtMatricula, "No ha ingresado matricula");


            if (txtNombre.Text == "")

                EP.SetError(txtNombre, "No ha ingresado Nombre");

            if (txtSemestre.Text == "")

                EP.SetError(txtSemestre, "No ha ingresado semestre");

            if (txtSemestre.Text == "")

                EP.SetError(txtCarrera, "No ha ingresado Carrera");

   

            if (txtCalificacion.Text == "")
                EP.SetError(txtCalificacion, "No ha ingresado Calificacion");

            //Se usa un try para capturar los errores que se puedan presentar como
            //no llenar las cajas texto

            try
            {
                //Se asignan las cajas de texto a los atributos
                Alumno alumno = new Alumno();
                alumno.Matricula = txtMatricula.Text;
                alumno.Nombre = txtNombre.Text;
                alumno.Semestre = Convert.ToInt32(txtSemestre.Text);
                alumno.Carrera = txtCarrera.Text;
                alumno.Calificacion= Convert.ToInt32(txtCalificacion.Text);

                //confirmacion de que el usuario se ah creado
                throw new ExeptionEspecial("su alumno se creo exitosamente");

            }
            //FormatException es para cuando se ingresa un formato que no se espera
            catch (FormatException exception)
            {

                //mensaje de error al ingresar un dato no adecuado 
                MessageBox.Show("Error en registrar alumno:" +" "+ exception.Message);

            }

            catch (ExeptionEspecial specialexception)
            {


                MessageBox.Show(specialexception.Message);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtCalificacion_TextChanged(object sender, EventArgs e)
        {
            //Se usa este try por si se llega aingresar un numero mayor a 10 o menor de 0

            try
            {
                //condicion para verificar que el dato de la calificacion se encuentre entre los numero del 1 al 10
                int Calificacion = Convert.ToInt32(txtCalificacion.Text);
                
                if (Calificacion < 1 || Calificacion > 10)
                {
                    MessageBox.Show("Ingrese una calificacion del 1 al 10");
                }

            }
            //El catch lo que hara sera atrapar el error y decir el tipo de error que tiene
            catch (Exception ex)
            {
                //mensjae en caso de que registro tenga un error 
                MessageBox.Show("Erro en los campos", "error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);


            }


        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //Accion para cerrar el programa
            this.Close();
        }

        private void lblAlumno_Click(object sender, EventArgs e)
        {

        }
    }
}
