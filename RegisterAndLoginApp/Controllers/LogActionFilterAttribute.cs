
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using RegisterAndLoginApp.Models;
using RegisterAndLoginApp.Utility;

namespace RegisterAndLoginApp.Controllers
{
    internal class LogActionFilterAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            UserModel user = (UserModel)((Controller)context.Controller).ViewData.Model;

            MyLogger.GetInstance().Info("Leaving the ProcessLogin method");
            MyLogger.GetInstance().Info("User that logged in: " + user.toString());
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            MyLogger.GetInstance().Info("Entering the ProcessLogin method");
        }
    }
}