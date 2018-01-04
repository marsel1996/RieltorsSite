using Realtors.Class;
using Realtors.Models;
using System.Web.Mvc;
using System.Web.Security;

namespace Realtors.Controllers
{
    public class AccountController : Controller
    {
        private readonly MethodService _methodService = new MethodService();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = _methodService.Authorization(model.UserName, model.Password);
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, true);
                    return Redirect(returnUrl ?? Url.Action("Index", "Home"));
                }
                else
                {
                    ModelState.AddModelError("", "Неправильный логин или пароль");
                    return View("Index", "Account");
                }
            }
            else
            {
                return View("Index", "Account");
            }
        }

        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return Redirect(Url.Action("Index", "Home"));
        }
    }
}