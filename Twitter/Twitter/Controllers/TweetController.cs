using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using PagedList;
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
        public ActionResult Information(int iduser, int? page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            List<TweetsModel> currentTweetsList = new List<TweetsModel>();
            currentTweetsList = curentTweetService.GetAllTweets(iduser).OrderByDescending(xTweet => xTweet.id_tweet).ToList();
            return View("Information", currentTweetsList.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult Delete(int id, int idUser)
        {
            curentTweetService.DeleteTweet(id);
            return RedirectToAction("Information", "Tweet", new { iduser = idUser });
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(TweetsModel myTweet)
        {
            if (ModelState.IsValid)
            {
                curentTweetService.AddTweet(myTweet);
                return RedirectToAction("Information", "Tweet", new { iduser = myTweet.id_user });
            }
            else
            {
                return View(myTweet);
            }
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(curentTweetService.Get(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TweetsModel aTweet)
        {
            curentTweetService.Save(aTweet);
            return RedirectToAction("Information", "Tweet", new { iduser = aTweet.id_user });
        }
    }
}