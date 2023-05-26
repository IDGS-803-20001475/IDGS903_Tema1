using IDGS903_TEMA1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_TEMA1.Controllers
{
    public class TriangulosController : Controller
    {
        // GET: Triangulos
        public ActionResult Index(Triangulos t)
        {
            t.Lados();
            t.GenerarRes();
            var model = new Triangulos();
            model.tt = t.tt;
            model.area = t.area;
            return View(model);
        }
    }
}