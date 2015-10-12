using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ITweetsDal
    {
        List<Tweet> GetAll();
        bool Add(Tweet tweet);
        //bool Update();
        bool Delete(int id);
    }
}
