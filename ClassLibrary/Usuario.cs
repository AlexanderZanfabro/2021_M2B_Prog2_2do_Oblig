using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
  public class Usuario
    {
        private static int ultimoId4 = 1;
        public int Id { get; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string Rol = "Invitado";
        public bool Activo = true;

        // definir como se cambia el Rol y como lo inicio.  Esta bien usar el null en este caso?

        public Usuario(string nombre, string apellido, string email, DateTime fechaNacimiento, string nombreUsuario, string contrasenia)
        {
            Id = ultimoId4;
            ultimoId4++;
            // Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            FechaNacimiento = fechaNacimiento;
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;
           
        }

        public override string ToString()
        {
            return $" Id {Id} Nombre {Nombre} Apellido {Apellido} Email {Email} FechaNacimiento {FechaNacimiento} Nombre de Usuario {NombreUsuario} Contraseña {Contrasenia} Rol {Rol} Estado activo {Activo}";
        }



        public string GetRol()
        {
            return Rol;
        }


        public bool CambioRol(string rol)
        {
            bool retorno = false;
            if (rol == "Operador")
            {
                Rol = "Operador";
                retorno = true;
            }else if(rol == "Registrado")
            {
                Rol = "Registrado";
                retorno = true;
            }
           

            return retorno;
        }

       
    }
}
