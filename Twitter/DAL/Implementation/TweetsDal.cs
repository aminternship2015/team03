using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TweetsDal : ITweetsDal
    {
        public List<Tweet> GetAll()
        {
            using ( var dbItem = new TwitterEntities())
            {
                var allTweets = dbItem.Tweets.ToList();
                return allTweets;
            }
        }
    }
}
