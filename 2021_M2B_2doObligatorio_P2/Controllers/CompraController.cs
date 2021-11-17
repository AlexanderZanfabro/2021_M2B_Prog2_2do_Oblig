using Dominio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2021_M2B_2doObligatorio_P2.Controllers
{
    public class CompraController : Controller
    {
        Sistema s = Sistema.GetInstancia();
        public IActionResult Compra(int id)
        {
            // TODO SAFETY CHECKS like if registered
            Actividad act = null;

            foreach(Actividad a in s.GetActividades())
            {
                if(a.Id == id)
                {
                    act = a;
                    break;
                }
            }

            if (act == null)
                return RedirectToAction("Home", "Index");
            else
                return View();
        }

        [HttpPost]
        public IActionResult Compra()
        {
            return View();
        }
    }
}
