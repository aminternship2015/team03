using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Services;

namespace Twitter.Controllers
{
    public class TweetController : Controller
    {
        public ActionResult Information()
        {
            // ---GET---
            TweetsService curentTweetService = new TweetsService();
            return View(curentTweetService.GetAllTweets());
        }
    }
}