using Homework11.Common.Drivers;
using Homework11.Data;
using Homework11.Data.Constants;
using Homework11.PageObjects.DemoQA.Elements;
using NUnit.Framework;

namespace Homework11.Tests.DemoQA.Elements
{
    public class ButtonsTests : BaseTest
    {
        [SetUp]
        public void ButtonsTestsSetUp()
        {
            //used GoToUrl(TestSettings.DemoQAButtonsPageUrl) to make sure that each test from ButtonsTests will start from initial state
            WebDriverFactory.Driver.Navigate().GoToUrl(TestSettings.DemoQAButtonsPageUrl);
        }

        [Test]
        public void ClickOnButtonsAndVerifyResult()
        {
            //initialize Page Object
            var buttonsPage = new ButtonsPage();

            //methods from Page Objects
            //check text after clicking double click button
            buttonsPage.DoubleClickButton();
            var doubleClickMessage = buttonsPage.GetDoubleClickMessageText();
            Assert.AreEqual(Buttons.doubleClickPrintedText, doubleClickMessage);

            //check text after right clicking button
            buttonsPage.RightClickButton();
            var rightClickMessage = buttonsPage.GetRightClickMessageText();
            Assert.AreEqual(Buttons.rightClickPrintedText, rightClickMessage);

            //check text after clicking button with dynamic id
            buttonsPage.DynamicClickButton();
            var dynamicClickMessage = buttonsPage.GetDynamicClickMessageText();
            Assert.AreEqual(Buttons.dynamicClickPrintedText, dynamicClickMessage);
        }
    }
}
