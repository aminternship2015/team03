using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Models;
using Services;

namespace Twitter.Security
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (string.IsNullOrEmpty(SessionPersister.Email))
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary
                    (new { controller = "Account", action = "Login" }));
            else
            {
                UsersService userService = new UsersService();
                CustomPrincipal mp = new CustomPrincipal(userService.GetUserForLogin
                    (SessionPersister.Email));
                if (!mp.IsInRole(Roles))
                    filterContext.Result = new RedirectToRouteResult(new
                        RouteValueDictionary(new { controller = "User", action = "Information" }));
            }
        }
    }
}