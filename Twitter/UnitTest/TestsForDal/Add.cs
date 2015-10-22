using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;

namespace UnitTest
{
    [TestClass]
    public class Add
    {


        [TestMethod]
        public void Add_AllFieldsAreRight_True()
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

            bool result = User.Add(user);
            User.Delete(user.id_user);
            //assert
            Assert.AreEqual(true, result);
            
        }
    }
}
