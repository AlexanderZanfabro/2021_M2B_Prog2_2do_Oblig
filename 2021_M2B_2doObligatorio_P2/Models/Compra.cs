using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2021_M2B_2doObligatorio_P2.Models
{
    public class Compra
    {
        private static int ultimoId3 = 1;
        public int Id { get; }
        public int IdActividadComprada { get; set; }

        public int CantidadEntradas { get; set; }
        public int IdUsuarioQueCompra { get; set; }
        public DateTime FechaYhora { get; set; }
        public string Estado { get; set; }
        public double PrecioFinalEntrada { get; set; }

        public Compra(int idActividadComprada, int cantidadEntradas, int idUsuarioQueCompra, DateTime fechaYhora, string estado, double precioFinalEntrada)
        {
            Id = ultimoId3;
            ultimoId3++;
            // Id = id;

            IdActividadComprada = idActividadComprada;
            CantidadEntradas = cantidadEntradas;
            IdUsuarioQueCompra = idUsuarioQueCompra;
            FechaYhora = fechaYhora;
            Estado = estado;
            PrecioFinalEntrada = precioFinalEntrada;
        }

        public override string ToString()
        {
            return $" Id {Id} IdActividadComprada {IdActividadComprada} CantidadEntradas ´{CantidadEntradas} \n IdUsuarioQueCompra {IdUsuarioQueCompra} FechaYhora {FechaYhora} \n Estado {Estado} PrecioFinalEntrada {PrecioFinalEntrada}";
        }

    }
}
