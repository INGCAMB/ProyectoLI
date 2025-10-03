using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLI
{
    public partial class frmResultados : Form
    {
        int CalificacionFinal = VariablesGlobales.AcumuladorDePuntos;
        string PruebaFinal = VariablesGlobales.TipoDeMateria, Materia = "";

        public frmResultados()
        {
            InitializeComponent();

            label2.Text = "Resultado = " + CalificacionFinal;

            if (PruebaFinal == "mate")
            {
                Materia = "Matematicas";
                if (CalificacionFinal <= 2)
                {
                    label1.Text = "Necesitas esforzate mas y mas";
                    label3.Text = "Gracias por haber acabado la prueba de " + Materia + ", pero lamentablemente" +
                        " no acumuló suficientes puntos para conseguir una buena calificación. " +
                        "Le recomendamos que consulte dudas con un docente de su escuela sobre la materia." +
                        "\n\n" + "Gracias por utilizar nuestro servicio.";
                }
                else if (CalificacionFinal >= 3 && CalificacionFinal <= 5)
                {
                    label1.Text = "Muy buen intento sigue";
                    label3.Text = "Gracias por haber acabado la prueba de " + Materia + ", pero lamentablemente" +
                        " no acumuló suficientes puntos para conseguir una buena calificación. " +
                        "Le recomendamos que consulte dudas con un docente de su escuela sobre la materia." +
                        "\n\n" + "Gracias por utilizar nuestro servicio.";
                }
                else if (CalificacionFinal >= 6 && CalificacionFinal <= 8)
                {
                    label1.Text = "Muy bien solo necesitas esforzarte mas";
                    label3.Text = "Gracias por haber acabado la prueba de " + Materia + ", pero lamentablemente" +
                        " no acumuló suficientes puntos para conseguir una buena calificación. " +
                        "Le recomendamos que consulte dudas con un docente de su escuela sobre la materia." +
                        "\n\n" + "Gracias por utilizar nuestro servicio.";
                }
                else if (CalificacionFinal >= 9 && CalificacionFinal <= 11)
                {
                    label1.Text = "Muy buen puntuaje sigue asi";
                    label3.Text = "Gracias por haber acabado la prueba de " + Materia + ", pero lamentablemente" +
                        " no acumuló suficientes puntos para conseguir las buenas calificaciones. " +
                        "Le recomendamos que consulte dudas con un docente de su escuela sobre la materia." +
                        "\n\n" + "Gracias por utilizar nuestro servicio.";
                }
                else if (CalificacionFinal >= 12 && CalificacionFinal <= 14)
                {
                    label1.Text = "Muy buen intento casi llegas al maximo";
                    label3.Text = "Gracias por haber acabado la prueba de " + Materia + ", pero lamentablemente" +
                        " te faltaron ciertos puntos para ser el maximo sigue esforzandote. " +
                        "Le recomendamos que consulte dudas con un docente de su escuela sobre la materia." +
                        "\n\n" + "Gracias por utilizar nuestro servicio.";
                }
                else
                {
                    label1.Text = "Muchas felicidades eres el mejor de la clase";
                    label3.Text = "Gracias por haber acabado la prueba de " + Materia + ", pero lamentablemente" +
                        " no es tu unico examen tu puedes con mas sigue asi con todas tus pruebas. " +
                        "Le recomendamos que consulte dudas con un docente de su escuela sobre la materia." +
                        "\n\n" + "Gracias por utilizar nuestro servicio.";
                }
            }
            else if (PruebaFinal == "esp")
            {
                Materia = "Español";
                if (CalificacionFinal <= 2)
                {
                    label1.Text = "Necesitas esforzate mas y mas";
                    label3.Text = "Gracias por haber acabado la prueba de " + Materia + ", pero lamentablemente" +
                        " no acumuló suficientes puntos para conseguir una buena calificación. " +
                        "Le recomendamos que consulte dudas con un docente de su escuela sobre la materia." +
                        "\n\n" + "Gracias por utilizar nuestro servicio.";
                }
                else if (CalificacionFinal >= 3 && CalificacionFinal <= 5)
                {
                    label1.Text = "Muy buen intento sigue";
                    label3.Text = "Gracias por haber acabado la prueba de " + Materia + ", pero lamentablemente" +
                        " no acumuló suficientes puntos para conseguir una buena calificación. " +
                        "Le recomendamos que consulte dudas con un docente de su escuela sobre la materia." +
                        "\n\n" + "Gracias por utilizar nuestro servicio.";
                }
                else if (CalificacionFinal >= 6 && CalificacionFinal <= 8)
                {
                    label1.Text = "Muy bien solo necesitas esforzarte mas";
                    label3.Text = "Gracias por haber acabado la prueba de " + Materia + ", pero lamentablemente" +
                        " no acumuló suficientes puntos para conseguir una buena calificación. " +
                        "Le recomendamos que consulte dudas con un docente de su escuela sobre la materia." +
                        "\n\n" + "Gracias por utilizar nuestro servicio.";
                }
                else if (CalificacionFinal >= 9 && CalificacionFinal <= 11)
                {
                    label1.Text = "Muy buen puntuaje sigue asi";
                    label3.Text = "Gracias por haber acabado la prueba de " + Materia + ", pero lamentablemente" +
                        " no acumuló suficientes puntos para conseguir las buenas calificaciones. " +
                        "Le recomendamos que consulte dudas con un docente de su escuela sobre la materia." +
                        "\n\n" + "Gracias por utilizar nuestro servicio.";
                }
                else if (CalificacionFinal >= 12 && CalificacionFinal <= 14)
                {
                    label1.Text = "Muy buen intento casi llegas al maximo";
                    label3.Text = "Gracias por haber acabado la prueba de " + Materia + ", pero lamentablemente" +
                        " te faltaron ciertos puntos para ser el maximo sigue esforzandote. " +
                        "Le recomendamos que consulte dudas con un docente de su escuela sobre la materia." +
                        "\n\n" + "Gracias por utilizar nuestro servicio.";
                }
                else
                {
                    label1.Text = "Muchas felicidades eres el mejor de la clase";
                    label3.Text = "Gracias por haber acabado la prueba de " + Materia + ", pero lamentablemente" +
                        " no es tu unico examen tu puedes con mas sigue asi con todas tus pruebas. " +
                        "Le recomendamos que consulte dudas con un docente de su escuela sobre la materia." +
                        "\n\n" + "Gracias por utilizar nuestro servicio.";
                }
            }
            else
            {
                Materia = "Ingles";
                if (CalificacionFinal <= 2)
                {
                    label1.Text = "Necesitas esforzate mas y mas";
                    label3.Text = "Gracias por haber acabado la prueba de " + Materia + ", pero lamentablemente" +
                        " no acumuló suficientes puntos para conseguir una buena calificación. " +
                        "Le recomendamos que consulte dudas con un docente de su escuela sobre la materia." +
                        "\n\n" + "Gracias por utilizar nuestro servicio.";
                }
                else if (CalificacionFinal >= 3 && CalificacionFinal <= 5)
                {
                    label1.Text = "Muy buen intento sigue";
                    label3.Text = "Gracias por haber acabado la prueba de " + Materia + ", pero lamentablemente" +
                        " no acumuló suficientes puntos para conseguir una buena calificación. " +
                        "Le recomendamos que consulte dudas con un docente de su escuela sobre la materia." +
                        "\n\n" + "Gracias por utilizar nuestro servicio.";
                }
                else if (CalificacionFinal >= 6 && CalificacionFinal <= 8)
                {
                    label1.Text = "Muy bien solo necesitas esforzarte mas";
                    label3.Text = "Gracias por haber acabado la prueba de " + Materia + ", pero lamentablemente" +
                        " no acumuló suficientes puntos para conseguir una buena calificación. " +
                        "Le recomendamos que consulte dudas con un docente de su escuela sobre la materia." +
                        "\n\n" + "Gracias por utilizar nuestro servicio.";
                }
                else if (CalificacionFinal >= 9 && CalificacionFinal <= 11)
                {
                    label1.Text = "Muy buen puntuaje sigue asi";
                    label3.Text = "Gracias por haber acabado la prueba de " + Materia + ", pero lamentablemente" +
                        " no acumuló suficientes puntos para conseguir las buenas calificaciones. " +
                        "Le recomendamos que consulte dudas con un docente de su escuela sobre la materia." +
                        "\n\n" + "Gracias por utilizar nuestro servicio.";
                }
                else if (CalificacionFinal >= 12 && CalificacionFinal <= 14)
                {
                    label1.Text = "Muy buen intento casi llegas al maximo";
                    label3.Text = "Gracias por haber acabado la prueba de " + Materia + ", pero lamentablemente" +
                        " te faltaron ciertos puntos para ser el maximo sigue esforzandote. " +
                        "Le recomendamos que consulte dudas con un docente de su escuela sobre la materia." +
                        "\n\n" + "Gracias por utilizar nuestro servicio.";
                }
                else
                {
                    label1.Text = "Muchas felicidades eres el mejor de la clase";
                    label3.Text = "Gracias por haber acabado la prueba de " + Materia + ", pero lamentablemente" +
                        " no es tu unico examen tu puedes con mas sigue asi con todas tus pruebas. " +
                        "Le recomendamos que consulte dudas con un docente de su escuela sobre la materia." +
                        "\n\n" + "Gracias por utilizar nuestro servicio.";
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            /*frmMenu mostrarmenu = new frmMenu();
            mostrarmenu.Show();*/
            this.Close();
        }
    }
}
