using sismf_web.Models;
using System.Web.Mvc;
using System.Web.Security;

namespace sismf_web.Controllers
{
    public class ContaController : Controller
    {
        [AllowAnonymous] //Tornando o Login Púbico
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel login, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            //Simulação do banco de dados:
            var achou = (login.Usuario == "yullano90" && login.Senha == "teste");
            if (achou)
            {
                //Validação se a URL informada está dentro do domínio:
                FormsAuthentication.SetAuthCookie(login.Usuario, login.LembrarMe);
                if (Url.IsLocalUrl(returnUrl)) //Uma vez usuário validado redirecioná-lo pra onde pediu:
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    RedirectToAction("Index", "Home"); //Do contrário retornar pra Home:
                }
            }
            else
            {
                ModelState.AddModelError("", "Login Inválido."); //Aviso para informações incorretas
            }
            return View(login);
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}