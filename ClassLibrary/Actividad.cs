using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Actividad
    {
        private static int ultimoId1 = 1;
        public int Id { get; }
        public string NombreActividad { get; set; }
        public DateTime FechaYhoraActividad { get; set; }
        public Lugar Lugar { get; set; }
        public EdadMinimaPermitida EdadMinima { get; set; }

        public static double PrecioBaseActividad = 350;

        public Categoria Categoria { get; set; }
        public int ContadorMeGusta { get; set; }



        public Actividad(string nombreActividad, DateTime fechaYhoraActividad, Lugar lugar, EdadMinimaPermitida edadMinima, Categoria categoria, int contadorMeGusta)
        {
            Id = ultimoId1;
            ultimoId1++;
            NombreActividad = nombreActividad;
            FechaYhoraActividad = fechaYhoraActividad;
            Lugar = lugar;
            EdadMinima = edadMinima;

            Categoria = categoria;
            ContadorMeGusta = contadorMeGusta;
        }


        public enum EdadMinimaPermitida
        {
            P = 1,
            C13 = 2,
            C16 = 3,
            C18 = 4
        }



      public double CalcularPrecioFinal2()
        { double a = 0;

            a = 1500;

            return a;
        }

       


        public override string ToString()
        {
            return $"Id {Id} NombreActividad: {NombreActividad} \n FechaYhoraActividad: {FechaYhoraActividad}  Lugar: {Lugar} EdadMinima: {EdadMinima} PrecioBaseActividad: {PrecioBaseActividad} \n Categoria: {Categoria} ContadorMeGusta: {ContadorMeGusta}";

        }

    }
}
