using Microsoft.AspNetCore.Mvc;
using RegisterAndLoginApp.Models;
using RegisterAndLoginApp.Services;

namespace RegisterAndLoginApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(UserModel userModel) 
        {
            SecurityService securityService = new SecurityService();

            if(securityService.IsValid(userModel))
            {
                return View("LoginSuccess", userModel);
            }
            else
            {
                return View("LoginFailure", userModel);
            }
        }
    }
}
