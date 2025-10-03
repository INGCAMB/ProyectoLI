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
    public partial class PrimerGrado : Form
    {
        public PrimerGrado()
        {
            InitializeComponent();
        }

        private void pbMate_Click(object sender, EventArgs e)
        {
            string mate = "";
            if (VariablesGlobales.GradoSeleccionado == 1)
            {
                mate = "preguntasmate1";
            }
            else if (VariablesGlobales.GradoSeleccionado == 2)
            {
                mate = "preguntasmate2";
            }
            else if (VariablesGlobales.GradoSeleccionado == 3)
            {
                mate = "preguntasmate3";
            }
            VariablesGlobales.TipoDeMateria = "mate";

            try
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                codigo.Connection = conectar;
                codigo.CommandText = "select preg from " + mate + ";";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(codigo);
                DataTable datostabla = new DataTable();
                adaptador.Fill(datostabla);
                dataGVEjercicios.DataSource = datostabla;
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la base de datos:\n\n" + ex);
            }
        }

        private void pbEsp_Click(object sender, EventArgs e)
        {
            string esp = "";
            if (VariablesGlobales.GradoSeleccionado == 1)
            {
                esp = "preguntasesp1";
            }
            else if (VariablesGlobales.GradoSeleccionado == 2)
            {
                esp = "preguntasesp2";
            }
            else if (VariablesGlobales.GradoSeleccionado == 3)
            {
                esp = "preguntasesp3";
            }
            VariablesGlobales.TipoDeMateria = "esp";

            try
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                codigo.Connection = conectar;
                codigo.CommandText = "select preg from " + esp + ";";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(codigo);
                DataTable datostabla = new DataTable();
                adaptador.Fill(datostabla);
                dataGVEjercicios.DataSource = datostabla;
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la base de datos:\n\n" + ex);
            }
        }

        private void pbIng_Click(object sender, EventArgs e)
        {
            string ing = "";
            if (VariablesGlobales.GradoSeleccionado == 1)
            {
                ing = "preguntasing1";
            }
            else if (VariablesGlobales.GradoSeleccionado == 2)
            {
                ing = "preguntasing2";
            }
            else if (VariablesGlobales.GradoSeleccionado == 3)
            {
                ing = "preguntasing3";
            }
            VariablesGlobales.TipoDeMateria = "ing";

            try
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                codigo.Connection = conectar;
                codigo.CommandText = "select preg from " + ing + ";";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(codigo);
                DataTable datostabla = new DataTable();
                adaptador.Fill(datostabla);
                dataGVEjercicios.DataSource = datostabla;
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la base de datos:\n\n" + ex);
            }
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas empezar la prueba?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                frmPruebas prueba = new frmPruebas();
                prueba.Show();
                /*this.Controls.Clear();
                frmMenu menu = new frmMenu();
                menu.Close();*/
            }
        }
    }
}
