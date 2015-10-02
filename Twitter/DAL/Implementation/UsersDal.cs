using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsersDal:IUsersDal
    {
        public List<User> GetAll()
        {
            using (var dbContext = new TwitterEntities())
            {
                var allUsers = dbContext.Users.ToList();
                return allUsers;
            }
        }
    }
}
