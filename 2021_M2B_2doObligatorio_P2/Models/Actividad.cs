using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2021_M2B_2doObligatorio_P2.Models
{
    public class Actividad
    {

        private static int ultimoId1 = 1;
        public int Id { get; }
        public string NombreActividad { get; set; }
        public DateTime FechaYhoraActividad { get; set; }
        public int IdLugar { get; set; }
        public EdadMinimaPermitida EdadMinima { get; set; }

        public static double PrecioBaseActividad = 350;

        public Categoria Categoria { get; set; }
        public int ContadorMeGusta { get; set; }



        public Actividad(string nombreActividad, DateTime fechaYhoraActividad, int idLugar, EdadMinimaPermitida edadMinima, Categoria categoria, int contadorMeGusta)
        {
            Id = ultimoId1;
            ultimoId1++;
            NombreActividad = nombreActividad;
            FechaYhoraActividad = fechaYhoraActividad;
            IdLugar = idLugar;
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





        public override string ToString()
        {
            return $"Id {Id} NombreActividad: {NombreActividad} \n FechaYhoraActividad: {FechaYhoraActividad}  IdLugar: {IdLugar} EdadMinima: {EdadMinima} PrecioBaseActividad: {PrecioBaseActividad} \n Categoria: {Categoria} ContadorMeGusta: {ContadorMeGusta}";

        }

    }
}
