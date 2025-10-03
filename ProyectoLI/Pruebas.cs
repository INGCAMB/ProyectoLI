using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace ProyectoLI
{
    public partial class frmPruebas : Form
    {
        //Arreglos para sacar información de la base de datos
        private string[] preguntas, res1, res2, res3, res4, rescorrecta, explicacion;

        //Para contar el número de pregunta en que va
        int PreguntaNo = 0;

        //String que se ocuparon para poder rescartar cual respuesta de pregunta vamos y respuesta que escogió
        string RespuestaDePregunta, RespuestaEscogida;

        //Esto nos sirvira para asegurar cuando le de click ver si esta bien o mal su respuesta
        bool BotonSiguiente = false;

        //Arreglo para contener las 15 preguntas que se utilizaran
        private int[] PreguntasQueSeUsaran;

        public frmPruebas()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void frmPruebas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Pruebas_Load(object sender, EventArgs e)
        {
            //Variable global para ir acumulando respuestas buenas
            VariablesGlobales.AcumuladorDePuntos = 0;

            //Les damos el tamaño a los arreglos
            preguntas = new string[30];
            res1 = new string[30];
            res2 = new string[30];
            res3 = new string[30];
            res4 = new string[30];
            rescorrecta = new string[30];
            explicacion = new string[30];
            PreguntasQueSeUsaran = new int[15];

            //Para identificar en que examen estamos
            Text = "Examen de " + VariablesGlobales.TipoDeMateria;

            //Try-Catch para que evitar un error si no llega a consultarse bien la base de datos
            try
            {
                ConsultarPreguntas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al iniciar la prueba, por favor intentelo de nuevo.\n" +
                    "Si experimenta el mismo problema, favor de consultar ayuda.\n" + ex);
                frmMenu volver = new frmMenu();
                volver.Show();
                Close();
            }

            //Último proceso que se hace es cambiar de pregunta y mandamos a llamar una función para poder cambiar de pregunta
            CambiarPregunta();
        }

        //Este timer sirve para la hora en que cambie la pregunta, se pueda eliminar la "palomita o tacha" y para regresar los radiobutton sin seleccionar
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Función de cambio de pregunta 
            CambiarPregunta();

            //Desabilita el tiempo 
            timer1.Enabled = false;

            BotonSiguiente = false;

            //Le cambiaremos el nombre al button
            btnComprobar.Text = "Comprobar";

            //Cambio de color a los radios
            r1.ForeColor = Color.White;
            r2.ForeColor = Color.White;
            r3.ForeColor = Color.White;
            r4.ForeColor = Color.White;

            //Poner invisibles la palomita y tacha
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            //If para comprobar si se le dio click al botón y verificar respuesta
            if (BotonSiguiente)
            {
                CambiarPregunta();
                timer1.Enabled = false;

                r1.ForeColor = Color.White;
                r2.ForeColor = Color.White;
                r3.ForeColor = Color.White;
                r4.ForeColor = Color.White;

                //Le cambiaremos el nombre al button
                btnComprobar.Text = "Comprobar";

                pictureBox1.Visible = false;
                pictureBox2.Visible = false;

                BotonSiguiente = false;
            }
            else
            {
                //Se sacara la respuesta correcta del arreglo "rescorrecta" teniendo en cuenta la el arreglo de 
                //"preguntas que se usaran" y teniendo en cuenta numero de pregunta en el que vamos "PreguntaNo"
                //A estos se les "RESTA 1" para que se vaya eliminando el numero de vectores
                //Y de todo esta sale nuestra respuesta de la pregunta que se identifico
                RespuestaDePregunta = rescorrecta[PreguntasQueSeUsaran[PreguntaNo - 1] - 1];

                //Condición de chequeo´para guardarlo en la variable "RespuestaEscogida"
                if (r1.Checked)
                {
                    RespuestaEscogida = "a";
                }
                else if (r2.Checked)
                {
                    RespuestaEscogida = "b";
                }
                else if (r3.Checked)
                {
                    RespuestaEscogida = "c";
                }
                else
                {
                    RespuestaEscogida = "d";
                }

                //Condición para verificar que si la respuesta fue correcta poner el radio de color verde
                if (RespuestaDePregunta == "a")
                {
                    r1.ForeColor = Color.Green;
                }
                else if (RespuestaDePregunta == "b")
                {
                    r2.ForeColor = Color.Green;
                }
                else if (RespuestaDePregunta == "c")
                {
                    r3.ForeColor = Color.Green;
                }
                else
                {
                    r4.ForeColor = Color.Green;
                }

                //Condición para ver si la respuesta de la pregunta es igual a la escogida
                if (RespuestaDePregunta == RespuestaEscogida)
                {
                    //Habilitar los botones
                    btnComprobar.Enabled = false;
                    btnRegresar.Enabled = false;

                    //El acumulador aumenta a medida que respondas bien
                    VariablesGlobales.AcumuladorDePuntos++;

                    //Foto de palomita
                    pictureBox1.Visible = true;

                    //Manda a llamar a timer para que limpie en el tiempo de cambiar de pregunta y consulte nueva pregunta
                    timer1.Enabled = true;
                }
                //Condición para cuando no es la respuesta escogida la buena respuesta
                else
                {
                    //Cambiar el nombre del botón a siguiente
                    btnComprobar.Text = "Siguiente";

                    //Como el botton sera verdadero va a cambiar de pregunta
                    BotonSiguiente = true;

                    //Esta foto es la tacha
                    pictureBox2.Visible = true;

                    //Condición para verificar que si la respuesta fue incorrecta poner el radio de color rojo
                    if (RespuestaEscogida == "a")
                    {
                        r1.ForeColor = Color.Red;
                    }
                    else if (RespuestaEscogida == "b")
                    {
                        r2.ForeColor = Color.Red;
                    }
                    else if (RespuestaEscogida == "c")
                    {
                        r3.ForeColor = Color.Red;
                    }
                    else
                    {
                        r4.ForeColor = Color.Red;
                    }

                    //Se sacara la respuesta correcta del arreglo "explicacion" teniendo en cuenta la el arreglo de 
                    //"preguntas que se usaran" y teniendo en cuenta numero de pregunta en el que vamos "PreguntaNo"
                    //A estos se les "RESTA 1" para que se vaya eliminando el numero de vectores
                    //Y de todo esto sale nuestra explicación
                    MessageBox.Show(explicacion[PreguntasQueSeUsaran[PreguntaNo - 1] - 1]);

                    //Manda a llamar a timer para que limpie en el tiempo de cambiar de pregunta y consulte nueva pregunta
                    timer1.Enabled = true;
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //MessageBox para preguntar si esta seguro de salir del examen en un cuadro de dialogo 
            if (MessageBox.Show("Seguro que quiere salir?", "¿Desea salir?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                /*frmMenu mp = new frmMenu();
                mp.Show();*/
                this.Close();
            }
        }

        private void ConsultarPreguntas()
        {
            //Variable que guardara el nombre de la tabla de preguntas que saldra de la base de datos
            string tabla;

            if (VariablesGlobales.GradoSeleccionado == 1) 
            {
                if (VariablesGlobales.TipoDeMateria == "mate")
                {
                    tabla = "preguntasmate1";
                }
                else if (VariablesGlobales.TipoDeMateria == "esp")
                {
                    tabla = "preguntasesp1";
                }
                else
                {
                    tabla = "preguntasing1";
                }
            }
            else if (VariablesGlobales.GradoSeleccionado == 2)
            {
                if (VariablesGlobales.TipoDeMateria == "mate")
                {
                    tabla = "preguntasmate2";
                }
                else if (VariablesGlobales.TipoDeMateria == "esp")
                {
                    tabla = "preguntasesp2";
                }
                else
                {
                    tabla = "preguntasing2";
                }
            }
            else
            {
                if (VariablesGlobales.TipoDeMateria == "mate")
                {
                    tabla = "preguntasmate3";
                }
                else if (VariablesGlobales.TipoDeMateria == "esp")
                {
                    tabla = "preguntasesp3";
                }
                else
                {
                    tabla = "preguntasing3";
                }
            }

            //Ciclo for para sacar las 80 preguntas, opciones, respuestas y explicaciones de la base de datos y colocarlas en los arreglos
            for (int i = 0; i <= 29; i++)
            {
                int id = i + 1;
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                codigo.Connection = conectar;
                codigo.CommandText = "select * from " + tabla + " where id = " + id + ";";
                MySqlDataReader leer = codigo.ExecuteReader();
                leer.Read();
                //Aqui es donde se van guardando
                preguntas[i] = leer.GetString(1);
                res1[i] = leer.GetString(2);
                res2[i] = leer.GetString(3);
                res3[i] = leer.GetString(4);
                res4[i] = leer.GetString(5);
                rescorrecta[i] = leer.GetString(6);
                explicacion[i] = leer.GetString(7);
                conectar.Close();
            }

            int u = 1;
            Random rnd = new Random();
            //Un do while para que se genere 15 veces el número random
            do
            {
                bool repetido = false;
                int aleatorio = rnd.Next(1, 31);

                //Este ciclo for fue hecho para guardar las 15 preguntas que se usaran en un arreglo
                for (int n = 0; n <= PreguntasQueSeUsaran.Length; n++)
                {
                    try
                    {
                        //Si la pregunta es igual al número aleatorio entonces se repetira la pregunta (en este caso no la guardamos)
                        if (PreguntasQueSeUsaran[n] == aleatorio)
                        {
                            repetido = true;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }

                //Si el repetido es falso entonces va a guardar en la posicion el número de pregunta aleatoria
                if (repetido == false)
                {
                    //Variable que guarda la posición
                    int guardar = u - 1;
                    PreguntasQueSeUsaran[guardar] = aleatorio;

                    u++;
                }
            } while (u <= 15);
        }

        private void CambiarPregunta()
        {
            r1.Focus();

            //Si ya son 15 números de preguntas mandará a llamar la función guardar examen y lo mandara a la ventana de resultados
            if (PreguntaNo == 15)
            {
                GuardarExamen();
                frmResultados res = new frmResultados();
                res.Show();
                Close();
            }
            //Si todavia no finaliza 15 preguntas entonces seeguira incrementando el número de preguntas
            else
            {
                //Contador de número de preguntas
                PreguntaNo++;

                //Se utiliza el contador para mostrar en que pregunta va
                //Se 
                label1.Text = PreguntaNo + ". " + preguntas[PreguntasQueSeUsaran[PreguntaNo - 1] - 1];

                //Se sacara la respuesta correcta del arreglo "res1,res2,res3" teniendo en cuenta la el arreglo de 
                //"preguntas que se usaran" y teniendo en cuenta numero de pregunta en el que vamos "PreguntaNo"
                //A estos se les "RESTA 1" para que se vaya eliminando el numero de vectores
                //Y de todo esto sale nuestra opciones de respuestas
                r1.Text = "a. " + res1[PreguntasQueSeUsaran[PreguntaNo - 1] - 1];
                r2.Text = "b. " + res2[PreguntasQueSeUsaran[PreguntaNo - 1] - 1];
                r3.Text = "c. " + res3[PreguntasQueSeUsaran[PreguntaNo - 1] - 1];
                r4.Text = "d. " + res4[PreguntasQueSeUsaran[PreguntaNo - 1] - 1];

                //Esto nomas sirve para la fuente de texto
                r1.Font = new Font("Microsoft Sans Serif", 14.8F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
                r2.Font = new Font("Microsoft Sans Serif", 14.8F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
                r3.Font = new Font("Microsoft Sans Serif", 14.8F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
                r4.Font = new Font("Microsoft Sans Serif", 14.8F, FontStyle.Regular, GraphicsUnit.Point, ((0)));

                //Condición para cuando el texto sobre pasa 50 caracteres
                if (r1.Text.Length > 50)
                {
                    r1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
                    r2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
                    r3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
                    r4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
                }
                if (r2.Text.Length > 50)
                {
                    r1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
                    r2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
                    r3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
                    r4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
                }
                if (r3.Text.Length > 50)
                {
                    r1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
                    r2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
                    r3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
                    r4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
                }
                if (r4.Text.Length > 50)
                {
                    r1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
                    r2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
                    r3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
                    r4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
                }
            }

            //Habilita los botones
            btnComprobar.Enabled = true;
            btnRegresar.Enabled = true;
        }

        private void GuardarExamen()
        {
            string grado;

            if (VariablesGlobales.GradoSeleccionado == 1)
            {
                grado = "1ro";
            }
            else if (VariablesGlobales.GradoSeleccionado == 2)
            {
                grado = "2do";
            }
            else
            {
                grado = "3ro";
            }

            //Objeto de fecha y tiempo
            DateTime fecha = DateTime.Today;

            //Te muestra en la consulta de calificación que dia lo hiciste
            string hoy = fecha.ToString("dd/MM/yyyy");
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = "insert into historial (id_usuario, grado, prueba, calificacion, fecha) values (" +
                VariablesGlobales.IdDeUsuarioActivo + ", \"" + grado + "\", \"" + VariablesGlobales.TipoDeMateria +
                "\", " + VariablesGlobales.AcumuladorDePuntos + ", \"" + hoy + "\");";
            codigo.ExecuteNonQuery();
            conectar.Close();
        }
    }
}
