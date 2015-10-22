using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services
{
    public interface IUsersService
    {
        List<UsersModel> GetAll();
        UsersModel GetUserById(int id);
        bool Save(UsersModel user);
        bool Delete(int id);
        bool Add(UsersModel user);
        LoginModel GetUserForLogin(string email);
        bool Activated(string email);
        bool ConfirmActivated(string email);
    }
}
