using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace ProyectoLI
{
    public partial class frmRegistro : Form
    {
        bool nosalir = false;

        public frmRegistro()
        {
            InitializeComponent();
            List<TextBox> tList = new List<TextBox>();
            List<string> sList = new List<string>();
            tList.Add(txtNombre);
            sList.Add("No más de 30 caracteres");
            tList.Add(txtNombreApodo);
            sList.Add("Cual tipo de caracter");
            tList.Add(txtCorreo);
            sList.Add("No más de 45 caracteres");
            tList.Add(txtConf_correo);
            sList.Add("No más de 45 caracteres");
            tList.Add(txtContra);
            sList.Add("No más de 25 caracteres");
            tList.Add(txtConf_contra);
            sList.Add("No más de 25 caracteres");
            SetCueBanner(ref tList, sList);

            txtContra.UseSystemPasswordChar = true;
            txtConf_contra.UseSystemPasswordChar = true;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr i, string str);

        void SetCueBanner(ref List<TextBox> textBox, List<string> CueText)
        {
            for (int x = 0; x < textBox.Count; x++)
            {
                SendMessage(textBox[x].Handle, 0x1501, (IntPtr)1, CueText[x]);
            }
        }

        private void frmRegistro_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (nosalir == false)
            {
                Application.Exit();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            nosalir = true;
            frmLogin regresar = new frmLogin();
            regresar.Show();
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //string cadena = txtNombre.Text;
            //txtNombre.Text = Convert.ToString(cadena.Length);
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese su nombre!");
                txtNombre.Focus();
            }
            else if (txtNombreApodo.Text == "")
            {
                MessageBox.Show("Ingrese un nombre de usuario");
                txtNombreApodo.Focus();
            }
            else if (txtCorreo.Text == "")
            {
                MessageBox.Show("Por favor ingrese su correo electrónico");
                txtCorreo.Focus();
            }
            else if (txtConf_correo.Text == "")
            {
                MessageBox.Show("Favor de confirmar el correo");
                txtConf_correo.Focus();
            }
            else if (txtContra.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña a su cuenta");
                txtContra.Focus();
            }
            else if (txtConf_contra.Text == "")
            {
                MessageBox.Show("Favor de confirmar la contraseña");
                txtConf_contra.Focus();
            }
            else if (txtContra.Text != txtConf_contra.Text)
            {
                MessageBox.Show("La confirmación de contraseña no coincide.");
            }
            else if (txtCorreo.Text != txtConf_correo.Text)
            {
                MessageBox.Show("La confirmación de correo no coincide.");
            }
            else
            {
                ConsultaCorreo();
            }
        }

        private void ConsultaCorreo()
        {
            string comparacioncorreo = "";
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                codigo.Connection = conectar;
                codigo.CommandText = "select * from usuarios where correo = \"" + txtCorreo.Text + "\"";
                MySqlDataReader leer = codigo.ExecuteReader();
                leer.Read();
                comparacioncorreo = leer.GetString(2);
                conectar.Close();
                txtCorreo.Clear();
                MessageBox.Show("No se puede dar de alta al usuario porque el correo: " + comparacioncorreo +" ya está registrado");
            }
            catch (Exception)
            {
                try
                {
                    ConsultaApodo();
                }
                catch (Exception)
                {
                    AltaUsuario();
                }
            }
        }

        private void ConsultaApodo()
        {
            string comparacionapodo = "";
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = "select * from usuarios where nombreusu = \"" + txtNombreApodo.Text + "\"";
            MySqlDataReader leer = codigo.ExecuteReader();
            leer.Read();
            comparacionapodo = leer.GetString(5);
            conectar.Close();
            txtNombreApodo.Clear();
            MessageBox.Show("No se puede dar de alta al usuario porque el apodo: " + comparacionapodo + " ya está registrado");
        }

        private void AltaUsuario()
        {
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                codigo.Connection = conectar;
                codigo.CommandText = "insert into usuarios (nombre, correo, contra, nombreusu) values (" + "\"" + txtNombre.Text + "\", \"" +
                    txtCorreo.Text + "\", \"" + txtContra.Text + "\", \"" + txtNombreApodo.Text + "\");";
                codigo.ExecuteNonQuery();
                MessageBox.Show("Usuario Registrado");
                conectar.Close();
                frmLogin login = new frmLogin();
                login.Show();
                nosalir = true;
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la alta del usuario...");
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void frmRegistro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void pbMostrarConActConf_Click(object sender, EventArgs e)
        {
            txtConf_contra.UseSystemPasswordChar = false;
            pbMostrarConActConf.Visible = false;
            pbMostrarConActConf.Enabled = false;
            pbOcultarConActConf.Visible = true;
            pbOcultarConActConf.Enabled = true;
        }

        private void pbOcultarConActConf_Click(object sender, EventArgs e)
        {
            txtConf_contra.UseSystemPasswordChar = true;
            pbMostrarConActConf.Visible = true;
            pbMostrarConActConf.Enabled = true;
            pbOcultarConActConf.Visible = false;
            pbOcultarConActConf.Enabled = false;
        }
    }
}
