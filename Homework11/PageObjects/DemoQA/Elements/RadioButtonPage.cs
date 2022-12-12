using Homework11.Common.WebElements;
using OpenQA.Selenium;

namespace Homework11.PageObjects.DemoQA.Elements
{
    public class RadioButtonPage : BaseDemoQAPage
    {
        private MyWebElement _allRadioButtons = new MyWebElement(By.XPath("//*[@type='radio']"));
        private MyWebElement _yesRadio = new MyWebElement(By.XPath("//*[@for='yesRadio']"));
        private MyWebElement _impressiveRadio = new MyWebElement(By.XPath("//*[@for='impressiveRadio']"));
        private MyWebElement _noRadio = new MyWebElement(By.XPath("//*[@for='noRadio']"));
        private MyWebElement _allRadioLabels = new MyWebElement(By.XPath("//label"));
        private MyWebElement _resultText = new MyWebElement(By.XPath("//*[@class='mt-3']"));

        public string GetYesRadioText() => _yesRadio.Text;

        public string GetImpressiveRadioText() => _impressiveRadio.Text;

        public string GetNoRadioText() => _noRadio.Text;

        public int GetAmountOfRadioButtons() => _allRadioButtons.GetAmountOfElements();

        public IWebElement GetRadioButtonAt(int index) => _allRadioButtons.GetElementAt(index);

        public IWebElement GetRadioLabelAt(int index) => _allRadioLabels.GetElementAt(index);

        public void ClickLabel(int index) => _allRadioLabels.GetElementAt(index).Click();

        public string GetResultText() => _resultText.Text;

        public string GetLabelText(int index) => _allRadioLabels.GetElementAt(index).Text;
    }
}
