using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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

        public bool Add(Tweet tweet)
        {
            using (var dbItem = new TwitterEntities())
            {
                dbItem.Tweets.Add(tweet);
                return dbItem.SaveChanges() > 0;
            }
        }

        public bool Update(int id)
        {
            using (var dbItem = new TwitterEntities())
            {
                var _tweet = dbItem.Tweets.Find(id);
                if (!(_tweet).Equals(null))
                {
                    //!!!!!!!!!
                }
                return dbItem.SaveChanges() > 0;
            }
        }

        public bool Delete(int id)
        {
            using (var dbItem = new TwitterEntities())
            {
                var _tweet = dbItem.Tweets.Find(id);
                if (!(_tweet).Equals(null))
                {
                    dbItem.Tweets.Remove(_tweet);
                }
                return dbItem.SaveChanges() > 0;
            }
        }

        public bool Save(Tweet tweet)
        {
            using (var dbItem = new TwitterEntities())
            {
                dbItem.Tweets.Attach(tweet);
                dbItem.Entry(tweet).State = EntityState.Modified;
                return dbItem.SaveChanges() > 0;
            }
        }

        public Tweet Get(int id)
        {
            using (var dbItem = new TwitterEntities())
            {
                var findTweet = dbItem.Tweets.FirstOrDefault(currentTweet=>currentTweet.id_tweet==id);
                return findTweet;
            }
        }
    }
}
