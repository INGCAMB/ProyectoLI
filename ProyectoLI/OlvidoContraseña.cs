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
    public partial class frmOlvidoContra : Form
    {
        public frmOlvidoContra()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void frmOlvidoContra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmLogin regresar = new frmLogin();
            regresar.Show();
            Close();
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

        private void btnCambiarOlvidoContra_Click(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
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
            else
            {
                try
                {
                    //Conexion ya sea por localhost o por servidor
                    MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
                    conectar.Open();
                    MySqlCommand codigo = new MySqlCommand();
                    MySqlConnection conectanos = new MySqlConnection();
                    codigo.Connection = conectar;
                    codigo.CommandText = "update usuarios set contra = \"" + txtConf_contra.Text + "\" where correo = \"" +
                        txtCorreo.Text + "\";";
                    codigo.ExecuteNonQuery();
                    conectar.Close();

                    MessageBox.Show("Contraseña actualizada");

                    frmLogin login = new frmLogin();
                    login.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cambiar la contraseña:\n" + ex);
                }
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

        private void pbOcultarConActConf_Click(object sender, EventArgs e)
        {
            txtConf_contra.UseSystemPasswordChar = true;
            pbMostrarConActConf.Visible = true;
            pbMostrarConActConf.Enabled = true;
            pbOcultarConActConf.Visible = false;
            pbOcultarConActConf.Enabled = false;

        }

        private void pbMostrarConActConf_Click(object sender, EventArgs e)
        {
            txtConf_contra.UseSystemPasswordChar = false;
            pbMostrarConActConf.Visible = false;
            pbMostrarConActConf.Enabled = false;
            pbOcultarConActConf.Visible = true;
            pbOcultarConActConf.Enabled = true;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            pbCorreo.Visible = false;
            pbNombreUsuario.Visible = false;
            pbCorreoMal.Visible = false;
            pbNombreUsuarioMal.Visible = false;

            if (txtNombreApodo.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de usuario del correo");
                txtNombreApodo.Focus();
            }
            else if (txtCorreo.Text == "")
            {
                MessageBox.Show("Por favor ingrese su correo electrónico");
                txtCorreo.Focus();
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

                ConsultaApodo();
            }
            catch (Exception)
            {
                txtCorreo.Clear();
                txtNombreApodo.Clear();
                pbCorreoMal.Visible = true;
                MessageBox.Show("El correo: " + comparacioncorreo + " no existe");
            }
        }

        private void ConsultaApodo()
        {
            string comparacionapodo = "";
            try
            {
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

                pbCorreo.Visible = true;
                pbNombreUsuario.Visible = true;

                txtCorreo.Enabled = false;
                txtNombreApodo.Enabled = false;

                MessageBox.Show("Verificación correcta ahora puede modificar su nueva contraseña");

                label4.Visible = true;
                label5.Visible = true;
                txtContra.Visible = true;
                txtConf_contra.Visible = true;
                pbMostrarConAct.Visible = true;
                pbMostrarConActConf.Visible = true;
                btnCambiarOlvidoContra.Visible = true;
            }
            catch (Exception)
            {
                txtCorreo.Clear();
                txtNombreApodo.Clear();
                pbNombreUsuarioMal.Visible = true;
                MessageBox.Show("No es el apodo: " + comparacionapodo + " correcto sobre el correo ingresado");
                return;
            }
        }
    }
}
