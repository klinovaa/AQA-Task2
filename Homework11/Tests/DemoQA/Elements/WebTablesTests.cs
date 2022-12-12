using Homework11.Common.Drivers;
using Homework11.Data.Constants;
using Homework11.Data;
using Homework11.PageObjects.DemoQA.Elements;
using NUnit.Framework;
using Homework11.PageObjects.DemoQA.Popups;

namespace Homework11.Tests.DemoQA.Elements
{
    internal class WebTablesTests : BaseTest
    {
        [SetUp]
        public void WebTablesTestsSetUp()
        {
            //used GoToUrl(TestSettings.DemoQAWebTablesPageUrl) to make sure that each test from WebTablesTests will start from initial state
            WebDriverFactory.Driver.Navigate().GoToUrl(TestSettings.DemoQAWebTablesPageUrl);
        }

        [Test]
        public void CountAllRadioButtonsAndCheckNames()
        {
            //initialize Page Object
            var webTablesPage = new WebTablesPage();

            //methods from Page Objects
            //find radiobuttons and count them
            webTablesPage.ClickAddButton();

            //initialize Popup
            var registrationForm = new RegistrationForm();

            registrationForm.EnterFirstName(WebTables.firstName);
            registrationForm.EnterLastName(WebTables.lastName);
            registrationForm.EnterEmail(WebTables.email);
            registrationForm.EnterAge(WebTables.age);
            registrationForm.EnterSalary(WebTables.salary);
            registrationForm.EnterDepartment(WebTables.department);

            registrationForm.ClickSubmitButton();

            var comparableValues = new List<String>() { WebTables.firstName, WebTables.lastName, WebTables.age, WebTables.email, WebTables.salary, WebTables.department };
            var actualValues = new List<Object>();
            var size = webTablesPage.GetAmountOfCells() - 1;
            for (var i = 0; i < size; i++)
            {
                actualValues.Add(webTablesPage.GetCellText(i));
            }

            Assert.AreEqual(comparableValues, actualValues);
        }
    }
}
