using Homework11.Common.Drivers;
using Homework11.Data;
using Homework11.Data.Constants;
using Homework11.PageObjects.DemoQA.Elements;
using NUnit.Framework;

namespace Homework11.Tests.DemoQA.Elements
{
    public class CheckBoxTests : BaseTest
    {
        [SetUp]
        public void CheckBoxTestsSetUp()
        {
            //used GoToUrl(TestSettings.DemoQACheckBoxPageUrl) to make sure that each test from CheckBoxTests will start from initial state
            WebDriverFactory.Driver.Navigate().GoToUrl(TestSettings.DemoQACheckBoxPageUrl);
        }

        [Test]
        public void CountAllCheckBoxesBeforeAndAfterCollapse()
        {
            //initialize Page Object
            var checkBoxPage = new CheckBoxPage();

            //methods from Page Objects
            //find all checkboxes and count them
            var size = checkBoxPage.GetAmountOfCheckBoxes();
            Assert.AreEqual(CheckBoxes.amountValueCollapsed, size);

            //expand all and count chechboxes
            checkBoxPage.ExpandAllCheckboxes();
            size = checkBoxPage.GetAmountOfCheckBoxes();
            Assert.AreEqual(CheckBoxes.amountValueExpanded, size);

            //collapse all and count checkboxes again
            checkBoxPage.CollapseAllCheckboxes();
            size = checkBoxPage.GetAmountOfCheckBoxes();
            Assert.AreEqual(CheckBoxes.amountValueCollapsed, size);
        }

        [Test]
        public void CheckAllCheckboxesAndCheckText()
        {
            //initialize Page Object
            var checkBoxPage = new CheckBoxPage();

            //methods from Page Objects
            var actualResultText = "";

            checkBoxPage.ExpandAllCheckboxes();
            checkBoxPage.ChooseAllCheckboxes();
            var size = checkBoxPage.GetAmountOfCheckBoxes();

            //check text after checking All checkboxes
            for (var i = 0; i < size; i++)
            {
                var checkbox = checkBoxPage.GetCheckBoxAt(i);
                var label = checkBoxPage.GetCheckLabelText(i);

                Assert.IsTrue(checkbox.Selected);

                if (label == "Word File.doc")
                {
                    actualResultText += "wordFile\r\n";
                }
                else if (label == "Excel File.doc")
                {
                    actualResultText += "excelFile";
                }
                else
                {
                    actualResultText += label.ToLower() + "\r\n";
                }
            }
            
            var resultText = checkBoxPage.GetResultText();

            Assert.AreEqual(resultText, CheckBoxes.printedTextWhenSelected + actualResultText);
        }
    }
}
