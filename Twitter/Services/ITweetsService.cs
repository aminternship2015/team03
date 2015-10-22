using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services
{
    public interface ITweetsService
    {
        List<TweetsModel> GetAllTweets(int id);
        bool AddTweet(TweetsModel tweet);
        bool Save(TweetsModel tweet);
        TweetsModel Get(int id);
        void DeleteTweet(int id);
    }
}
