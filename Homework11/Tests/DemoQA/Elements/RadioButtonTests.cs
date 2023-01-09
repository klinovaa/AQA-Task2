using Homework11.Common.Drivers;
using Homework11.Data;
using Homework11.Data.Constants;
using Homework11.PageObjects.DemoQA.Elements;
using NUnit.Framework;

namespace Homework11.Tests.DemoQA.Elements
{
    public class RadioButtonTests : BaseTest
    {
        [SetUp]
        public void RadioButtonTestsSetUp()
        {
            //used GoToUrl(TestSettings.DemoQARadioButtonPageUrl) to make sure that each test from RadioButtonsTests will start from initial state
            WebDriverFactory.Driver.Navigate().GoToUrl(TestSettings.DemoQARadioButtonPageUrl);
        }

        [Test]
        public void CountAllRadioButtonsAndCheckNames()
        {
            //initialize Page Object
            var radioButtonPage = new RadioButtonPage();

            //methods from Page Objects
            //find radiobuttons and count them
            var size = radioButtonPage.GetAmountOfRadioButtons();
            Assert.AreEqual(RadioButtons.AmountValue, size);

            //check text for yes button
            var yesRadioText = radioButtonPage.GetYesRadioText();
            Assert.AreEqual(RadioButtons.YesValue, yesRadioText);

            //check text for impressive button
            var impressiveRadioText = radioButtonPage.GetImpressiveRadioText();
            Assert.AreEqual(RadioButtons.ImpressiveValue, impressiveRadioText);

            //check text for no button
            var noRadioText = radioButtonPage.GetNoRadioText();
            Assert.AreEqual(RadioButtons.NoValue, noRadioText);
        }

        [Test]
        public void ClickEveryRadioButtonAndVerifyPrintedText()
        {
            //initialize Page Object
            var radioButtonPage = new RadioButtonPage();

            //methods from Page Objects
            var size = radioButtonPage.GetAmountOfRadioButtons();

            //check text after clicking on radiobutton
            for (var i = 0; i < size; i++)
            {
                var radio = radioButtonPage.GetRadioButtonAt(i);
                if (radio.Enabled == true)
                {
                    Assert.IsTrue(!radio.Selected);
                    radioButtonPage.ClickLabel(i);
                    Assert.IsTrue(radio.Selected);
                    var resultText = radioButtonPage.GetResultText();
                    var labelText = radioButtonPage.GetLabelText(i);
                    Assert.AreEqual(RadioButtons.PrintedText + labelText, resultText);
                }
                else
                {
                    Assert.IsFalse(radio.Enabled);
                    radioButtonPage.ClickLabel(i);
                    Assert.IsFalse(radio.Selected);
                }
            }
        }
    }
}
