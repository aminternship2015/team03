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
        TweetConverter tweetConverter;

        public TweetsService()
        {
            tweetDal = new TweetsDal();
            tweetConverter = new TweetConverter();
        }

        public List<TweetsModel> GetAllTweets()
        {
            var tweets = tweetDal.GetAll();
            List<TweetsModel> listOfTweets = new List<TweetsModel>();
            foreach (var tweet in tweets)
            {
                listOfTweets.Add(tweetConverter.ConvertToUI(tweet));
            }
            return listOfTweets;
        }

        public bool AddTweet(TweetsModel tweet)
        {
            tweetDal.Add(tweetConverter.ConvertToDal(tweet));
            return true;
        }

        public TweetsModel Get(int id)
        {
            var tweets = tweetDal.Get(id);
            return tweetConverter.ConvertToUI(tweets);
        }

        public bool Save(TweetsModel tweet)
        {
            tweetDal.Save(tweetConverter.ConvertToDal(tweet));
            return true;
        }

        public void DeleteTweet(int id)
        {
            tweetDal.Delete(id);
        }
    }
}
