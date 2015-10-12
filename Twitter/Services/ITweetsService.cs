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
        List<TweetsModel> GetAllTweets();
        bool AddTweet(TweetsModel tweet);
        void DeleteTweet(int id); 
    }
}
