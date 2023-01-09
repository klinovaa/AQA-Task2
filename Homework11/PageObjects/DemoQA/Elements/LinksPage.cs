using Homework11.Common.WebElements;
using OpenQA.Selenium;

namespace Homework11.PageObjects.DemoQA.Elements
{
    public class LinksPage : BaseDemoQAPage
    {
        private MyWebElement _allLinks = new MyWebElement(By.XPath("//*[@id='linkWrapper']/p/a"));
        private MyWebElement _dynamicLink = new MyWebElement(By.Id("dynamicLink"));
        private MyWebElement _imgOnMainPage = new MyWebElement(By.XPath("//*[@alt='Selenium Online Training']"));
        private MyWebElement _resultText = new MyWebElement(By.Id("linkResponse"));

        public IWebElement GetLinkAt(int index) => _allLinks.GetElementAt(index);

        public void ClickLink(int index) => _allLinks.GetElementAt(index).Click(); //почему-то использует click() IWebElement, а не MyWebElement :(

        public void ClickDynamicLink() => _dynamicLink.Click();

        public bool ImageIsPresent() => _imgOnMainPage.Displayed;

        public int GetAmountOfLinks() => _allLinks.GetAmountOfElements();

        public string GetLinkName(int index) => _allLinks.GetElementAt(index).Text;

        //public void ScrollLinkIntoView() => _allLinks.GetElementAt(index).ScrollIntoView(); //а так нельзя из-за индекса

        public string GetResultText() => _resultText.Text;
    }
}
