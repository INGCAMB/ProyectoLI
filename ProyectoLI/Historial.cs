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
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
            ConsultarRegistros();
        }

        private void btnBorrarHistorial_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere borrar el historial?", "¿Borrar historial?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                codigo.Connection = conectar;
                codigo.CommandText = "delete from historial where id_usuario = " + VariablesGlobales.IdDeUsuarioActivo + ";";
                codigo.ExecuteNonQuery();
                conectar.Close();

                MessageBox.Show("Historial eliminado.");
                ConsultarRegistros();
            }
        }

        private void ConsultarRegistros()
        {
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                codigo.Connection = conectar;
                codigo.CommandText = "select grado, prueba, calificacion, fecha from historial where id_usuario = " + VariablesGlobales.IdDeUsuarioActivo + ";";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(codigo);
                DataTable datostabla = new DataTable();
                adaptador.Fill(datostabla);
                dataGVBuscarHistorial.DataSource = datostabla;
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la base de datos:\n\n" + ex);
            }
        }
    }
}
