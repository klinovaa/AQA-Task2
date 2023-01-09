using NUnit.Framework;
using Homework11.Common.Drivers;

namespace Homework11.Tests
{
    public class BaseTest
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            //here you can add all the necessary methods to call them once before all tests in descendant classes

            //just e.g. set custom size of window
            WebDriverFactory.Driver.Manage().Window.Size = new System.Drawing.Size(1200, 800);
        }

        [SetUp]
        public void SetUp()
        {
            //here you can add all the necessary methods to call them once before each test in descendant classes
        }

        [TearDown]
        public void TearDown()
        {
            //here you can add all necessary methods to call them after each test in descendant classes
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            //here you can add all necessary methods to call them once after all tests in descendant classes
            WebDriverFactory.QuitDriver();
        }
    }
}
