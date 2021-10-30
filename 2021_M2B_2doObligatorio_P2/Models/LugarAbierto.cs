using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2021_M2B_2doObligatorio_P2.Models
{
    public class LugarAbierto : Lugar
    {
        private static double PrecioDeCadaButaca = 250;
        // Ver como se implementaba el Id y el ultimoId


        public LugarAbierto(string nombre, double dimensiones)
        {
            Id = ultimoId2;
            ultimoId2++;
            Nombre = nombre;
            Dimensiones = dimensiones;
        }


        public static double GetPrecioDeCadaButaca()
        {
            return PrecioDeCadaButaca;
        }


        public static bool CambiarPrecioButaca(double precioNuevoButaca)
        {
            bool retorno = false;
            if (precioNuevoButaca > 0)
            {
                PrecioDeCadaButaca = precioNuevoButaca;
                retorno = true;
            }

            return retorno;
        }

        public override string ToString()
        {
            return base.ToString() + $" Precio por butaca: { PrecioDeCadaButaca}";
        }

    }
}
