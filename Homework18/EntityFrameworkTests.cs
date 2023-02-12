using Homework18_EF;
using NUnit.Framework;

namespace Homework18
{
    public class EntityFrameworkTests
    {
        [Test]
        public void CreateNewUserViaEF()
        {
            var newUser = new User() { Age = 24, Name = "John" };

            EntityFrameworkHelper.AddNewEntryToUsers(newUser);

            var userInDB = EntityFrameworkHelper.GetLastEntryFromUsers(newUser.Name);

            Assert.AreEqual(newUser.Name, userInDB.Name);
            Assert.AreEqual(newUser.Age, userInDB.Age);
        }
    }
}