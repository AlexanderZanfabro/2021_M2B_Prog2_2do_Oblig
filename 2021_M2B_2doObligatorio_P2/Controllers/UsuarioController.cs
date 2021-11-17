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
            if(nombreUsuario == null || contrasenia == null)
            {
                ViewBag.Resultado = "Un campo introducido es invalido";
                return View();
            }
            
            if(nombreUsuario == "" || contrasenia == "")
            {
                ViewBag.Resultado = "Un campo introducido es invalido";
                return View();
            }

            if(HttpContext.Session.GetString("usuarioLogueadoUsername") != null)
            {
                ViewBag.Resultado = "Error";
                return View();
            }

            
            Usuario u = s.LoginUsuario(nombreUsuario, contrasenia);

            if(u != null)
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


        public IActionResult Logout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logout(string s)
        {

            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }



        public IActionResult Registro()
        {
            
            return View();
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
            // TODO SAFETY CHECKS like if registered
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
                return RedirectToAction("Home", "Index");
            else
                return View(act);
        }

        [HttpPost]
        public IActionResult ComprarEntradas(int id, int cantidad)
        {

            return View();
        }

        public IActionResult prueba()
        {

            return View(s.GetActividades());
        }
    }
}
