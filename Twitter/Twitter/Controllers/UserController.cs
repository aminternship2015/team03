using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Services;
namespace Twitter.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Information()
        {
            UsersService currentUserService = new UsersService();
            return View(currentUserService.GetAll());
        }

    }
}
