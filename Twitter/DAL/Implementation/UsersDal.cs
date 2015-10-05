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

        public List<User> Update(int id)
        {
            using (var dbContext = new TwitterEntities())
            {
                var userById = 
                    from user in dbContext.Users
                       where user.id_user==id
                        select user;
                return userById.ToList();
            }
        }
    }
}
