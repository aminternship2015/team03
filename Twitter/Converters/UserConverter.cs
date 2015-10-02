using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace Converters
{
    public class UserConverter
    {
        public UsersModel convertToUI(User user)
        {
            var listOfUser = new UsersModel();
            listOfUser.id_user = user.id_user;
            listOfUser.First_Name = user.First_Name;
            listOfUser.Last_Name = user.Last_Name;
            listOfUser.Password = user.Password;
            listOfUser.Email = user.Email;
            return listOfUser;
        }
    }
}
