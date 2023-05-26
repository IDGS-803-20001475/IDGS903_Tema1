using IDGS903_TEMA1.Models;
using IDGS903_TEMA1.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_TEMA1.Controllers
{
    public class TraductorController : Controller
    {
        // GET: Traductor(
        public ActionResult Registrar(Palabras pal)
        {
            var op = new TraductorService();
            op.GuardarTraduccion(pal);

            
            ViewBag.Palabras = op.LeerPalabras();
            return View();
        }
        public ActionResult Mostrar()
        {
            var pal = new TraductorService();
            ViewBag.Palabras = pal.LeerPalabras();
            return View();
        }

        public ActionResult Buscar(Palabras pal,string idioma)
        {
            string trad= pal.buscar(idioma);
            ViewBag.res = trad;
            return View();
        }
    }
}