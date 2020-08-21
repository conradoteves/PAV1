using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBugs.Clases
{
    class Usuario
    {
        //Atributos de la clase Usuario
        private int id_usuario;
        private string n_usuario;
        private string password;
        private string email;
        private int id_perfil;

        public Usuario(int id_usuario, string n_usuario, string password, string email, int id_perfil)
        {
            this.id_usuario = id_usuario;
            this.n_usuario = n_usuario;
            this.password = password;
            this.email = email;
            this.id_perfil = id_perfil;
        }

        //Metodos de seteo de la la clase Usuario
        public int Id_usuario //Propiedad del mismo tipo que el atributo, NO tiene parentesis solo se usa para el GET y SET
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }

        public string N_usuario //Propiedad del mismo tipo que el atributo
        {
            get { return n_usuario; }
            set { n_usuario = value; }
        }

        //Usando el generador propio del IDE
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public int Id_perfil { get => id_perfil; set => id_perfil = value; }

        //Metedo de validacion de usuario en la BD
        public int Validar_Usuario(string nombre, string clave)
        {
                            
            return 0;
        }
    }
}
