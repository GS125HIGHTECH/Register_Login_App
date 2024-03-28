
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RegisterAndLoginApp.Controllers
{
    internal class CustomAuthorizationAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            string? userName = context.HttpContext.Session.GetString("username");
            if (userName == null)
            {
                context.Result = new RedirectResult("/login");
            }
            else
            {

            }
        }
    }
}