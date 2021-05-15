using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV1.Entidades
{
    public class Usuarios
    {
        private string NombreUsu;
        private string Contraseña;
        private string Correo;


        public Usuarios(string usuario, string contraseña, string correo)
        {
            NombreUsu = usuario;
            Contraseña = contraseña;
            Correo = correo;
        }

        public Usuarios()
        {

        }
        public string UsuarioPersona
        {
            get => NombreUsu;
            set => NombreUsu = value;
        }

        public string contraseñaPersona
        {
            get => Contraseña;
            set => Contraseña = value;
        }

        public string correoPersona
        {
            get => Correo;
            set => Correo = value;
        }
    }
}
