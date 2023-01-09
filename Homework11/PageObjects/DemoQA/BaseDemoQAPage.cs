using Homework11.Common.WebElements;
using OpenQA.Selenium;

namespace Homework11.PageObjects.DemoQA
{
    public class BaseDemoQAPage : BasePage
    {
        public void ExpandCategory(string categoryName)
        {
            //base part of "element-group" item
            var elementGroupXPathLocator = $"//*[@class='element-group' and .//text()='{categoryName}']";

            //element with "collapse" class. When this one is expanded, class contains "show". this one is need to check if element is collapsed or expanded
            var elementWithCollapseClass = new MyWebElement(By.XPath($"{elementGroupXPathLocator}//div[contains(@class, 'collapse')]"));

            //element to click if "element-group" is collapsed to expand it
            var groupHeader = new MyWebElement(By.XPath($"{elementGroupXPathLocator}//*[@class='group-header']"));

            //click groupHeader if "element-group" is collapsed
            if (!elementWithCollapseClass.GetValueOfClassAttribute().Contains("show"))
            {
                groupHeader.Click();
            }
        }
    }
}
