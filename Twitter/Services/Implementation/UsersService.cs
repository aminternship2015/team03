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
        public List<UsersModel> Update(int id)
        {
            var users = userDal.Update(id);
            List<UsersModel> listOfUser = new List<UsersModel>();
            foreach (var user in users)
            {
                listOfUser.Add(userConvert.convertToUI(user));
            }
            return listOfUser;
        } 
    }
}
