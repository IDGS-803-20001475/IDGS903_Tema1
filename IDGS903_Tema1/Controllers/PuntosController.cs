using IDGS903_TEMA1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_TEMA1.Controllers
{
    public class PuntosController : Controller
    {
        // GET: Puntos
       public ActionResult Index(Puntos p)
        {
            p.Calculos();
            return View();
        } 

        public ActionResult Resultado(Puntos p)
        {
            p.Calculos();
            var model = new Puntos();
            model.res = p.res;
            return View(model);
        }
    }
}