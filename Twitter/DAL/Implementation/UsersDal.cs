using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text;

namespace DAL
{
    public class UsersDal : IUsersDal
    {
        public List<User> GetAll()
        {
            using (var dbContext = new TwitterEntities())
            {
                var allUsers = dbContext.Users.ToList();
                return allUsers;
            }
        }

        public User GetUserById(int id)
        {
            using (var dbContext = new TwitterEntities())
            {
                var userForUpdate = dbContext.Users.FirstOrDefault(currentUser => currentUser.id_user == id);
                return userForUpdate;
            }
        }

        public bool Save(User user)
        {
            using (var dbContext = new TwitterEntities())
            {
                dbContext.Users.Attach(user);
                dbContext.Entry(user).State = EntityState.Modified;
                dbContext.SaveChanges();
                return true;
            }
        }
        public bool Delete(int id)
        {
            using (var dbContext = new TwitterEntities())
            {
                var userToDelete = dbContext.Users.FirstOrDefault(currentUser => currentUser.id_user == id);
                var tweetToDelete =
                    from tweet in dbContext.Tweets
                    where tweet.id_user == id
                    select tweet;
                foreach(var tweet in tweetToDelete){
                dbContext.Tweets.Remove(tweet);
                }
                dbContext.Users.Remove(userToDelete);
                if (dbContext.SaveChanges() > 0)
                    return true;
                else
                    return false;
            }
        }
        private string Encryptdata(string password)
        {
            string strmsg = string.Empty;
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            strmsg = Convert.ToBase64String(encode);
            return strmsg;
        }

        public bool Add(User user)
        {
            using (var dbContext = new TwitterEntities())
            {
                user.Password = Encryptdata(user.Password);
                dbContext.Users.Add(user);
                if (dbContext.SaveChanges() > 0)
                    return true;
                else
                    return false;
            }
        }
        public User GetUserForLogin(string email)
        {
            using (var dbContext = new TwitterEntities())
            {
                var user=dbContext.Users.Where(currentUser => currentUser.Email == email).FirstOrDefault();
                return user;
            }
        }
        public bool Activated(string email)
        {
            using (var dbContext = new TwitterEntities())
            {
                 var result = dbContext.Users.Where(currentUser => currentUser.Email == email).FirstOrDefault();
                 result.Activated = true;
                 dbContext.Users.Attach(result);
                 dbContext.Entry(result).State = EntityState.Modified;
                if ( dbContext.SaveChanges() > 0)
                    return true; 
                else
                    return false;
            }
        }
        public bool ConfirmActivated(string email)
        {
            using (var dbContext = new TwitterEntities())
            {
                var activated = dbContext.Users.Any(currentUser => currentUser.Email == email && currentUser.Activated == true);
                if (activated == true)
                    return true;
                else
                    return false;
            }
        }
    }
}
