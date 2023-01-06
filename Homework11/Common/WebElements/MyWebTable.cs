using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11.Common.WebElements
{
    public class MyWebTable : MyWebElement
    {
        public MyWebTable(By by) : base(by)
        {
        }

        public IWebElement GetElementAt(int i) => FindElements(By).ElementAt(i);
    }
}
