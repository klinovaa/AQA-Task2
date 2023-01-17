using Homework17.HttpClients;
using Homework17.Models.JsonModels;
using Homework17.Models;

namespace Homework17.Services
{
    public class ReqresService
    {
        private const string BaseUrl = "https://reqres.in/api";

        public static RestResponse<AllUsers> GetAllUsersInfo() =>
            BasicHttpClient.PerformGetRequest<AllUsers>($"{BaseUrl}/users", null);

        public static RestResponse<Root> GetUserInfo(int id) =>
            BasicHttpClient.PerformGetRequest<Root>($"{BaseUrl}/users/{id}", null);

        public static RestResponse<CreatedUser> CreateUser(UserToCreate userToCreate) =>
            BasicHttpClient.PerformPostRequest<UserToCreate, CreatedUser>($"{BaseUrl}/users", userToCreate, null);
    }
}
