//using _2021_M2B_2doObligatorio_P2.Models;
using Dominio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2021_M2B_2doObligatorio_P2.Controllers
{
    public class UsuarioController : Controller
    {

        Dominio.Sistema s = Dominio.Sistema.GetInstancia();

       
        public IActionResult Index()
        {
            List<Actividad> activ = s.GetActividades();
            ViewBag.ListActividades = activ;

            List<Usuario> usu = s.GetUsuarios();
            ViewBag.ListaGeneralUsuarios = usu;

            
            return View();
        }


       
      

        public IActionResult Operador()
        {
            List<Usuario> usu = s.GetUsuarios();
            ViewBag.MostrarTodosUsuarios = usu;

            return View();
        }



        public IActionResult ListaParaVer()
        {
            return View();
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(string nombre, string apellido, string email, DateTime fechaNacimiento, string nombreUsuario, string contrasenia)
        {
            Usuario u = s.AltaUsuario(nombre, apellido, email, fechaNacimiento, nombreUsuario, contrasenia);


             if(u != null)
            {
                u.Rol = "Registrado";

                ViewBag.Msg = "Alta correcta";
            }
            else
            {
                ViewBag.Msg = "Error en el Alta de usuario";
            } 

            return View();
        }
    }
}
