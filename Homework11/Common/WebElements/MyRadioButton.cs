using Homework11.Common.Drivers;
using Homework11.Common.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11.Common.WebElements
{
    public class MyRadioButton : MyWebElement
    {
        public MyRadioButton(By by) : base(by)
        {
        }

        public IWebElement GetElementAt(int i) => FindElements(By).ElementAt(i);
    }
}
