using Microsoft.AspNetCore.Mvc;
using NLog;
using RegisterAndLoginApp.Models;
using RegisterAndLoginApp.Services;
using RegisterAndLoginApp.Utility;

namespace RegisterAndLoginApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [CustomAuthorization]
        public IActionResult PrivateSectionMustBeLoggedIn()
        {
            return Content("I am a protected method");
        }
        [LogActionFilter]
        public IActionResult ProcessLogin(UserModel userModel) 
        {
            SecurityService securityService = new SecurityService();

            if(securityService.IsValid(userModel))
            {
                HttpContext.Session.SetString("username", userModel.UserName);
                return View("LoginSuccess", userModel);
            }
            else
            {
                HttpContext.Session.Remove("username");
                return View("LoginFailure", userModel);
            }
        }
    }
}
