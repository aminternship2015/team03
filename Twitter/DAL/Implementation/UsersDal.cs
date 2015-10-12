using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
                dbContext.Users.Remove(userToDelete);
                dbContext.SaveChanges();
                return  true;
            }
        }
        public bool Add(User user)
        {
            using (var dbContext = new TwitterEntities())
            {
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
                return true;
            }
        }
        public bool GetUserForLogin(string email, string password)
        {
            using (var dbContext = new TwitterEntities())
            {
                var user=dbContext.Users.Any(currentUser => currentUser.Email == email && currentUser.Password == password);
                return user;
            }
        }
    }
}
