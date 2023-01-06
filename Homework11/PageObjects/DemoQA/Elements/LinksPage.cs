using Homework11.Common.WebElements;
using OpenQA.Selenium;

namespace Homework11.PageObjects.DemoQA.Elements
{
    public class LinksPage : BaseDemoQAPage
    {
        private MyLink _allLinks = new MyLink(By.XPath("//*[@id='linkWrapper']/p/a"));
        private MyLink _dynamicLink = new MyLink(By.Id("dynamicLink"));
        private MyLink _imgOnMainPage = new MyLink(By.XPath("//*[@alt='Selenium Online Training']"));
        private MyLink _resultText = new MyLink(By.Id("linkResponse"));

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
