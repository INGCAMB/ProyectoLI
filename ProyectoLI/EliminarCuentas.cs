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

namespace ProyectoLI
{
    public partial class EliminarCuentas : Form
    {
        public EliminarCuentas()
        {
            InitializeComponent();
            ConsultaAlumnos();
        }

        private void ConsultaAlumnos()
        {
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                codigo.Connection = conectar;
                codigo.CommandText = "select id_usuario, nombre, correo, nombreusu from usuarios where admin = false;";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(codigo);
                DataTable datostabla = new DataTable();
                adaptador.Fill(datostabla);
                dataGVBuscadorCuentas.DataSource = datostabla;
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\n" + ex);
            }
        }

        private void dataGVBuscadorCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento de click en la dataGridView donde pasa registros de la tabla productos a cajas de texto haciendo doble click.
            txtId.Text = dataGVBuscadorCuentas.CurrentRow.Cells[0].Value.ToString();
            txtCorreoEliminar.Text = dataGVBuscadorCuentas.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnBorrarCuentas_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere borrar a este alumno?", "¿Borrar historial?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string CorreoComp = "";
                try
                {
                    MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
                    conectar.Open();
                    MySqlCommand codigo = new MySqlCommand();
                    MySqlConnection conectanos = new MySqlConnection();
                    codigo.Connection = conectar;
                    codigo.CommandText = "select * from usuarios where correo = \"" + txtCorreoEliminar.Text + "\";";
                    MySqlDataReader leer = codigo.ExecuteReader();
                    leer.Read();
                    CorreoComp = leer.GetString(2);
                    conectar.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: \n" + ex);
                }

                if (txtCorreoEliminar.Text == CorreoComp)
                {
                    BorrarHistorialCuentas();
                    MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
                    conectar.Open();
                    MySqlCommand codigo = new MySqlCommand();
                    MySqlConnection conectanos = new MySqlConnection();
                    codigo.Connection = conectar;
                    codigo.CommandText = "delete from usuarios where correo = \"" + txtCorreoEliminar.Text + "\";";
                    codigo.ExecuteNonQuery();
                    conectar.Close();
                    MessageBox.Show("La cuenta fue eliminada exitosamente");

                    txtId.Clear();
                    txtCorreoEliminar.Clear();
                    ConsultaAlumnos();
                }
                else
                {
                    MessageBox.Show("El correo es incorrecto, intente de nuevo.");
                    txtId.Clear();
                    txtCorreoEliminar.Clear();
                }
            }
        }

        private void BorrarHistorialCuentas()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = "delete from historial where id_usuario = " + txtId.Text + ";";
            codigo.ExecuteNonQuery();
            conectar.Close();
        }
    }
}
