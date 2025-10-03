using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLI
{
    class VariablesGlobales
    {
        //"Usuario" es el nombre que se utilizara única y exclusivamente para esta clase.
        private static string Usuario = "";

        //"NombreDeUsuario" es la variable que se utilizará en los otros formularios.
        public static string NombreDeUsuarioActivo
        {
            get { return Usuario; }
            set { Usuario = value; }
        }

        private static int Id = 0;

        public static int IdDeUsuarioActivo
        {
            get { return Id; }
            set { Id = value; }
        }

        private static string Correo = "";

        public static string CorreoDelUsuarioActivo
        {
            get { return Correo; }
            set { Correo = value; }
        }

        private static string NombreApodo = "";

        public static string NombreApodoUsuario
        {
            get { return NombreApodo; }
            set { NombreApodo = value; }
        }

        private static bool Admin = false;

        public static bool UsuarioAdministrador
        {
            get { return Admin; }
            set { Admin = value; }
        }

        private static int GradoSelec = 0;

        public static int GradoSeleccionado
        {
            get { return GradoSelec; }
            set { GradoSelec = value; }
        }

        private static int Puntos = 0;

        public static int AcumuladorDePuntos
        {
            get { return Puntos; }
            set { Puntos = value; }
        }

        private static string Tipo = "";

        public static string TipoDeMateria
        {
            get { return Tipo; }
            set { Tipo = value; }
        }
    }
}
