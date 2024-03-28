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

        public IActionResult ProcessLogin(UserModel userModel) 
        {
            MyLogger.GetInstance().Info("Processing a login attempt");
            MyLogger.GetInstance().Info(userModel.toString());

            SecurityService securityService = new SecurityService();

            if(securityService.IsValid(userModel))
            {
                MyLogger.GetInstance().Info("Login success");
                return View("LoginSuccess", userModel);
            }
            else
            {
                MyLogger.GetInstance().Warn("Login failure");
                return View("LoginFailure", userModel);
            }
        }
    }
}
