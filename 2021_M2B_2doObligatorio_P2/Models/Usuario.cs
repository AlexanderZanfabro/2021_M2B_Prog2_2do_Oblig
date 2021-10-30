using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2021_M2B_2doObligatorio_P2.Models
{
    public class Usuario
    {
        private static int ultimoId4 = 1;
        public int Id { get; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Usuario(string nombre, string apellido, string email, DateTime fechaNacimiento)
        {
            Id = ultimoId4;
            ultimoId4++;
            // Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            FechaNacimiento = fechaNacimiento;
        }

        public override string ToString()
        {
            return $" Id {Id} Nombre {Nombre} Apellido {Apellido} Email {Email} FechaNacimiento {FechaNacimiento} ";
        }

    }
}
