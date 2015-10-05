using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;
using Converters;

namespace Services
{
    public class TweetsService : ITweetsService
    {
        TweetsDal tweetDal;
        TweetConverter tweetConerter;

        public TweetsService()
        {
            tweetDal = new TweetsDal();
            tweetConerter = new TweetConverter();
        }

        public List<TweetsModel> GetAllTweets()
        {
            var tweets = tweetDal.GetAll();
            List<TweetsModel> listOfTweets = new List<TweetsModel>();
            foreach (var tweet in tweets)
            {
                listOfTweets.Add(tweetConerter.ConvertToUI(tweet));
            }
            return listOfTweets;
        }
    }
}
