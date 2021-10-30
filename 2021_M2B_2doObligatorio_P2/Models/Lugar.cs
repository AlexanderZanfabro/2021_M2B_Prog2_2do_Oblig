using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2021_M2B_2doObligatorio_P2.Models
{
    public class Lugar
    {
        protected static int ultimoId2 = 1;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Dimensiones { get; set; }
        //  public string Tipo { get; set; }
        //  public bool Accesibilidad { get; set; }
        //  public double CostoMantenimiento { get; set; }

        /* public Lugar(string nombre, double dimensiones, string tipo, bool accesibilidad, double costoMantenimiento)
         {
             Id = ultimoId2;
             ultimoId2++;
             Nombre = nombre;
             Dimensiones = dimensiones;
             Tipo = tipo;
             Accesibilidad = accesibilidad;
             CostoMantenimiento = costoMantenimiento;
         }*/

        //public bool validacionLugar(p1){
        //    bool elLugar = false;

        //    if("abierto" == p1){
        //          elLugar = true
        //    } else {
        //      
        //    }
        //}

        public override string ToString()
        {
            return $"Id {Id} Nombre {Nombre} Dimensiones {Dimensiones} ";

        }

    }
}
