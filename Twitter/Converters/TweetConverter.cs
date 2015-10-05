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
        public TweetsModel ConvertToUI(Tweet tweet)
        {
            var convertTweet = new TweetsModel();
            convertTweet.id_tweet = tweet.id_tweet;
            convertTweet.id_user = (int)tweet.id_user;
            convertTweet.Tweet = tweet.Tweet1;
            return convertTweet;
        }
    }
}
