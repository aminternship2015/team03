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
        public UsersService currentUserService;
        public UserController()
        {
            currentUserService = new UsersService();
        }

        public ActionResult Information()
        {
            return View(currentUserService.GetAll());
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(currentUserService.GetUserById(id));
        }
        [HttpPost]
        public ActionResult Save(UsersModel user)
        {
            currentUserService.Save(user);
            return RedirectToAction("Information");

        }

        public ActionResult Delete(int id)
        {
            currentUserService.Delete(id);
            return RedirectToAction("Information");
        }
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(UsersModel user)
        {
            if (ModelState.IsValid)
            {
                currentUserService.Add(user);
                return RedirectToAction("Login");
            }
            else return View(user);
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(string email, string password)
        {
            if (ModelState.IsValid)
            {
                var result = currentUserService.GetUserForLogin(email, password);
                if (result == true)
                    return RedirectToAction("Information");
                else
                {
                    return RedirectToAction("Login");
                }
            }
            else return View(email, password);
        }
    }
}
