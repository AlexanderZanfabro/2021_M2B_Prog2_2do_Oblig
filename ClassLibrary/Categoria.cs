using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
   public class Categoria
    {
        public static int lastIdCat = 1;
        public int Id { get; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Categoria(string nombre, string descripcion)
        {
            Id = lastIdCat;
            lastIdCat++;

            Nombre = nombre;
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            return $"Id {Id} Nombre {Nombre} \n Descripcion {Descripcion}";
        }
    }
}
