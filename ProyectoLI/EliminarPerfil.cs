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
    public partial class frmEliminarPerfil : Form
    {
        public frmEliminarPerfil()
        {
            InitializeComponent();
            contra.UseSystemPasswordChar = true;
        }

        private void btnBorrarCuenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres borrar tu cuenta?", "¿Borrar historial?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string ContraComp = "";
                try
                {
                    MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
                    conectar.Open();
                    MySqlCommand codigo = new MySqlCommand();
                    MySqlConnection conectanos = new MySqlConnection();
                    codigo.Connection = conectar;
                    codigo.CommandText = "select * from usuarios where correo = \"" + VariablesGlobales.CorreoDelUsuarioActivo + "\";";
                    MySqlDataReader leer = codigo.ExecuteReader();
                    leer.Read();
                    ContraComp = leer.GetString(3);
                    conectar.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: \n" + ex);
                }

                if (contra.Text == ContraComp)
                {
                    BorrarHistorial();
                    MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
                    conectar.Open();
                    MySqlCommand codigo = new MySqlCommand();
                    MySqlConnection conectanos = new MySqlConnection();
                    codigo.Connection = conectar;
                    codigo.CommandText = "delete from usuarios where correo = \"" + VariablesGlobales.CorreoDelUsuarioActivo + "\";";
                    codigo.ExecuteNonQuery();
                    conectar.Close();
                    MessageBox.Show("La cuenta fue eliminada exitosamente");

                    frmLogin login = new frmLogin();
                    login.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta, intente de nuevo.");
                    contra.Text = "";
                    contra.Focus();
                }
            }
        }

        private void BorrarHistorial()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = "delete from historial where id_usuario = " + VariablesGlobales.IdDeUsuarioActivo + ";";
            codigo.ExecuteNonQuery();
            conectar.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void frmEliminarPerfil_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            Close();
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

        private void pbMostrarConAct_Click(object sender, EventArgs e)
        {
            contra.UseSystemPasswordChar = false;
            pbMostrarConAct.Visible = false;
            pbMostrarConAct.Enabled = false;
            pbOcultarConAct.Visible = true;
            pbOcultarConAct.Enabled = true;
        }

        private void pbOcultarConAct_Click(object sender, EventArgs e)
        {
            contra.UseSystemPasswordChar = true;
            pbMostrarConAct.Visible = true;
            pbMostrarConAct.Enabled = true;
            pbOcultarConAct.Visible = false;
            pbOcultarConAct.Enabled = false;
        }
    }
}
