﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static _2021_M2B_2doObligatorio_P2.Models.Actividad;

namespace _2021_M2B_2doObligatorio_P2.Models
{
    public class Sistema
    {
        ////////////////////////////////////////////////////////////////////////////////////////// Patrón Singleton
        #region Singleton

        private static Sistema instancia = null;

        public static Sistema GetInstancia()
        {
            if (instancia == null)
            {

                instancia = new Sistema();
            }
            return instancia;
        }


        #endregion






        /////////////////////////////////////////////////////////////////////////////////// Variables del Sistema




        /////////////////////////////////////////////////////////////////////////////////// Listas

        #region Listas


        private List<Actividad> actividades = new List<Actividad>();

        private List<Categoria> categorias = new List<Categoria>();

        private List<Compra> compras = new List<Compra>();

        private List<Lugar> lugares = new List<Lugar>();

        private List<Usuario> usuarios = new List<Usuario>();

        #endregion


        /////////////////////////////////////////////////////////////////////////////////// Constructor

        public Sistema()
        {
            PrecargaDatos();
        }


        /////////////////////////////////////////////////////////////////////////////////// Gets


        #region Gets

        public List<Actividad> GetActividades() { return actividades; }

        public List<Categoria> GetCategorias() { return categorias; }

        public List<Compra> GetCompras() { return compras; }

        public List<Lugar> GetLugares() { return lugares; }

        public List<Usuario> GetUsuarios() { return usuarios; }

        #endregion




        //////////////////////////////////////////////////////////////////////////////////////////////////// Altas del Sistema

        #region Altas del Sistema

        public Actividad AltaActividad(string nombreActividad, DateTime fechaYhoraActividad, int idLugar, EdadMinimaPermitida edadMinima, Categoria categoria, int contadorMeGusta)
        {
            Actividad nueva = null;

            //faltan validaciones
            //edadMinima es del tipo enum
            bool auxAbierto = false;

            foreach (Actividad ac in actividades)
            {
                if (ac.NombreActividad == nombreActividad && ac.FechaYhoraActividad == fechaYhoraActividad && ac.IdLugar == idLugar)
                {
                    auxAbierto = true;
                }

            }

            if (!auxAbierto)
            {
                nueva = new Actividad(nombreActividad, fechaYhoraActividad, idLugar, edadMinima, categoria, contadorMeGusta);
                actividades.Add(nueva);
            }



            return nueva;
        }



        //--------------------------------------------------------------------------------------------------------------------------


        public Categoria AltaCategoria(string nombre, string descripcion)
        {
            Categoria nueva = null;

            if (nombre != "" && descripcion != "")
            {
                nueva = new Categoria(nombre, descripcion);
                categorias.Add(nueva);
            }

            return nueva;

        }



        //--------------------------------------------------------------------------------------------------------------------------


        public Compra AltaCompra(int idActividadComprada, int cantidadEntradas, int idUsuarioQueCompra, DateTime fechaYhora, string estado, double precioFinalEntrada)
        {
            Compra nueva = null;

            foreach (Usuario u in usuarios)
            {
                if (u.Id == idUsuarioQueCompra)
                {
                    nueva = new Compra(idActividadComprada, cantidadEntradas, idUsuarioQueCompra, fechaYhora, estado, precioFinalEntrada);
                    compras.Add(nueva);
                }


            }


            return nueva;
        }



        //--------------------------------------------------------------------------------------------------------------------------


        // AltaLugar pasa a ser AltaLugarAbierto y AltaLugarCerrado


        /* public Lugar AltaLugar(string nombre, double dimensiones)
         {
             Lugar nuevo = null;

             if(nombre != "")
             {
                 foreach (Lugar lu in lugares)
                 {
                     if (lu.Nombre != nombre) 
                     {
                         nuevo = new Lugar(nombre, dimensiones); // estaba mal interpretado --> acá vá un bool y 
                         lugares.Add(nuevo);                     // fuera del bucle, si no se encontró que yá existia en la lista,  
                     }                                          // otro if con el new Objeto y el .Add() a la lista.
                 }
             }



             return nuevo;
         }*/




        //--------------------------------------------------------------------------------------------------------------------------

        public LugarAbierto AltaLugarAbierto(string nombre, double dimensiones)
        {
            LugarAbierto nuevo = null;


            if (nombre != "")
            {

                bool flag = false;
                foreach (Lugar lu in lugares)
                {


                    if (lu.Nombre != nombre)
                    {
                        flag = true;
                    }


                }


                if (!flag)
                {
                    nuevo = new LugarAbierto(nombre, dimensiones);
                    lugares.Add(nuevo);
                }
            }

            return nuevo;
        }



        //--------------------------------------------------------------------------------------------------------------------------

        public LugarCerrado AltaLugarCerrado(string nombre, double dimensiones, bool accesibilidad, double costoMantenimiento)
        {
            LugarCerrado nuevo = null;


            if (nombre != "")
            {
                bool flag = false;

                foreach (Lugar lu in lugares)
                {
                    if (lu.Nombre != nombre)
                    {
                        flag = true;
                    }

                }


                if (!flag)
                {
                    nuevo = new LugarCerrado(nombre, dimensiones, accesibilidad, costoMantenimiento);
                    lugares.Add(nuevo);
                }
            }

            return nuevo;
        }


        //--------------------------------------------------------------------------------------------------------------------------



        public Usuario AltaUsuario(string nombre, string apellido, string email, DateTime fechaNacimiento)
        {
            Usuario nuevo = null;

            if (nombre != "" && apellido != "" && email != "" && fechaNacimiento < DateTime.Now)
            {

                bool aux = false;

                foreach (Usuario u in usuarios)
                {
                    if (u.Nombre == nombre && u.Apellido == apellido && u.Email == email && u.FechaNacimiento == fechaNacimiento)
                    {
                        aux = true;

                    }
                }

                if (!aux)
                {

                    nuevo = new Usuario(nombre, apellido, email, fechaNacimiento);
                    usuarios.Add(nuevo);

                }

            }

            return nuevo;
        }


        #endregion



        /////////////////////////////////////////////////////////////////////////////////// Métodos


        #region Métodos


        //----------------------------------------------Cambiar aforo máximo permitido----------------------------------------------------------------------------


        public int CambiarAforoMaximoPermitido(int a)
        {

            LugarCerrado.AccesoCambioAforo(a);

            return LugarCerrado.GetAforoMaximoPermitido();

        }



        public int GetNuevoAforo()  // Solo retorna el nuevo valor de Aforo ( es necesario en el Program)
        {

            return LugarCerrado.GetAforoMaximoPermitido();
        }

        // Deberia haber un enum con % de aforos listados (25, 30, 50, 70, 85, 100) y pedir que los seleccionen de ahí --> ( Por ahora no aplica).




        //-------------------------------------------------Lista espectáculos áptos para todo público-------------------------------------------------------------------------

        public List<Actividad> GetEspectaculosAptosTodoPublico()
        {
            List<Actividad> retorno = new List<Actividad>();


            foreach (Actividad ac in actividades)
            {
                if (ac.EdadMinima == Actividad.EdadMinimaPermitida.P)
                {

                    retorno.Add(ac);
                }
            }


            return retorno;
        }






        //-------------------------------------------------Cambiar precio de butacas-------------------------------------------------------------------------
        public double CambiarPrecioDeCadaButaca(double precioNuevoButaca)
        {
            // double nuevoPrecio = 0;
            LugarAbierto.CambiarPrecioButaca(precioNuevoButaca);



            return LugarAbierto.GetPrecioDeCadaButaca();
        }

        public double GetNuevoPrecioButaca() // Este método solo retorna el valor dentro de la propiedad precioDeCadaButaca. (Es necesario en el Program)
        {

            return LugarAbierto.GetPrecioDeCadaButaca();
        }






        //-----------------------------------------------Actividades entre 2 fechas---------------------------------------------------------------------------

        public List<Actividad> GetActividadesInRango(int selectedCategoryId, DateTime dateBusqueda1, DateTime dateBusqueda2)
        {
            List<Actividad> found = new List<Actividad>();

            if (dateBusqueda2 > dateBusqueda1)
            {
                DateTime tempVariable = dateBusqueda2;
                dateBusqueda2 = dateBusqueda1;
                dateBusqueda1 = tempVariable;
            }


            foreach (Actividad a in GetActividades())
            {
                if (a.Categoria.Id == selectedCategoryId)
                {
                    if (dateBusqueda1 < DateTime.Now && dateBusqueda2 > DateTime.Now)
                    {
                        found.Add(a);
                    }
                }
            }

            return found;
        }



        //--------------------------------------------------------------------------------------------------------------------------

        /* public int CambiarPrecioAforo(int aforo)
         {
             double elPrecio = 0;

             if (aforo < 51)
             {
                 elPrecio = Actividad.PrecioBaseActividad + ((Actividad.PrecioBaseActividad * 30 )/ 100); // (esto esta mal ) <--?
             }
             else if (aforo > 50 && aforo < 71)
             {

                 elPrecio = Actividad.PrecioBaseActividad + ((Actividad.PrecioBaseActividad * 15) / 100);
             }
             else
             {
                 elPrecio = Actividad.PrecioBaseActividad;
             }
             return (int) elPrecio;
         }*/



        //--------------------------------------------------------------------------------------------------------------------------

        /*  public double PrecioFinalDeEntradaLugarAbierto(int CantidadEntradasCompradas, string nombreDelLugar )
          {
              double aux = 1;




              foreach(Lugar lug in GetLugares())
              {

                  if (lug.Nombre == nombreDelLugar)
                  {
                      if (lug.Dimensiones > 1)
                      {
                          aux = Actividad.PrecioBaseActividad / 10;

                      }

                  }
              }
              double precioFinal = (Actividad.PrecioBaseActividad + aux ) * CantidadEntradasCompradas;

              return precioFinal;
          }*/



        #endregion


        ////////////////////////////////////////////////////////////////////////////////////////////// Precarga de Datos


        #region Precarga de Datos

        public void PrecargaDatos()
        {

            Lugar l1 = AltaLugarCerrado("Antel Arena", 0.2, true, 100000);      // Cerrado
            Lugar l2 = AltaLugarAbierto("Velodromo", 1.1);                      //Abierto
            Lugar l3 = AltaLugarCerrado("Movie Montevideo", 0.1, false, 9000);  //Cerrado 
            Lugar l4 = AltaLugarAbierto("Teatro de Verano", 0.25);              //Abierto
            Lugar l5 = AltaLugarCerrado("Auditorio Sodre", 0.85, false, 11000); //Cerrado

            Categoria c1 = AltaCategoria("Teatro", "Representaciones artisticas y culturales de indole nacional ó internacional");
            Categoria c2 = AltaCategoria("Deporte", "Actividades de indole física llevadas a cabo en formato de competencia");
            Categoria c3 = AltaCategoria("Cine", "Proyección audiovisual de tipo comercial ó cultural");
            Categoria c4 = AltaCategoria("Concierto", "Representaciones musicales realizadas por una persona (solista) ó un conjunto de varias personas (banda ó grupo)");

            Actividad a1 = AltaActividad("Concierto de U2", DateTime.Parse("2021-08-20"), 1, Actividad.EdadMinimaPermitida.C18, c4, 5000);
            Actividad a2 = AltaActividad("Estreno de Mulan", DateTime.Parse("2021-10-15"), 3, Actividad.EdadMinimaPermitida.C13, c3, 200);
            Actividad a3 = AltaActividad("Concierto orquesta municipal", DateTime.Parse("2021-11-20"), 5, Actividad.EdadMinimaPermitida.P, c4, 9000);
            Actividad a4 = AltaActividad("Final metropolitano de Basketball", DateTime.Parse("2021-08-20"), 1, Actividad.EdadMinimaPermitida.C16, c2, 5000);
            Actividad a5 = AltaActividad("Concierto de Coldplay", DateTime.Parse("2021-08-20"), 1, Actividad.EdadMinimaPermitida.C18, c4, 5000);

            Actividad a6 = AltaActividad("Concierto de La Vela Puerca", DateTime.Parse("2021-08-10"), 2, Actividad.EdadMinimaPermitida.C18, c4, 20000);
            Actividad a7 = AltaActividad("Final Ciclismo de Pista", DateTime.Parse("2021-10-15"), 2, Actividad.EdadMinimaPermitida.C13, c2, 1000);
            Actividad a8 = AltaActividad("Clasificatorio Murga Joven", DateTime.Parse("2021-11-20"), 4, Actividad.EdadMinimaPermitida.P, c1, 9500);
            Actividad a9 = AltaActividad("Clasificatorio Murga", DateTime.Parse("2021-12-14"), 4, Actividad.EdadMinimaPermitida.P, c1, 5000);
            Actividad a10 = AltaActividad("Concierto de Mana", DateTime.Parse("2021-08-20"), 2, Actividad.EdadMinimaPermitida.C18, c4, 5000);





        }




        #endregion
    }
}
