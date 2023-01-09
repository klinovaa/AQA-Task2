using Homework11.Common.WebElements;
using OpenQA.Selenium;

namespace Homework11.PageObjects.DemoQA.Elements
{
    public class ButtonsPage : BaseDemoQAPage
    {
        private MyWebElement _doubleClickButton = new MyWebElement(By.XPath("//*[text()='Double Click Me']"));
        private MyWebElement _doubleClickMessage = new MyWebElement(By.Id("doubleClickMessage"));
        private MyWebElement _rightClickButton = new MyWebElement(By.XPath("//*[text()='Right Click Me']"));
        private MyWebElement _rightClickMessage = new MyWebElement(By.Id("rightClickMessage"));
        private MyWebElement _dynamicClickButton = new MyWebElement(By.XPath("//*[text()='Click Me']"));
        private MyWebElement _dynamicClickMessage = new MyWebElement(By.Id("dynamicClickMessage"));

        public void DoubleClickButton() => _doubleClickButton.DoubleClickViaActions();

        public string GetDoubleClickMessageText() => _doubleClickMessage.Text;

        public void RightClickButton() => _rightClickButton.RightClickViaActions();

        public string GetRightClickMessageText() => _rightClickMessage.Text;

        public void DynamicClickButton() => _dynamicClickButton.DynamicClickViaActions();

        public string GetDynamicClickMessageText() => _dynamicClickMessage.Text;
    }
}
