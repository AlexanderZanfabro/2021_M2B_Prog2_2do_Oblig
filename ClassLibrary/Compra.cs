using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
   public class Compra
    {
        private static int ultimoId3 = 1;
        public int Id { get; }
        public Actividad ActividadComprada { get; set; }

        public int CantidadEntradas { get; set; }
        public int IdUsuarioQueCompra { get; set; }
        public DateTime? FechaYhora { get; set; }
        public string Estado { get; set; }
        public double PrecioFinalEntrada { get; set; }

        public Compra(Actividad ActividadComprada, int cantidadEntradas, int idUsuarioQueCompra, DateTime fechaYhora, string estado, double precioFinalEntrada)
        {
            Id = ultimoId3;
            ultimoId3++;
            // Id = id;

            this.ActividadComprada = ActividadComprada;
            CantidadEntradas = cantidadEntradas;
            IdUsuarioQueCompra = idUsuarioQueCompra;
            FechaYhora = fechaYhora;
            Estado = estado;
            PrecioFinalEntrada = precioFinalEntrada;
        }

        public override string ToString()
        {
            return $" Id {Id} ActividadComprada {ActividadComprada} CantidadEntradas ´{CantidadEntradas} \n IdUsuarioQueCompra {IdUsuarioQueCompra} FechaYhora {FechaYhora} \n Estado {Estado} PrecioFinalEntrada {PrecioFinalEntrada}";
        }
    }
}
