using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;

namespace UnitTest.TestsForDal
{
    
    [TestClass]
    public class Delete
    {
        [TestMethod]
        public void Delete_UserExist_True()
        {
            //arrange
            User user = new User()
            {
                First_Name = "Ion",
                Last_Name = "Rosca",
                Password = "54367821",
                Email = "Ion.Rosca@endava.com"
            };
            UsersDal User = new UsersDal();
            //act
            User.Add(user);
            bool result = User.Delete(user.id_user);
            
            //assert
            Assert.AreEqual(true, result);

        }
    }
}
