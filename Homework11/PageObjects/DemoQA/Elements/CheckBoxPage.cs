using Homework11.Common.WebElements;
using OpenQA.Selenium;

namespace Homework11.PageObjects.DemoQA.Elements
{
    public class CheckBoxPage : BaseDemoQAPage
    {
        private MyCheckBox _allCheckBoxes = new MyCheckBox(By.XPath("//*[@type='checkbox']"));
        private MyWebElement _expandAll = new MyWebElement(By.XPath("//*[@title='Expand all']"));
        private MyWebElement _collapseAll = new MyWebElement(By.XPath("//*[@title='Collapse all']"));
        private MyWebElement _chooseAll = new MyWebElement(By.XPath("//*[@class='rct-checkbox']"));
        private MyWebElement _allCheckLabels = new MyWebElement(By.XPath("//*[@class='rct-title']"));
        private MyWebElement _resultText = new MyWebElement(By.Id("result"));

        public int GetAmountOfCheckBoxes() => _allCheckBoxes.GetAmountOfElements();

        public IWebElement GetCheckBoxAt(int index) => _allCheckBoxes.GetElementAt(index);

        public string GetCheckLabelText(int index) => _allCheckLabels.GetElementAt(index).Text;

        public string GetResultText() => _resultText.Text;

        public void ExpandAllCheckboxes() => _expandAll.Click();

        public void CollapseAllCheckboxes() => _collapseAll.Click();

        public void ChooseAllCheckboxes() => _chooseAll.Click();
    }
}
