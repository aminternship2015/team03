using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Services;
using Twitter.Security;

namespace Twitter.Controllers
{
    
    public class AccountController : Controller
    {
        //
        // GET: /Home/
        public UsersService currentUserService;
        public AccountController()
        {
            currentUserService = new UsersService();
        }
        public ActionResult ConfirmAccount(string email)
        {
            if (Request.QueryString.Count > 0)
            {
                if (Request.QueryString.Keys[0] == "email")
                {
                    string Email = Request.QueryString["email"].ToString();
                      if(  currentUserService.Activated(Email)== true)
                          return View();
                }
            }
            return RedirectToAction("NotActivated");
        }
        public ActionResult StartPage()
        {
            return View();
        }
        
        public ActionResult Login()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (currentUserService.ConfirmActivated(model.Email)!= true)
            {
                return View("Login");
            }
            SessionPersister.Email = model.Email;
            return RedirectToAction("Information", "User");
        }
        public ActionResult Logout()
        {
            SessionPersister.Email = string.Empty;
            return RedirectToAction("Login", "Account");
        }
    }
}
