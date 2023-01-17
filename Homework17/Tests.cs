using Homework17.HttpClients;
using Homework17.Models.JsonModels;
using Homework17.Services;
using NUnit.Framework;
using System.Net;

namespace Homework17
{
    public class Tests
    {
        private const string Url = "https://reqres.in/api/users";

        [Test]
        public void Test1GetNotFoundUser()
        {
            var userToCreate = new UserToCreate()
            {
                Name = "morpheus",
                Job = "leader"
            };
            var responseUserToCreate = ReqresService.CreateUser(userToCreate);
            var responseGetCreatedUser = ReqresService.GetUserInfo(responseUserToCreate.responseModel.Id);

            Assert.AreEqual(HttpStatusCode.NotFound, responseGetCreatedUser.StatusCode);
        }

        [Test]
        public void TestCreateUserAndCompareData()
        {
            var userToCreate = new UserToCreate()
            {
                Name = "morpheus",
                Job = "leader"
            };
            var responseUserToCreate = BasicHttpClient.PerformPostRequest<UserToCreate, CreatedUser>(Url, userToCreate, null);
            
            Assert.AreEqual(userToCreate.Name, responseUserToCreate.responseModel.Name);
            Assert.AreEqual(userToCreate.Job, responseUserToCreate.responseModel.Job);
            Assert.IsNotNull(responseUserToCreate.responseModel.Id);
        }

        [Test]
        public void TestCompareUserInfo()
        {
            var responseGetAllUsers = ReqresService.GetAllUsersInfo();
            var firstNameFromCommonRequest = responseGetAllUsers.responseModel.Data[0].First_name;
            var lastNameFromCommonRequest = responseGetAllUsers.responseModel.Data[0].Last_name;
            var idFromCommonRequest = responseGetAllUsers.responseModel.Data[0].Id;
            var avatarFromCommonRequest = responseGetAllUsers.responseModel.Data[0].Avatar;

            var responseGetFirstUser = ReqresService.GetUserInfo(idFromCommonRequest);
            var firstNameFromSecondRequest = responseGetFirstUser.responseModel.Data.First_name;
            var lastNameFromSecondRequest = responseGetFirstUser.responseModel.Data.Last_name;
            var idFromSecondRequest = responseGetFirstUser.responseModel.Data.Id;
            var avatarFromSecondRequest = responseGetFirstUser.responseModel.Data.Avatar;

            Assert.AreEqual(firstNameFromCommonRequest, firstNameFromSecondRequest);
            Assert.AreEqual(lastNameFromCommonRequest, lastNameFromSecondRequest);
            Assert.AreEqual(idFromCommonRequest, idFromSecondRequest);
            Assert.AreEqual(avatarFromCommonRequest, avatarFromSecondRequest);
        }
    }
}
