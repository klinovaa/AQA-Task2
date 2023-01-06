using Homework11.Common.WebElements;
using OpenQA.Selenium;

namespace Homework11.PageObjects.DemoQA.Elements
{
    public class RadioButtonPage : BaseDemoQAPage
    {
        private MyRadioButton _allRadioButtons = new MyRadioButton(By.XPath("//*[@type='radio']"));
        private MyRadioButton _yesRadio = new MyRadioButton(By.XPath("//*[@for='yesRadio']"));
        private MyRadioButton _impressiveRadio = new MyRadioButton(By.XPath("//*[@for='impressiveRadio']"));
        private MyRadioButton _noRadio = new MyRadioButton(By.XPath("//*[@for='noRadio']"));
        private MyRadioButton _allRadioLabels = new MyRadioButton(By.XPath("//label"));
        private MyRadioButton _resultText = new MyRadioButton(By.XPath("//*[@class='mt-3']"));

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
