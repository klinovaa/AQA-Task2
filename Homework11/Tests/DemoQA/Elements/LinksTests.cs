using Homework11.Common.Drivers;
using Homework11.Data;
using Homework11.Data.Constants;
using Homework11.PageObjects.DemoQA.Elements;
using NUnit.Framework;

namespace Homework11.Tests.DemoQA.Elements
{
    public class LinksTests : BaseTest
    {
        [SetUp]
        public void LinksTestsSetUp()
        {
            //used GoToUrl(TestSettings.DemoQALinksPageUrl) to make sure that each test from LinksTests will start from initial state
            WebDriverFactory.Driver.Navigate().GoToUrl(TestSettings.DemoQALinksPageUrl);
        }

        [Test]
        public void LinksOpenTabs()
        {
            //initialize Page Object
            var linksPage = new LinksPage();

            //methods from Page Objects
            //check Following links will open new tab
            for (var i = 0; i < Links.linksThatOpenNewTab; i++)
            {
                var link = linksPage.GetLinkAt(i);

                if (link.GetAttribute("id") == "dynamicLink")
                {
                    linksPage.ClickDynamicLink();
                }
                else
                {
                    linksPage.ClickLink(i);
                }

                //switch to new tab
                var browserTabs = WebDriverFactory.Driver.WindowHandles;
                WebDriverFactory.Driver.SwitchTo().Window(browserTabs[1]);
                bool imagePresent = linksPage.ImageIsPresent();
                Assert.IsTrue(imagePresent);

                //close new tab and switch back
                WebDriverFactory.Driver.Close();
                WebDriverFactory.Driver.SwitchTo().Window(browserTabs[0]);
            }
        }

        [Test]
        public void ClickOnLinksAndCheckStatusAndText()
        {
            //initialize Page Object
            var linksPage = new LinksPage();

            //methods from Page Objects
            //check Following links will send an api call
            var size = linksPage.GetAmountOfLinks();

            for (var i = Links.indexOfFirstLinkToCallApi; i < size; i++)
            {
                var link = linksPage.GetLinkAt(i);
                WebDriverFactory.JavaScriptExecutor.ExecuteScript("arguments[0].scrollIntoView()", link);//пока не понимаю, как переиспользовать ScrollIntoView()
                linksPage.ClickLink(i);
                Thread.Sleep(3000);
                var name = linksPage.GetLinkName(i);
                var status = 0;

                switch (name)
                {
                    case "Created":
                        status = 201;
                        name = "Created";
                        break;
                    case "No Content":
                        status = 204;
                        name = "No Content";
                        break;
                    case "Moved":
                        status = 301;
                        name = "Moved Permanently";
                        break;
                    case "Bad Request":
                        status = 400;
                        name = "Bad Request";
                        break;
                    case "Unauthorized":
                        status = 401;
                        name = "Unauthorized";
                        break;
                    case "Forbidden":
                        status = 403;
                        name = "Forbidden";
                        break;
                    case "Not Found":
                        status = 404;
                        name = "Not Found";
                        break;
                }

                var resultText = linksPage.GetResultText();
                Assert.AreEqual(resultText, Links.partOneOfPrintedText + status + Links.partTwoOfPrintedText + name);
            }
        }
    }
}
