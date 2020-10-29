using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventario.Controllers
{
    public class BienesController : Controller
    {
        // GET: Bienes
        public ActionResult VerBienes()
        {
            return View();
        }

        public ActionResult AnadirBienes()
        {
            return View();
        }

        public ActionResult ActualizarBienes()
        {
            return View();
        }

        public ActionResult DarBaja()
        {
            return View();
        }
    }
}