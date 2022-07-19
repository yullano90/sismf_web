using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sismf_web.Controllers
{
    public class OperacaoController : Controller
    {
        public ActionResult EntradaProduto()
        {
            return View();
        }
        public ActionResult SaidaProduto()
        {
            return View();
        }
        public ActionResult LancPerdaProduto()
        {
            return View();
        }
        public ActionResult InvetarioEstoque()
        {
            return View();
        }

    }
}