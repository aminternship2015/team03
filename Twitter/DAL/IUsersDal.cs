using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IUsersDal
    {
        List<User> GetAll();
        bool Add(User user);
        User GetUserById(int id);
        bool Save(User user);
        bool Delete(int id);
        bool GetUserForLogin(string email, string password);
    }
}
