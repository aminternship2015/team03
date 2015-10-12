﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Services;

namespace Twitter.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public UsersService currentUserService;
        public HomeController()
        {
            currentUserService = new UsersService();
        }
        public ActionResult StartPage()
        {
            return View();
        }
        
    }
}