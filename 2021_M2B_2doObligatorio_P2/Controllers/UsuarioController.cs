//using _2021_M2B_2doObligatorio_P2.Models;
using Dominio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace _2021_M2B_2doObligatorio_P2.Controllers
{
    public class UsuarioController : Controller
    {

        Dominio.Sistema s = Dominio.Sistema.GetInstancia();

       
        public IActionResult Index()
        {
            List<Actividad> listaActividades = s.GetActividadesActuales();
            ViewBag.ListadoAct = listaActividades;

            return View();
        }


       public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string nombreUsuario, string contrasenia)
        {
            bool usuarioEnActividad = true;
            foreach (Usuario usu in s.GetUsuarios()) if(usuarioEnActividad)
            {
               
                if(usu.NombreUsuario == nombreUsuario && usu.Contrasenia == contrasenia)
                {    
                    if (usu.Activo == false)
                    {
                        usuarioEnActividad = false;
                    }
                   

                }
            }


            if (usuarioEnActividad)
            {
                if (HttpContext.Session.GetString("usuarioLogRol") != "Registrado")
                {
                    if (nombreUsuario == null || contrasenia == null)
                    {
                        ViewBag.Resultado = "Un campo introducido es invalido";
                        return View();
                    }

                    if (nombreUsuario == "" || contrasenia == "")
                    {
                        ViewBag.Resultado = "Un campo introducido es invalido";
                        return View();
                    }

                    if (HttpContext.Session.GetString("usuarioLogueadoUsername") != null)
                    {
                        ViewBag.Resultado = "Error";
                        return View();
                    }


                    Usuario u = s.LoginUsuario(nombreUsuario, contrasenia);

                    if (u != null)
                    {

                        ViewBag.Resultado = "Logueado con exito!";
                        HttpContext.Session.SetString("usuarioLogUsername", u.NombreUsuario);
                        HttpContext.Session.SetString("usuarioLogRol", u.Rol);
                        HttpContext.Session.SetString("usuarioLogNombre", u.Nombre);
                        HttpContext.Session.SetString("usuarioLogApellido", u.Apellido);
                        HttpContext.Session.SetInt32("usuarioLogId", u.Id);



                        return RedirectToAction("Index", "Home");
                    }

                    ViewBag.Resultado = "No se encontro un usuario con esas credenciales";
                    return View();
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
           
          
        }


        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("usuarioLogUsername") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
           

        [HttpPost]
        public IActionResult Logout(string s)
        {

            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }



        public IActionResult Registro()
        {

            if (HttpContext.Session.GetString("usuarioLogRol") != "Registrado" && HttpContext.Session.GetString("usuarioLogRol") != "Operador")
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
           

        [HttpPost]
        public IActionResult Registro(string nombre, string apellido, string email, DateTime fechaNacimiento, string nombreUsuario, string contrasenia)
        {
            Usuario u = s.AltaUsuario(nombre, apellido, email, fechaNacimiento, nombreUsuario, contrasenia);


             if(u != null)
            {
               
                ViewBag.Msg = "Alta correcta";
            }
            else
            {
                ViewBag.Msg = "Error en el Alta de usuario";
            }
            
            return View();
        }
        public IActionResult ComprarEntradas(int id)
        {
            if (HttpContext.Session.GetInt32("usuarioLogId") == null)
                return RedirectToAction("Index", "Home");

            Actividad act = null;

            foreach (Actividad a in s.GetActividades())
            {
                if (a.Id == id)
                {
                    act = a;
                    break;
                }
            }

            if (act == null)
                return RedirectToAction("Index", "Home");
            else
                return View(act);
        }

        [HttpPost]
        [ActionName("ComprarEntradas")]
        public IActionResult ComprarEntradasPost(int cantidad)
        {
            Lugar lugar = null;
            Actividad act = null;

            int id = Int32.Parse(RouteData.Values["id"].ToString());
            if (HttpContext.Session.GetInt32("usuarioLogId") != null)
            {
                foreach (Actividad a in s.GetActividades())
                {
                    if (a.Id == id)
                    {
                        act = a;
                        lugar = a.Lugar;
                    }
                }
            }
            
            int userId = (int) HttpContext.Session.GetInt32("usuarioLogId");
            if(act == null)
            {
                return RedirectToAction("Index", "Home");
            }

            if (cantidad <= 0)
            {
                ViewBag.Resultado = "Error";
                return View(act);
            }
            else
            {
                Compra c = s.AltaCompra(id, cantidad, userId, DateTime.Now, "Activa", s.CalcularPrecioFinal(cantidad, lugar.Nombre));
                if (c != null)
                {
                    ViewBag.Resultado = "Compra exitosa";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Resultado = "Un error ocurrio, intentalo nuevamente.";
                    return View(act);
                }
            }
            
        }

        public IActionResult ListaDeUsuarios()
        {
            if (HttpContext.Session.GetString("usuarioLogRol") == "Operador")
            {
                List<Usuario> usuarios = s.GetSoloUsuariosRegistrados();
                usuarios.Sort();

                return View(usuarios);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
           

          
        }

        public IActionResult ListaDeCompras()
        {
            List<Compra> c = s.GetCompras();

            return View(c);
        }

        public IActionResult EliminarUsuarioRegistrado()
        {
           

            if (HttpContext.Session.GetString("usuarioLogRol") == "Operador")
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            } 
        }


        [HttpPost]
        public IActionResult EliminarUsuarioRegistrado(int id)
        {
            if (HttpContext.Session.GetString("usuarioLogRol") == "Operador")
            {
              bool usu =  s.EliminarUsuario(id);

                 // ViewBag.MensajeEliminacion = "Usuario eliminado con exito";
                 //return View();
                return RedirectToAction("ListaDeUsuarios", "Usuario");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

      
        public IActionResult ComprasEntreFechas()
        {
            if (HttpContext.Session.GetString("usuarioLogRol") == "Operador")
            {

              // ViewBag.ListComp = "";

                return View();

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
           
        }

        [HttpPost]

        public IActionResult ComprasEntreFechas(DateTime f1, DateTime f2 , string f3)
        {
            if (HttpContext.Session.GetString("usuarioLogRol") == "Operador")
            {
              // DateTime fecha1 = DateTime.Parse(f1);
              // DateTime fecha2 = DateTime.Parse(f2);


                List<Compra> comprasEntreFechas = s.GetComprasEntreFechas(f1, f2);

                if (comprasEntreFechas.Count != 0) // con la List.Count != 0 --> le digo que se muestre si la lista no es vacía
                {
                    return View(comprasEntreFechas);
                }
                else
                {
                    ViewBag.Msg = "No hay compras entre las fechas elegidas.";
                    return View();
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        public IActionResult MisCompras()
        {
            int? userId = HttpContext.Session.GetInt32("usuarioLogId");
            if (userId == null)
                return RedirectToAction("Index", "Home");

            List<Compra> compras = new List<Compra>();
            foreach(Compra c in s.GetCompras())
            {
                if(c.IdUsuarioQueCompra == userId)
                {
                    compras.Add(c);
                }
            }

            return View(compras);
        }



        public IActionResult RestablecerUsuario()
        {

            if (HttpContext.Session.GetString("usuarioLogRol") == "Operador")
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult RestablecerUsuario(int id)
        {
            if (HttpContext.Session.GetString("usuarioLogRol") == "Operador")
            {
                bool usu = s.RestablecerUsuario(id);

                //TempData["nuevoMensaje"] = "Exito";
               // ViewBag.Mensaje = "Usuario restablecido con exito";
                // return View();
                return RedirectToAction("ListaDeUsuarios", "Usuario");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

    }


   
}
