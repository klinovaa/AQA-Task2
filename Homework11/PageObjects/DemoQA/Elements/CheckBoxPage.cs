using Homework11.Common.WebElements;
using OpenQA.Selenium;

namespace Homework11.PageObjects.DemoQA.Elements
{
    public class CheckBoxPage : BaseDemoQAPage
    {
        private MyCheckBox _allCheckBoxes = new MyCheckBox(By.XPath("//*[@type='checkbox']"));
        private MyCheckBox _expandAll = new MyCheckBox(By.XPath("//*[@title='Expand all']"));
        private MyCheckBox _collapseAll = new MyCheckBox(By.XPath("//*[@title='Collapse all']"));
        private MyCheckBox _chooseAll = new MyCheckBox(By.XPath("//*[@class='rct-checkbox']"));
        private MyCheckBox _allCheckLabels = new MyCheckBox(By.XPath("//*[@class='rct-title']"));
        private MyCheckBox _resultText = new MyCheckBox(By.Id("result"));

        public int GetAmountOfCheckBoxes() => _allCheckBoxes.GetAmountOfElements();

        public IWebElement GetCheckBoxAt(int index) => _allCheckBoxes.GetElementAt(index);

        public string GetCheckLabelText(int index) => _allCheckLabels.GetElementAt(index).Text;

        public string GetResultText() => _resultText.Text;

        public void ExpandAllCheckboxes() => _expandAll.Click();

        public void CollapseAllCheckboxes() => _collapseAll.Click();

        public void ChooseAllCheckboxes() => _chooseAll.Click();
    }
}
