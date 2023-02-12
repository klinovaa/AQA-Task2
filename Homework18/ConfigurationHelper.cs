using Microsoft.Extensions.Configuration;

namespace Homework18
{
    public static class ConfigurationHelper
    {
        private static readonly IConfiguration Configuration;
        public static string LocalDBConnectionString { get; set; }

        static ConfigurationHelper()
        {
            Configuration = new ConfigurationBuilder().AddJsonFile("config.json").Build();
            SetValues();
        }

        public static void SetValues()
        {
            LocalDBConnectionString = Configuration.GetConnectionString("LocalAdonetDB");
        }
    }
}
