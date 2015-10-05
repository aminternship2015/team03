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
        //bool Add();
        //bool Update();
        //bool Delete();
    }
}
