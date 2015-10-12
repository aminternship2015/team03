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
        TweetsService curentTweetService;

        public TweetController()
        {
            curentTweetService = new TweetsService();
        }

        public ActionResult Information()
        {
            return View(curentTweetService.GetAllTweets());
        }

        public ActionResult Delete(int id)
        {
            curentTweetService.DeleteTweet(id);
            return RedirectToAction("Information");
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(TweetsModel tweet)
        {
            curentTweetService.AddTweet(tweet);
            return RedirectToAction("Information");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(curentTweetService.Get(id));
        }
        [HttpPost]
        public ActionResult Save(TweetsModel tweet)
        {
            curentTweetService.Save(tweet);
            return RedirectToAction("Information");
        }
    }
}