using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;


namespace PUBG.Helper
{
    public class Auth:IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context) { }

        const string Admin = "_Name";
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Session.GetInt32(Admin) == null)
            //  context.Result = new RedirectResult("/control/login");
            {
                context.Result = new RedirectToRouteResult(
                     new RouteValueDictionary(new { controller = "Login", action = "index" })
                );
            }
        }
    }
}
