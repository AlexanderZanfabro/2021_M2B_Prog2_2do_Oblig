using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
   public class LugarCerrado : Lugar
    {
        public bool Accesibilidad { get; set; }
        public double CostoMantenimiento { get; set; }

        private static int aforoMaximoPermitido = 100; // Inicia en un 100 % --> Aforo ideal para el negocio.



        public LugarCerrado(string nombre, double dimensiones, bool accesibilidad, double costoMantenimiento)
        {
            Id = ultimoId2;
            ultimoId2++;
            Nombre = nombre;
            Dimensiones = dimensiones;
            Accesibilidad = accesibilidad;
            CostoMantenimiento = costoMantenimiento;

        }




        public static int GetAforoMaximoPermitido()
        {
            return aforoMaximoPermitido;

        }

        public static bool AccesoCambioAforo(int a)
        {
            bool ret = false;
            if (a > 0 && a < 100)
            {
                aforoMaximoPermitido = a;
                ret = true;
            }
            return ret;
        }

        /* El sistema posee un valor (en porcentaje) que representa el aforo máximo permitido para espectáculos cerrados, 
   que va variando conforme la situación sanitaria permite aumentar o disminuir.
    */



        //          Si la actividad se realiza en un lugar cerrado al precio base se le agrega un costo que varía según el aforo
        //          permitido por ley, ya que si el aforo es inferior al 50 % el precio aumenta un 30% del costo base, y si el
        //          aforo está entre el 50 y 70 % se le agrega un 15 % del costo base.



        public override string ToString()
        {
            return base.ToString() + $"Costo de mantenimiento: {CostoMantenimiento}" + $" Aforo maximo permitido: {aforoMaximoPermitido}";
        }


    }
}
