using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
using Converters;
using System.Net.Mail;
using System.Configuration;

namespace Services
{
    public class UsersService:IUsersService
    {
        UsersDal userDal;
        UserConverter userConvert;
        LoginConverter logConvertor;

        public UsersService()
        {
            userDal = new UsersDal();
            userConvert = new UserConverter();
            logConvertor = new LoginConverter();
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
        public LoginModel GetUserForLogin(string email)
        {
            var result = userDal.GetUserForLogin(email);
            return logConvertor.convertToUI(result);
        }
        public void SendActivationEmail(UsersModel user)
        {
            MailMessage message = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;

            string userActivation = "http://localhost:57681/Account/ConfirmAccount?email=" + user.Email;

            message.From = new MailAddress("vladpicireanu@gmail.com");
            message.To.Add(user.Email);
            message.Subject = "Account Activation";
            message.Body = "Hi" + user.First_Name + "</br>Your Email Confirmation link is Here</br> <a href = '" + userActivation + "'>click Here</a>";
            message.IsBodyHtml = true;
            client.EnableSsl = true;
            client.UseDefaultCredentials = true;
            client.Credentials = new System.Net.NetworkCredential("vladpicireanu@gmail.com", "zerooptununouanouacinci");
            client.Send(message);

        }
        public bool mail(UsersModel user)
        {
            bool activeted=false;
            
            //MailMessage message = new MailMessage();
            //SmtpClient client = new SmtpClient();
            //client.Host = "smtp.gmail.com";
            //client.Port = 587;

            //string userActivation = "http://localhost:57681/Account/ConfirmAccount?email=" + user.Email;

            //message.From = new MailAddress("vladpicireanu@gmail.com");
            //message.To.Add(user.Email);
            //message.Subject = "Account Activation";
            //message.Body = "Hi" + user.First_Name + "</br>Your Email Confirmation link is Here</br> <a href = '" + userActivation + "'>click Here</a>";
            //message.IsBodyHtml = true;
            //client.EnableSsl = true;
            //client.UseDefaultCredentials = true;
            //client.Credentials = new System.Net.NetworkCredential("vladpicireanu@gmail.com", "zerooptununouanouacinci");
            //client.Send(message);
            return activeted;
        }
        public bool Activated(string email)
        {
            var result = userDal.Activated(email);
            return result;
        }
        public bool ConfirmActivated(string email)
        {
            var result = userDal.ConfirmActivated(email);
            return result;
        }
    }
}
