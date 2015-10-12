using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace Converters
{
    public class TweetConverter
    {
        public TweetsModel ConvertToModel(Tweet tweet)
        {
            var convertTweet = new TweetsModel();
            convertTweet.id_tweet = tweet.id_tweet;
            convertTweet.id_user = (int)tweet.id_user;
            convertTweet.Tweet = tweet.Tweet1;
            return convertTweet;
        }

        public Tweet ConvertToUI(TweetsModel tweet)
        {
            var convertTweet = new Tweet();
            convertTweet.id_tweet = tweet.id_tweet;// NullReferenceException 
            convertTweet.id_user = tweet.id_user;
            convertTweet.Tweet1 = tweet.Tweet;
            return convertTweet;
        }
    }
}
