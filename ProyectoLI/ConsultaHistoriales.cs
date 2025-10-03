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
    public partial class ConsultaHistoriales : Form
    {
        public ConsultaHistoriales()
        {
            InitializeComponent();
            Consultainicial();
        }

        private void Consultainicial()
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
                dataGVConsultaHistoriales.DataSource = datostabla;
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\n" + ex);
            }
        }

        private void ConsultarCalificacionesTodos()
        {
            try
            {
                //No hace bien consulta, hay que hacer que haga consulta a dos tablas para
                //conseguir los resultados de los examenes y del nombre de los alumnos;
                //Consultar la tabla de Usuarios con los alumnos, y la tabla Historial.
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                codigo.Connection = conectar;
                codigo.CommandText = "select nombre, calificacion, fecha, prueba, grado from usuarios, historial where admin = false and usuarios.id_usuario = historial.id_usuario;";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(codigo);
                DataTable datostabla = new DataTable();
                adaptador.Fill(datostabla);
                dataGVConsultaHistoriales.DataSource = datostabla;
                conectar.Close();

                //\"" + VariablesGlobales.MaestroDeMateria + "\" and
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\n" + ex);
            }
        }

        private void ConsultarPorCalificacionExamenes()
        {
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                codigo.Connection = conectar;
                codigo.CommandText = "select nombre, calificacion, fecha, prueba, grado from usuarios, historial where calificacion = " + comboBox3.Text + " and admin = false" +
                    " and usuarios.id_usuario = historial.id_usuario;";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(codigo);
                DataTable datostabla = new DataTable();
                adaptador.Fill(datostabla);
                dataGVConsultaHistoriales.DataSource = datostabla;
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\n" + ex);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Calificaciones")
            {
                label2.Visible = true;
                comboBox2.Visible = true;

                ConsultarCalificacionesTodos();
            }
            else
            {
                label2.Visible = false;
                label3.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;

                Consultainicial();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Aprobados")
            {
                label3.Visible = false;
                comboBox3.Visible = false;
                try
                {
                    MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
                    conectar.Open();
                    MySqlCommand codigo = new MySqlCommand();
                    MySqlConnection conectanos = new MySqlConnection();
                    codigo.Connection = conectar;
                    codigo.CommandText = "select nombre, calificacion, fecha, prueba, grado from usuarios, historial where calificacion > 6 and admin = false and " +
                        "usuarios.id_usuario = historial.id_usuario;";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(codigo);
                    DataTable datostabla = new DataTable();
                    adaptador.Fill(datostabla);
                    dataGVConsultaHistoriales.DataSource = datostabla;
                    conectar.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:\n\n" + ex);
                }
            }
            else if (comboBox2.Text == "Reprobados")
            {
                label3.Visible = false;
                comboBox3.Visible = false;
                try
                {
                    MySqlConnection conectar = new MySqlConnection("server=localhost; database=acadebd; Uid=root; pwd=;");
                    conectar.Open();
                    MySqlCommand codigo = new MySqlCommand();
                    MySqlConnection conectanos = new MySqlConnection();
                    codigo.Connection = conectar;
                    codigo.CommandText = "select nombre, calificacion, fecha, prueba, grado from usuarios, historial where calificacion < 7 and admin = false and usuarios.id_usuario = historial.id_usuario;";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(codigo);
                    DataTable datostabla = new DataTable();
                    adaptador.Fill(datostabla);
                    dataGVConsultaHistoriales.DataSource = datostabla;
                    conectar.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:\n\n" + ex);
                }
            }
            else if (comboBox2.Text == "Calificación")
            {
                label3.Visible = true;
                comboBox3.Visible = true;
                ConsultarPorCalificacionExamenes();
            }
            else
            {
                label3.Visible = false;
                comboBox3.Visible = false;
                ConsultarCalificacionesTodos();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultarPorCalificacionExamenes();
        }
    }
}
