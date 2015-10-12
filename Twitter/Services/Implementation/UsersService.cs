using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
using Converters;

namespace Services
{
    public class UsersService:IUsersService
    {
        UsersDal userDal;
        UserConverter userConvert;

        public UsersService()
        {
            userDal = new UsersDal();
            userConvert = new UserConverter();
        }
        public List<UsersModel> GetAll()
        {
            var users = userDal.GetAll();
            List<UsersModel> listOfUser = new List<UsersModel>();
            foreach (var user in users)
            {
                listOfUser.Add(userConvert.convertToUI(user));
            }
            return listOfUser;
        }
        public UsersModel GetUserById(int id)
        {
            var users = userDal.GetUserById(id);
            return userConvert.convertToUI(users);
        }
        public bool Save(UsersModel user)
        {
            userDal.Save(userConvert.convertToDal(user));
            return true;
        }
        public bool Delete(int id)
        {
            userDal.Delete(id);
            return true;
        }
        public bool Add(UsersModel user)
        {
            userDal.Add(userConvert.convertToDal(user));
            return true;
        }
        public bool GetUserForLogin(string email, string password)
        {
            var result = userDal.GetUserForLogin(email,password);
            return result;
        }
    }
}
