using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework11.Common.Extensions
{
    public static class WebDriverExtensions
    {
        //extension method to get WebDriverWait
        //"this IwebDriver Drive" shows that this method extends IWebDriver Functionality
        public static WebDriverWait GetWebDriverWait(this IWebDriver driver, int timeoutSeconds = 30, TimeSpan? pollingInterval = null, params Type[] exceptionTypes)
        {
            var webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutSeconds));
            if (pollingInterval != null) //we can set our custom polling interval (e.g. TimeSpan.FromSeconds(5))
            {
                webDriverWait.PollingInterval = (TimeSpan)pollingInterval; 
            }
            
            webDriverWait.IgnoreExceptionTypes(exceptionTypes); //allows us to ignore any type of exception (e.g. StaleElementReferenceException)

            return webDriverWait;
        }

        //extension method to perform FindElement with explicit wait
        public static IWebElement GetWebElementWhenExist(this IWebDriver driver, By by) => driver.GetWebDriverWait().Until(drv => drv.FindElement(by));
    }
}
