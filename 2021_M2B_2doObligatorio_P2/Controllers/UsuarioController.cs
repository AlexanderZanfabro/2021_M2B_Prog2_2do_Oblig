using _2021_M2B_2doObligatorio_P2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2021_M2B_2doObligatorio_P2.Controllers
{
    public class UsuarioController : Controller
    {

        Sistema s = Sistema.GetInstancia();
        public IActionResult Index()
        {
            ViewBag.Usuarios = "Juana"+ " " + "Miguel"; // prueba
            return View();
        }


    }
}
