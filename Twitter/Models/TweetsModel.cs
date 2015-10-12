using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.Entity;

namespace Models
{
    public class TweetsModel
    {
        public int id_tweet { get; set; }
        public int id_user { get; set; }
        public string Tweet { get; set; }
    }

    //public class TweetDBContext : DbContext
    //{
    //    public DbSet<TweetDBContext> Tweets { get; set; }
    //}
}
