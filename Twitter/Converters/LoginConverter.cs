using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace Converters
{
    public class LoginConverter
    {
        public LoginModel convertToUI(User user)
        {
            var logModel = new LoginModel();
            logModel.Email = user.Email;
            logModel.Password = user.Password;
            logModel.Roles = user.Roles;
            return logModel;
        }
    }
}
