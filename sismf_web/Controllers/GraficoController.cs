using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sismf_web.Controllers
{
    public class GraficoController : Controller
    {
        [Authorize]
        public ActionResult Grafico()
        {
            return View();
        }

        [Authorize]
        public ActionResult EntradaSaidaMes()
        {
            return View();
        }
    }
}