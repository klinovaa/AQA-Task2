using Homework11.Data.Enums;
using Microsoft.Extensions.Configuration;

namespace Homework11.Data
{
    //to make it parallelizable you have to remove static
    public static class TestSettings
    {
        public static Browsers Browser { get; set; }

        public static string DemoQACheckBoxPageUrl { get; set; }

        public static string DemoQARadioButtonPageUrl { get; set; }

        public static string DemoQAButtonsPageUrl { get; set; }

        public static string DemoQALinksPageUrl { get; set; }

        public static string DemoQAWebTablesPageUrl { get; set; }

        //after Built() it will contain context of our .json file
        public static IConfiguration TestConfiguration { get; } = new ConfigurationBuilder().AddJsonFile("testsettings.json").Build();

        static TestSettings()
        {
            //easy way to get values from .json file by keys like these
            Enum.TryParse(TestConfiguration["Common:Browser"], out Browsers browser);
            Browser = browser;
            DemoQACheckBoxPageUrl = TestConfiguration["Common:DemoQAUrls:CheckBoxPage"];
            DemoQARadioButtonPageUrl = TestConfiguration["Common:DemoQAUrls:RadioButtonPage"];
            DemoQAButtonsPageUrl = TestConfiguration["Common:DemoQAUrls:ButtonsPage"];
            DemoQALinksPageUrl = TestConfiguration["Common:DemoQAUrls:LinksPage"];
            DemoQAWebTablesPageUrl = TestConfiguration["Common:DemoQAUrls:WebTablesPage"];
        }
    }
}
