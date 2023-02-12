using Homework18_EF;
using System.Data.Entity.Core.EntityClient;

namespace Homework18
{
    public static class EntityFrameworkHelper
    {
        public static string GetClientExtendedConnectionString(string sqlConnectionString)
        {
            var entityBuilder = new EntityConnectionStringBuilder
            {
                Provider = "System.Data.SqlClient",
                ProviderConnectionString = sqlConnectionString,
                Metadata = "res://*/AdonetDB.csdl|res://*/AdonetDB.ssdl|res://*/AdonetDB.msl"
            };

            return entityBuilder.ToString();
        }

        public static List<T> GetAdonetDbInstance<T>(Func<adonetdbEntities, IQueryable<T>> func)
        {
            using (var context = new adonetdbEntities(GetClientExtendedConnectionString(ConfigurationHelper.LocalDBConnectionString)))
            {
                var result = func(context);

                return result.ToList();
            }
        }

        public static List<User> GetAdonetDbInstance(Func<adonetdbEntities, IQueryable<User>> func)
        {
            using (var context = new adonetdbEntities(GetClientExtendedConnectionString(ConfigurationHelper.LocalDBConnectionString)))
            {
                var result = func(context);

                return result.ToList();
            }
        }

        public static adonetdbEntities GetAdonetdbEntities() =>
            new adonetdbEntities(GetClientExtendedConnectionString(ConfigurationHelper.LocalDBConnectionString));

        public static void AddNewEntryToUsers(User newUser)
        {
            using (var context = new adonetdbEntities(GetClientExtendedConnectionString(ConfigurationHelper.LocalDBConnectionString)))
            {
                context.Users.Add(newUser);
                context.SaveChanges();
            }
        }

        public static User GetLastEntryFromUsers(string name)
        {
            using (var context = new adonetdbEntities(GetClientExtendedConnectionString(ConfigurationHelper.LocalDBConnectionString)))
            {
                return context.Users
                      .Where(u => u.Name == name)
                      .ToList()
                      .LastOrDefault();
            }
        }
    }
}
