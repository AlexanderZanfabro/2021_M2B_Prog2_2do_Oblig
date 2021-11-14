﻿//using _2021_M2B_2doObligatorio_P2.Models;
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
            return View(s.GetActividades());
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
            return RedirectToAction("Index", "Usuario");
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

        public IActionResult ComprarEntradas()
        {

            return
                View();
        }


        public IActionResult prueba()
        {

            return View(s.GetActividades());
        }
    }
}
