﻿                    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Dominio.Actividad;

namespace Dominio
{
     public class Sistema
    {  ////////////////////////////////////////////////////////////////////////////////////////// Patrón Singleton
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

        private List<Like> likes = new List<Like>();
        #endregion


        /////////////////////////////////////////////////////////////////////////////////// Constructor
        // el contructor pasa de public a private al implementar el patron Singleton.
        private Sistema()
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
        
        public List<Like> GetLikes() { return likes; }

        #endregion




        //////////////////////////////////////////////////////////////////////////////////////////////////// Altas del Sistema

        #region Altas del Sistema

        public Actividad AltaActividad(string nombreActividad, DateTime fechaYhoraActividad, Lugar lugar, EdadMinimaPermitida edadMinima, Categoria categoria)
        {
            Actividad nueva = null;

            //faltan validaciones
            //edadMinima es del tipo enum
            bool auxAbierto = false;

            foreach (Actividad ac in actividades)
            {
                if (ac.NombreActividad == nombreActividad && ac.FechaYhoraActividad == fechaYhoraActividad )
                {
                    auxAbierto = true;
                }

            }

            if (!auxAbierto)
            {
                nueva = new Actividad(nombreActividad, fechaYhoraActividad, lugar, edadMinima, categoria);
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
                    Actividad a = null;
                    foreach(Actividad _a in actividades)
                    {
                        if (_a.Id == idActividadComprada)
                            a = _a;
                    }

                    if (a == null)
                        return nueva;

                    nueva = new Compra(a, cantidadEntradas, idUsuarioQueCompra, fechaYhora, estado, Math.Round(precioFinalEntrada, 2));
                    compras.Add(nueva);
                }


            }


            return nueva;
        }

        //--------------------------------------------------------------------------------------------------------------------------

        public Like AltaLike(int idUsuario, int idActividad)
        {
            foreach(Like l in likes)
            {
                if (l.idUsuario == idUsuario && l.idActividad == idActividad)
                    return null;
            }

            foreach(Usuario u in usuarios)
            {
                if(u.Id == idUsuario)
                {
                    foreach(Actividad a in actividades)
                    {
                        if(a.Id == idActividad)
                        {
                            Like l = new Like(idActividad, idUsuario);
                            return l;
                        }
                    }
                }
            }

            return null;
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


                    if (lu.Nombre == nombre)
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
                    if (lu.Nombre == nombre)
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

        // Como manejar el Rol y el estado Activo ?
        /// <summary>
        /// El AltaUsuario tiene métodos de verificación y ademas hay un filtro de javascript en la vista de Registro
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="email"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="nombreUsuario"></param>
        /// <param name="contrasenia"></param>
        /// <returns></returns>
        public Usuario AltaUsuario(string nombre, string apellido, string email, DateTime fechaNacimiento, string nombreUsuario, string contrasenia)
        {
            Usuario nuevo = null;

            if (nombre != null && apellido != null && email != null && fechaNacimiento < DateTime.Now && nombreUsuario != null && contrasenia != null && CheckEmail(email) && CheckContrasenia( contrasenia))
            {

              

                bool aux = false;

                foreach (Usuario u in usuarios)
                {
                    if (u.Email == email && u.NombreUsuario == nombreUsuario)
                    {
                        aux = true;

                    }
                }
                if (!aux)
                {

                    nuevo = new Usuario(nombre, apellido, email, fechaNacimiento, nombreUsuario, contrasenia);
                    usuarios.Add(nuevo);

                }

            }

            return nuevo;
        }

       


        #endregion



        /////////////////////////////////////////////////////////////////////////////////// Métodos


        #region Métodos


        //----------------------------------------------Cambiar aforo máximo permitido---------------------------------------------

        #region cambiarAforoMaxPermitido

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

        #endregion

        //-------------------------------------------------Lista espectáculos áptos para todo público------------------------------

        #region List espectaculos áptos para todo público
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


        #endregion

        //-------------------------------------------------Cambiar precio de butacas-----------------------------------------------

        #region cambiarPrecioButaca

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


        #endregion

        //-----------------------------------------------Actividades entre 2 fechas------------------------------------------------

        #region Actividad entre dos fechas
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

        #endregion

        //-------------------------------------------------------------------------------------------------------------------------

        #region métodosDeCalculosEnDesuso
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

        //----------------------------------------------------- Calcular el precio final con cantidad de entradas -----------------

        public double CalcularPrecioFinal(int cantidadEntradas, string nombreLugar)
        {
            Lugar lugar = null;
            foreach(Lugar l in lugares)
            {
                if(l.Nombre == nombreLugar)
                {
                    lugar = l;
                    break;
                }
            }

            if(lugar == null)
                return -1.0;

            double valorRetorno = Actividad.PrecioBaseActividad;
            if(lugar is LugarAbierto)
            {
                if(lugar.Dimensiones > 0.1)
                    valorRetorno = valorRetorno * 1.10;
            }
            else
            {
                if(LugarCerrado.GetAforoMaximoPermitido() < 50)
                    valorRetorno = valorRetorno * 1.30;
                else if(LugarCerrado.GetAforoMaximoPermitido() > 50 && LugarCerrado.GetAforoMaximoPermitido() < 70){
                    valorRetorno = valorRetorno * 1.15;
                }
            }

            return cantidadEntradas > 5 ? (valorRetorno * cantidadEntradas) * 0.95 : valorRetorno * cantidadEntradas;
        }

        //---------------------------------------------------------- Funciones relacionadas a Like ----------------------------------
        public bool HasUserLiked(int idActividad, int idUsuario)
        {
            foreach(Like l in likes)
            {
                if (l.idActividad == idActividad && l.idUsuario == idUsuario)
                    return true;
            }

            return false;
        }
       

        //---------------------------------------LOGIN----------------------------------------------------------------------------


        public Usuario LoginUsuario(string username, string password){
           foreach(Usuario u in usuarios)
           {
               if(u.NombreUsuario == username && u.Contrasenia == password)
               {
                   return u;
               }
           }
           return null;
       }



        //---------------------------------- Verificaciones del Registro ----------------------------------------------------------

        #region verificacion de Email
        private bool CheckEmail(string email)
        {
            bool correcto = false;

            bool existeArroba = false;
            foreach (char i in email)
            {
                if (i.ToString() == "@")
                {
                    // existe un @ en el texto "email"
                    existeArroba = true;
                    break;
                }

            }

            bool unArrobaEnTexto = false;
            if(email.IndexOf("@") == email.LastIndexOf("@")){

                // solo hay un @ en el texto "email"
                unArrobaEnTexto = true;
            }

            bool primerLetr = false;
            string emailExaminado = email;
            char primerLetra = emailExaminado.FirstOrDefault();
            char arr = '@' ;
            if(primerLetra != arr){
                // "@" no esta al principio del texto email
                primerLetr = true;
            }

            /*  int largoDeEmail = emailExaminado.Length;
              bool aux4 = false; 
              char lastCharacter = emailExaminado[largoDeEmail];
              if(lastCharacter != arr)
              {
                  // último caracter del texto email no es @
                  aux4 = true;
              }*/
            bool finConArroba = false;
           if(email.EndsWith('@') != true)
            {
                finConArroba = true;
            }

            if(existeArroba && unArrobaEnTexto && primerLetr && finConArroba)
            {
                correcto = true;
            }


            return correcto;
        }

        #endregion
        //-------------------

        #region verificacion de contrasenia

         public bool CheckContrasenia(string contrasenia) { 
            bool esCorrecto = false;

            bool largoCorrecto = false;
           if( contrasenia.Length >= 6) {  largoCorrecto = true; }


            bool tieneUnNum = false;
            bool TieneMayuscula = false;
            bool tieneMinuscula = false;

            string str = contrasenia;
            byte[] valoresAscii = Encoding.ASCII.GetBytes(str);
            foreach(var v in valoresAscii)
            {
                if(v > 47 && v < 58)
                {
                    // tiene al menos un número
                    tieneUnNum = true;
                }
                if(v > 64 && v < 91)
                {
                    // tiene al menos una mayúscula
                    TieneMayuscula = true;
                }
                if (v > 96 && v < 123)
                {
                    // tiene al menos una minúscula
                    tieneMinuscula = true;
                }
            }

            if(largoCorrecto && tieneUnNum && TieneMayuscula && tieneMinuscula)
            {
                esCorrecto = true;
            }


            return esCorrecto;
        }

        #endregion

        //-------------------------------------------------------------------------------------------------------------------------

        #region Actividades Actuales

        public List<Actividad> GetActividadesActuales()
        {
            List<Actividad> actuales = new List<Actividad>();

            foreach (var ac in actividades)
            { if(ac.FechaYhoraActividad > DateTime.Now)
                {
                    actuales.Add(ac);
                }

            }


            return actuales;
        }




        #endregion

        //--------------------------------------------------------------------------------------------------------------------------

        #region SoloUsuariosRegistrados

        public List<Usuario> GetSoloUsuariosRegistrados()
        {
            List < Usuario > retorno = new List<Usuario>();

            foreach(Usuario u in usuarios)
            {
                if (u.Rol.Equals("Registrado"))
                {
                    retorno.Add(u);
                }
            }


            return retorno;

        }

        #endregion

        //--------------------------------------------------------------------------------------------------------------------------

        #region Eliminar usuario


        public bool EliminarUsuario(int id)
        {
            bool eliminado = false;
         
            foreach (Usuario usu in GetSoloUsuariosRegistrados()) if (!eliminado)
                {
                if (usu.Id == id ) 
                {
                        usu.Activo = false;

                        eliminado = true;
                }
            }


            return eliminado;
        }

        #endregion

        //--------------------------------------------------------------------------------------------------------------------------

        #region GetComprasEntreFechas

        
          public List<Compra> GetComprasEntreFechas(DateTime f1, DateTime f2)
        {
            List<Compra> retorno = new List<Compra>();
            
            //DateTime F1 = default(DateTime);
           // DateTime F2 = default(DateTime);

             //F1 = f1;
             //F2 = f2;

           /* if (F1 > F2)
            {
                DateTime aux;
                aux = F1;
                F1 = F2;
                F2 = aux;

            }*/

            if (f1 > f2)
            {
                DateTime aux;
                aux = f1;
                f1 = f2;
                f2 = aux;

            }

            foreach (Compra c in compras)
            {
                if(c.FechaYhora > f1 && c.FechaYhora < f2)
                {
                    retorno.Add(c);
                }
            }


            return retorno;
        }

         


        #endregion

        //-------------------------------------------------------------------------------------------------------------------------

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

            Actividad a1 = AltaActividad("Concierto de U2", DateTime.Parse("2021-08-20"), l1, Actividad.EdadMinimaPermitida.C18, c4);
            Actividad a2 = AltaActividad("Estreno de Mulan", DateTime.Parse("2021-10-15"), l3, Actividad.EdadMinimaPermitida.C13, c3);
            Actividad a3 = AltaActividad("Concierto orquesta municipal", DateTime.Parse("2021-11-28"), l5, Actividad.EdadMinimaPermitida.P, c4);
            Actividad a4 = AltaActividad("Final metropolitano de Basketball", DateTime.Parse("2022-02-20"), l1, Actividad.EdadMinimaPermitida.C16, c2);
            Actividad a5 = AltaActividad("Concierto de Coldplay", DateTime.Parse("2022-08-20"), l1, Actividad.EdadMinimaPermitida.C18, c4);

            Actividad a6 = AltaActividad("Concierto de La Vela Puerca", DateTime.Parse("2021-12-10"), l2, Actividad.EdadMinimaPermitida.C18, c4);
            Actividad a7 = AltaActividad("Final Ciclismo de Pista", DateTime.Parse("2021-10-15"), l2, Actividad.EdadMinimaPermitida.C13, c2);
            Actividad a8 = AltaActividad("Clasificatorio Murga Joven", DateTime.Parse("2021-11-20"), l4, Actividad.EdadMinimaPermitida.P, c1);
            Actividad a9 = AltaActividad("Clasificatorio Murga", DateTime.Parse("2021-12-14"), l4, Actividad.EdadMinimaPermitida.P, c1);
            Actividad a10 = AltaActividad("Concierto de Mana", DateTime.Parse("2021-08-20"), l2, Actividad.EdadMinimaPermitida.C18, c4);

            Usuario u1 = AltaUsuario("John", "Smith", "john@montevideo.com.uy", DateTime.Parse("1981-01-10"), "john01", "1234@Aaa");
            Usuario u2 = AltaUsuario("Aida", "Aqua", "aAqua@montevideo.com.uy", DateTime.Parse("1978-05-20"), "aida01", "4321@Aaa");
            Usuario u3 = AltaUsuario("Mika", "Verona", "verona@montevide.com.uy", DateTime.Parse("2001-01-05"), "mika01", "111#Agua");
            Usuario u4 = AltaUsuario("Augusto", "Re", "augusRe@montevideo.com.uy", DateTime.Parse("1955-02-12"), "augusto01", "22@@Zz22");
            Usuario u5 = AltaUsuario("Anton", "Vivaldi", "vivaldi@montevideo.com.uy", DateTime.Parse("1999-08-11"), "anton01", "4444@JJj");

            u1.Rol ="Operador";
            u2.Rol ="Operador";
          
            


        }




        #endregion
    }
}
