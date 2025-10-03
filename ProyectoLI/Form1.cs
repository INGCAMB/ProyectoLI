using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Agregar estas dos referencia una para el hint de login y la otra para conexion MySql
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;

namespace ProyectoLI
{
    public partial class frmLogin : Form
    {
        //Variables para guardar los datos que se obtendran de la base de datos para poder iniciar sesion
        public string Nombre = "", Correo = "", Contra = "", NombreApodo = "";
        public int id = 0;
        public bool Admin = false;

        public frmLogin()
        {
            InitializeComponent();
            List<TextBox> tList = new List<TextBox>();
            List<string> sList = new List<string>();
            tList.Add(txtCorreo);
            sList.Add("Correo electronico");
            tList.Add(txtContra);
            sList.Add("Contraseña");
            SetCueBanner(ref tList, sList);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr i, string str);

        void SetCueBanner(ref List<TextBox> textBox, List<string> CueText)
        {
            for (int x = 0; x < textBox.Count; x++)
            {
                SendMessage(textBox[x].Handle, 0x1501, (IntPtr)1, CueText[x]);
                txtContra.UseSystemPasswordChar = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Consulta();
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


        private void frmLogin_Load(object sender, EventArgs e)
        {
            //Mostrar Fecha
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtContra.Focus();
            }
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAceptar.Focus();
            }
        }

        private void pbMostrarConAct_Click(object sender, EventArgs e)
        {
            txtContra.UseSystemPasswordChar = false;
            pbMostrarConAct.Visible = false;
            pbMostrarConAct.Enabled = false;
            pbOcultarConAct.Visible = true;
            pbOcultarConAct.Enabled = true;
        }

        private void pbOcultarConAct_Click(object sender, EventArgs e)
        {
            txtContra.UseSystemPasswordChar = true;
            pbMostrarConAct.Visible = true;
            pbMostrarConAct.Enabled = true;
            pbOcultarConAct.Visible = false;
            pbOcultarConAct.Enabled = false;
        }

        private void lblregistro_Click(object sender, EventArgs e)
        {
            frmRegistro rp = new frmRegistro();
            rp.Show();
            Visible = false;
        }

        private void lblolvidocontra_Click(object sender, EventArgs e)
        {
            frmOlvidoContra ocp = new frmOlvidoContra();
            ocp.Show();
            Visible = false;
        }

        //Metodo para consultar los datos de la base de datos
        public void Consulta()
        {
            //Un try/catch para saber si el correo existe, si no existe manda un mensaje diciendo que no existe el correo o la falla de conexion de base de datos
            try
            {
                //Conexion ya sea por localhost o por servidor
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
                //MySqlConnection conectar = new MySqlConnection("server=arsoft.myvnc.com; database=topicosprueba; Uid=developer; pwd=camb6691481;");
                //Abrimos conexion
                conectar.Open();
                //Abrimos objeto para comando mysql
                MySqlCommand codigo = new MySqlCommand();
                //Nos conectamos
                MySqlConnection conectanos = new MySqlConnection();
                //Hacemos conexion con los comandos de mysql con la base de datos 
                codigo.Connection = conectar;
                //Escribimos el comando para consultar un correo del txtCorreo de la tabla usuarios
                codigo.CommandText = "select * from usuarios where correo = \"" + txtCorreo.Text + "\";";
                //Leemos los datos del registro buscado
                MySqlDataReader leer = codigo.ExecuteReader();
                leer.Read();
                //Los guardamos en las variables los obtenemos con su tipo de dato y la posicion en la que se encuentran en la base de datos
                id = leer.GetInt32(0);
                Nombre = leer.GetString(1);
                Correo = leer.GetString(2);
                Contra = leer.GetString(3);
                Admin = leer.GetBoolean(4);
                NombreApodo = leer.GetString(5);
                //Cerramos la conexion
                conectar.Close();

                //Se guardan los datos mas relevantes del inicio de sesion en variables globales que se podran usar en cualquier momento de la aplicacion
                VariablesGlobales.IdDeUsuarioActivo = id;
                VariablesGlobales.NombreDeUsuarioActivo = Nombre;
                VariablesGlobales.CorreoDelUsuarioActivo = Correo;
                VariablesGlobales.NombreApodoUsuario = NombreApodo;

                //If-else para saber si el correo y contra son iguales en la base de datos y los que puso el usuario si no te manda un mensaje de contra invalida
                if (txtCorreo.Text == Correo && txtContra.Text == Contra)
                {
                    //If-else para saber si es administrador o no
                    if (Admin)
                    {
                        VariablesGlobales.UsuarioAdministrador = true;
                        frmMenu mp = new frmMenu();
                        mp.Show();
                        Visible = false;
                    }
                    else
                    {
                        VariablesGlobales.UsuarioAdministrador = false;
                        frmMenu mp = new frmMenu();
                        mp.Show();
                        Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña inválida, favor de intentarlo de nuevo.");
                    txtContra.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El correo que ingresó no existe, favor de intentar de nuevo.");
                txtCorreo.Clear();
            }
        }
    }
}
