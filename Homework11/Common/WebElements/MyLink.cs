using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11.Common.WebElements
{
    public class MyLink : MyWebElement
    {
        public MyLink(By by) : base(by)
        {
        }

        public IWebElement GetElementAt(int i) => FindElements(By).ElementAt(i);
    }
}
