using Homework18.Models;
using NUnit.Framework;

namespace Homework18
{
    public class AdonetDbTests
    {
        [Test]
        public void CreateNewUserViaAdonetAndCheckData()
        {
            var newUser = new User(25, "Kyli");

            AdonetDbHelper.AddNewEntryToUsers(newUser.Name, newUser.Age);

            var nameInDB = AdonetDbHelper.GetLastEntryValueFromUsers("Name");
            var ageInDB = AdonetDbHelper.GetLastEntryValueFromUsers("Age");

            Assert.AreEqual(newUser.Name, nameInDB);
            Assert.AreEqual(newUser.Age.ToString(), ageInDB);
        }
    }
}