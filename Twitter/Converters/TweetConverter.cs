using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace Converters
{
    public class TweetConverter
    {
        public Tweet convertToDal(TweetsModel tweet)
        {
            var listOfTweets = new Tweet();
            listOfTweets.id_tweet = tweet.id_tweet;
            listOfTweets.id_user = tweet.id_user;
            listOfTweets.Tweet1 = tweet.Tweet;
            return listOfTweets;
        }
        public TweetsModel convertToUI(Tweet tweet)
        {
            var listOfTweets = new TweetsModel();
            listOfTweets.id_tweet = tweet.id_tweet;
            listOfTweets.id_user = (int)tweet.id_user;
            listOfTweets.Tweet = tweet.Tweet1;
            return listOfTweets;
        }
    }
}
