using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ITweetsDal
    {
        List<Tweet> GetAll(int id);
        bool Add(Tweet tweet);
        bool Save(Tweet tweet);
        Tweet Get(int id);
        //bool Update();
        bool Delete(int id);
    }
}
