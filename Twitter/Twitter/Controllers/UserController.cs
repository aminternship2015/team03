using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Services;
using log4net;
using PagedList;
using Twitter.Security;

namespace Twitter.Controllers
{
    public class UserController : Controller
    {
        
        public UsersService currentUserService;
        public ILog logger;
        public UserController()
        {
            currentUserService = new UsersService(); 
            logger = LogManager.GetLogger(typeof(UserController));
        }
        [CustomAuthorize(Roles = "admin,user")]
        public ActionResult Information(int? page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            List<UsersModel> currentUserList = new List<UsersModel>();
            currentUserList = currentUserService.GetAll().OrderByDescending(xUser => xUser.id_user).ToList();
            return View("Information", currentUserList.ToPagedList(pageNumber, pageSize));
            logger.Debug("You called the method \"GetAll\"");
        }
        [CustomAuthorize(Roles = "admin")]
        [HttpGet]
        public ActionResult Edit(int id)
        {
            logger.Debug("You wanted to edit the user with id"+id);
            return View(currentUserService.GetUserById(id));
        }
        [HttpPost]
        public ActionResult Save(UsersModel user)
        {
            logger.Debug("You saved edited information about the user:" + user.id_user + " " + user.First_Name + " " + user.Last_Name + " " + user.Email);
            currentUserService.Save(user);
            return RedirectToAction("Information");

        }
        [CustomAuthorize(Roles = "admin")]
        public ActionResult Delete(int id)
        {
            logger.Debug("You deleted the user with id" + id);
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
                currentUserService.SendActivationEmail(user);
                currentUserService.Add(user);
                logger.Debug("Was added the user with id" + user.id_user);
                return RedirectToAction("Login", "Account");
            }
            else return View(user);
        }
        public ActionResult GetTweet(int id)
        {
            return RedirectToAction("Information", "Tweet", new { iduser = id });
        }
    }
}
