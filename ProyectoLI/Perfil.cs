using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using MySql.Data.MySqlClient;

namespace ProyectoLI
{
    public partial class Perfil : Form
    {
        //Variables para guardar los datos viejos de la base de datos
        string NombreViejo = "", CorreoViejo = "", ContraVieja = "", NombreUsuarioViejo = "";

        public Perfil()
        {
            InitializeComponent();
            lblPerfil.Text = "Perfil de usuario";
            lblId.Text = "Id del usuario:";
            lblTipo.Visible = false;
            txtTipo.Visible = false;
            ConsultarDatos();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RealizarCambios();
        }

        private void btnModificarDatos_Click(object sender, EventArgs e)
        {
            pbMostrarConAct.Visible = true;
            pbMostrarConAct.Enabled = true;

            lblPerfil.Text = "Modificar datos de cuenta";

            txtId.Text = "";

            btnAceptar.Visible = true;
            btnAceptar.Enabled = false;
            btnCambioContra.Visible = false;
            btnCambioContra.Enabled = true;

            lblNombreUsuario.Visible = true;
            txtNombreUsuario.Visible = true;
            lblNombre.Visible = true;
            txtNombre.Visible = true;
            lblCorreo.Visible = true;
            txtCorreo.Visible = true;
            lblId.Visible = true;
            txtId.Visible = true;
            lblTipo.Visible = false;
            txtTipo.Visible = false;

            txtNombreUsuario.ReadOnly = false;
            txtNombre.ReadOnly = false;
            txtCorreo.ReadOnly = true;
            txtId.ReadOnly = false;
            txtTipo.ReadOnly = false;

            lblId.Text = "Contraseña actual:";
            txtId.UseSystemPasswordChar = true;

            Consulta();
        }

        private void btnModificarContra_Click(object sender, EventArgs e)
        {
            pbMostrarConAct.Visible = true;
            pbMostrarConAct.Enabled = true;
            pbMostrarConNue.Visible = true;
            pbMostrarConNue.Enabled = true;

            lblPerfil.Text = "Modificar contraseña";

            txtId.Text = "";
            txtTipo.Text = "";

            btnAceptar.Visible = false;
            btnAceptar.Enabled = true;
            btnCambioContra.Visible = true;
            btnCambioContra.Enabled = false;

            lblNombreUsuario.Visible = false;
            txtNombreUsuario.Visible = false;
            lblNombre.Visible = false;
            txtNombre.Visible = false;
            lblCorreo.Visible = true;
            txtCorreo.Visible = true;
            lblId.Visible = true;
            txtId.Visible = true;
            lblTipo.Visible = true;
            txtTipo.Visible = true;

            txtNombreUsuario.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtCorreo.ReadOnly = true;
            txtId.ReadOnly = false;
            txtTipo.ReadOnly = false;

            lblId.Text = "Contraseña actual:";
            txtId.UseSystemPasswordChar = true;
            txtTipo.UseSystemPasswordChar = true;

            Consulta();
        }

        private void btnCambioContra_Click(object sender, EventArgs e)
        {
            RealizarCambiosDeContra();
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
            if(txtId.Text == "")
            {
                btnCambioContra.Enabled = false;
            }
            else
            {
                btnCambioContra.Enabled = true;
            }
        }

        public void Limpiar()
        {
            txtNombreUsuario.Clear();
            txtNombre.Clear();
            txtCorreo.Clear();
            txtId.Clear();
            txtTipo.Clear();
        }

        public void ConsultarDatos()
        {
            //Conexion ya sea por localhost o por servidor
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
            //Abrimos conexion
            conectar.Open();
            //Abrimos objeto para comando mysql
            MySqlCommand codigo = new MySqlCommand();
            //Nos conectamos
            MySqlConnection conectanos = new MySqlConnection();
            //Hacemos conexion con los comandos de mysql con la base de datos 
            codigo.Connection = conectar;
            //Escribimos el comando para consultar un correo del txtCorreo de la tabla usuarios
            codigo.CommandText = "select * from usuarios where correo = \"" + VariablesGlobales.CorreoDelUsuarioActivo + "\";";
            //Leemos los datos del registro buscado
            MySqlDataReader leer = codigo.ExecuteReader();
            leer.Read();
            //Los guardamos en las variables los obtenemos con su tipo de dato y la posicion en la que se encuentran en la base de datos
            NombreViejo = leer.GetString(1);
            CorreoViejo = leer.GetString(2);
            NombreUsuarioViejo = leer.GetString(5);
            //Cerramos la conexion
            conectar.Close();

            //Las insertamos a la vista del usuario en las textbox
            txtNombre.Text = NombreViejo;
            txtCorreo.Text = CorreoViejo;
            txtNombreUsuario.Text = NombreUsuarioViejo;

            txtId.Text = VariablesGlobales.IdDeUsuarioActivo.ToString();
            txtTipo.Text = VariablesGlobales.NombreApodoUsuario;

            //Guardamos el nombre y el correo actualizado
            txtNombre.Text = VariablesGlobales.NombreDeUsuarioActivo;
            txtCorreo.Text = VariablesGlobales.CorreoDelUsuarioActivo;
            txtNombreUsuario.Text = VariablesGlobales.NombreApodoUsuario;
        }

        private void pbMostrarConAct_Click(object sender, EventArgs e)
        {
            txtId.UseSystemPasswordChar = false;
            pbMostrarConAct.Visible = false;
            pbMostrarConAct.Enabled = false;
            pbOcultarConAct.Visible = true;
            pbOcultarConAct.Enabled = true;
        }

        private void pbOcultarConAct_Click(object sender, EventArgs e)
        {
            txtId.UseSystemPasswordChar = true;
            pbMostrarConAct.Visible = true;
            pbMostrarConAct.Enabled = true;
            pbOcultarConAct.Visible = false;
            pbOcultarConAct.Enabled = false;
        }

        private void pbMostrarConNue_Click(object sender, EventArgs e)
        {
            txtTipo.UseSystemPasswordChar = false;
            pbMostrarConNue.Visible = false;
            pbMostrarConNue.Enabled = false;
            pbOcultarConNue.Visible = true;
            pbOcultarConNue.Enabled = true;
        }

        private void pbOcultarConNue_Click(object sender, EventArgs e)
        {
            txtTipo.UseSystemPasswordChar = true;
            pbMostrarConNue.Visible = true;
            pbMostrarConNue.Enabled = true;
            pbOcultarConNue.Visible = false;
            pbOcultarConNue.Enabled = false;
        }

        public void Consulta()
        {
            //Conexion ya sea por localhost o por servidor
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = "select * from usuarios where correo = \"" + VariablesGlobales.CorreoDelUsuarioActivo + "\";";
            MySqlDataReader leer = codigo.ExecuteReader();
            leer.Read();
            NombreViejo = leer.GetString(1);
            CorreoViejo = leer.GetString(2);
            ContraVieja = leer.GetString(3);
            NombreUsuarioViejo = leer.GetString(5);
            conectar.Close();

            txtNombre.Text = NombreViejo;
            txtCorreo.Text = CorreoViejo;
            txtNombreUsuario.Text = NombreUsuarioViejo;
        }

        //Metodo de RealizarCambios para poder modificar los datos viejos a los nuevos que el usuario esta ingresando
        public void RealizarCambios()
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Ingresa contraseña.");
            }
            else if (ContraVieja == txtId.Text)
            {
                try
                {
                    //Conexion ya sea por localhost o por servidor
                    MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
                    conectar.Open();
                    MySqlCommand codigo = new MySqlCommand();
                    MySqlConnection conectanos = new MySqlConnection();
                    codigo.Connection = conectar;
                    codigo.CommandText = "update usuarios set nombre = \"" + txtNombre.Text + "\", contra = \"" +
                        txtId.Text + "\", nombreusu = \"" + txtNombreUsuario.Text + "\" where correo = \"" +
                        txtCorreo.Text + "\";";
                    codigo.ExecuteNonQuery();
                    conectar.Close();

                    VariablesGlobales.NombreApodoUsuario = txtNombreUsuario.Text;
                    VariablesGlobales.NombreDeUsuarioActivo = txtNombre.Text;
                    VariablesGlobales.CorreoDelUsuarioActivo = txtCorreo.Text;

                    Limpiar();

                    MessageBox.Show("Cambios realizados exitosamente.");

                    Consulta();

                    btnAceptar.Visible = false;
                    btnAceptar.Enabled = true;

                    txtId.Text = VariablesGlobales.IdDeUsuarioActivo.ToString();
                    lblPerfil.Text = "Perfil de usuario";
                    lblId.Text = "Id del usuario:";
                    lblTipo.Visible = false;
                    txtTipo.Visible = false;

                    txtNombreUsuario.ReadOnly = true;
                    txtNombre.ReadOnly = true;
                    txtCorreo.ReadOnly = true;
                    txtId.ReadOnly = true;

                    txtId.UseSystemPasswordChar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cambiar los datos:\n" + ex);
                }
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta, favor de intentarlo de nuevo.");
            }
        }

        //Metodo de RealizarCambios para poder modificar los datos viejos a los nuevos que el usuario esta ingresando
        public void RealizarCambiosDeContra()
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Ingresa contraseña actual.");
            }
            else if (txtTipo.Text == "")
            {
                MessageBox.Show("Ingresa contraseña nueva.");
            }
            else if (txtId.Text == ContraVieja)
            {
                try
                {
                    //Conexion ya sea por localhost o por servidor
                    MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
                    conectar.Open();
                    MySqlCommand codigo = new MySqlCommand();
                    MySqlConnection conectanos = new MySqlConnection();
                    codigo.Connection = conectar;
                    codigo.CommandText = "update usuarios set contra = \"" + txtTipo.Text + "\" where correo = \"" +
                        txtCorreo.Text + "\";";
                    codigo.ExecuteNonQuery();
                    conectar.Close();

                    Limpiar();

                    MessageBox.Show("Contraseña actualizada");

                    Consulta();

                    btnCambioContra.Visible = false;
                    btnCambioContra.Enabled = true;

                    txtId.Text = VariablesGlobales.IdDeUsuarioActivo.ToString();
                    lblPerfil.Text = "Perfil de usuario";
                    lblId.Text = "Id del usuario:";
                    lblTipo.Visible = false;
                    txtTipo.Visible = false;
                    lblNombreUsuario.Visible = true;
                    txtNombreUsuario.Visible = true;
                    lblNombre.Visible = true;
                    txtNombre.Visible = true;


                    txtNombreUsuario.ReadOnly = true;
                    txtNombre.ReadOnly = true;
                    txtCorreo.ReadOnly = true;
                    txtId.ReadOnly = true;

                    txtId.UseSystemPasswordChar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cambiar los datos:\n" + ex);
                }
            }
            else
            {
                MessageBox.Show("Contraseña actual incorrecta, favor de intentarlo de nuevo.");
            }
        }
    }
}
