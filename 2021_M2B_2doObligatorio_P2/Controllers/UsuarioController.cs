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

            foreach(var a in listaActividades)
            {
               
            }
          
            return View();
        }


       public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string nombreUsuario, string contrasenia)
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
                Compra c = s.AltaCompra(id, cantidad, id, DateTime.Now, "Activa", s.CalcularPrecioFinal(cantidad, lugar.Nombre));
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
            if(HttpContext.Session.GetString("usuarioLogRol") == "Operador")
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

                ViewBag.MensajeEliminacion = "Usuario eliminado con exito";
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }


    }
}
