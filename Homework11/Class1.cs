using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Homework11
{
    public class Class1
    {
        private IWebDriver _driver;
        private Actions _driverActions;
        private IJavaScriptExecutor _javaScriptExecutor;
        private WebDriverWait _driverWait;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driverActions = new Actions(_driver);
            _javaScriptExecutor = (IJavaScriptExecutor)_driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }

        [Test]
        public void CheckboxTest1()
        {
            _driver.Navigate().GoToUrl("https://demoqa.com/checkbox");

            //find all checkboxes and count them
            var checkboxes = _driver.FindElements(By.XPath("//*[@type='checkbox']"));
            int size = checkboxes.Count();
            Assert.AreEqual(1, size);

            //expand all and count chechboxes
            var expandAll = _driver.FindElement(By.XPath("//*[@title='Expand all']"));
            expandAll.Click();
            checkboxes = _driver.FindElements(By.XPath("//*[@type='checkbox']"));
            size = checkboxes.Count();
            Assert.AreEqual(17, size);

            //collapse all and count checkboxes again
            var collapseAll = _driver.FindElement(By.XPath("//*[@title='Collapse all']"));
            collapseAll.Click();
            checkboxes = _driver.FindElements(By.XPath("//*[@type='checkbox']"));
            size = checkboxes.Count();
            Assert.AreEqual(1, size);
        }

        [Test]
        public void CheckboxTest2()
        {
            _driver.Navigate().GoToUrl("https://demoqa.com/checkbox");

            var printedText = "You have selected :\r\n";
            var actualResultText = "";

            var expandAll = _driver.FindElement(By.XPath("//*[@title='Expand all']"));
            expandAll.Click();

            var chooseAll = _driver.FindElement(By.XPath("//*[@class='rct-checkbox']"));
            chooseAll.Click();

            var checkboxes = _driver.FindElements(By.XPath("//*[@type='checkbox']"));
            var checkboxLabels = _driver.FindElements(By.XPath("//*[@class='rct-title']"));
            var resultText = _driver.FindElement(By.Id("result"));

            //check text after checking All checkboxes
            for (var i = 0; i < checkboxes.Count; i++)
            {
                var checkbox = checkboxes.ElementAt(i);
                var label = checkboxLabels.ElementAt(i).Text;
                Assert.IsTrue(checkbox.Selected);
                if (label == "Word File.doc")
                {
                    actualResultText += "wordFile\r\n";
                }
                else if (label == "Excel File.doc")
                {
                    actualResultText += "excelFile";
                }
                else
                {
                    actualResultText += label.ToLower() + "\r\n";
                }
            }
            Assert.AreEqual(resultText.Text, printedText + actualResultText);
        }

        [Test]
        public void RadioButtonTest1()
        {
            _driver.Navigate().GoToUrl("https://demoqa.com/radio-button");

            //find radiobuttons and count them
            var radioButtons = _driver.FindElements(By.XPath("//*[@type='radio']"));
            int size = radioButtons.Count();
            Assert.AreEqual(3, size);

            //check text for yes button
            var yesRadio = _driver.FindElement(By.XPath("//*[@for='yesRadio']"));
            var radioText1 = yesRadio.Text;
            Assert.AreEqual("Yes", radioText1);
            
            //check text for impressive button
            var impressiveRadio = _driver.FindElement(By.XPath("//*[@for='impressiveRadio']"));
            var radioText2 = impressiveRadio.Text;
            Assert.AreEqual("Impressive", radioText2);

            //check text for no button
            var noRadio = _driver.FindElement(By.XPath("//*[@for='noRadio']"));
            var radioText3 = noRadio.Text;
            Assert.AreEqual("No", radioText3);
       }

        [Test]
        public void RadioButtonTest2()
        {
            _driver.Navigate().GoToUrl("https://demoqa.com/radio-button");

            //find radiobuttons and their labels
            var radioButtons = _driver.FindElements(By.XPath("//*[@type='radio']"));
            var radioLabels = _driver.FindElements(By.XPath("//label"));
            int size = radioButtons.Count();
            Assert.AreEqual(3, size);

            var printedText = "You have selected ";

            //check text after clicking on radiobutton
            for (var i = 0; i < size; i++)
            {
                var radio = radioButtons.ElementAt(i);
                var label = radioLabels.ElementAt(i);
                if (radio.Enabled == true)
                {
                    Assert.IsTrue(!radio.Selected);
                    label.Click();
                    var resultText = _driver.FindElement(By.XPath("//*[@class='mt-3']"));
                    Assert.IsTrue(radio.Selected);
                    Assert.AreEqual(resultText.Text, printedText + label.Text);
                }
                else
                {
                    Assert.IsFalse(radio.Enabled);
                    label.Click();
                    Assert.IsFalse(radio.Selected);
                }
            }
        }

        [Test]
        public void WebTablesTest1()
        {
            _driver.Navigate().GoToUrl("https://demoqa.com/webtables");

            var addButton = _driver.FindElement(By.Id("addNewRecordButton"));
            addButton.Click();

            var firstName = "Name";
            var firstNameTextBox = _driver.FindElement(By.Id("firstName"));
            firstNameTextBox.SendKeys(firstName);

            var lastName = "Surname";
            var lastNameTextBox = _driver.FindElement(By.Id("lastName"));
            lastNameTextBox.SendKeys(lastName);

            var email = "testemail@gmail.com";
            var emailTextBox = _driver.FindElement(By.Id("userEmail"));
            emailTextBox.SendKeys(email);

            var age = "25";
            var ageTextBox = _driver.FindElement(By.Id("age"));
            ageTextBox.SendKeys(age);

            var salary = "500";
            var salaryTextBox = _driver.FindElement(By.Id("salary"));
            salaryTextBox.SendKeys(salary);

            var department = "QA";
            var departmentTextBox = _driver.FindElement(By.Id("department"));
            departmentTextBox.SendKeys(department);

            var submitButton = _driver.FindElement(By.Id("submit"));
            submitButton.Click();

            var comparableValues = new List<String>() { firstName, lastName, age, email, salary, department };
            var neededRow = _driver.FindElements(By.XPath("//*[@class='rt-tr-group'][4]//*[@class='rt-td']"));
            var actualValues = new List<Object>();

            for (var i = 0; i < neededRow.Count - 1; i++)
            {
                actualValues.Add(neededRow[i].Text);
            }

            Assert.AreEqual(comparableValues, actualValues);
        }

        [Test]
        public void ButtonsTest1()
        {
            _driver.Navigate().GoToUrl("https://demoqa.com/buttons");

            var doubleClickPrintedText = "You have done a double click";
            var rightClickPrintedText = "You have done a right click";
            var dynamicClickPrintedText = "You have done a dynamic click";

            //check text after clicking double click button
            var doubleClickButton = _driver.FindElement(By.XPath("//*[text()='Double Click Me']"));//сделала через xpath потому что почему-то иногда by.id воспринимает как by.css
            _driverActions.DoubleClick(doubleClickButton).Perform();
            var doubleClickMessage = _driver.FindElement(By.Id("doubleClickMessage"));
            Assert.AreEqual(doubleClickPrintedText, doubleClickMessage.Text);

            //check text after right clicking button
            var rightClickButton = _driver.FindElement(By.XPath("//*[text()='Right Click Me']"));
            _driverActions.ContextClick(rightClickButton).Perform();
            var rightClickMessage = _driver.FindElement(By.Id("rightClickMessage"));
            Assert.AreEqual(rightClickPrintedText, rightClickMessage.Text);

            //check text after clicking button with dynamic id
            var dynamicClickButton = _driver.FindElement(By.XPath("//*[text()='Click Me']"));
            _driverActions.Click(dynamicClickButton).Perform();
            var dynamicClickMessage = _driver.FindElement(By.Id("dynamicClickMessage"));
            Assert.AreEqual(dynamicClickPrintedText, dynamicClickMessage.Text);           
        }

        [Test]
        public void LinksTest1()
        {
            _driver.Navigate().GoToUrl("https://demoqa.com/links");

            var links = _driver.FindElements(By.XPath("//*[@id='linkWrapper']/p/a"));

            //check Following links will open new tab
            for (var i = 0; i < 2; i++)
            {
                var link = links.ElementAt(i);

                if (link.GetAttribute("id") == "dynamicLink")
                {
                    link = _driver.FindElement(By.Id("dynamicLink"));   
                }
                
                link.Click();

                //switch to new tab
                var browserTabs = _driver.WindowHandles;
                _driver.SwitchTo().Window(browserTabs[1]);
                var imgOnSecondPage = _driver.FindElement(By.XPath("//*[@alt='Selenium Online Training']"));
                bool imagePresent = imgOnSecondPage.Displayed;
                Assert.IsTrue(imagePresent);

                //close new tab and switch back
                _driver.Close();
                _driver.SwitchTo().Window(browserTabs[0]);
            }
        }

        [Test]
        public void LinksTest2()
        {
            _driver.Navigate().GoToUrl("https://demoqa.com/links");

            var links = _driver.FindElements(By.XPath("//*[@id='linkWrapper']/p/a"));

            var printedText1 = "Link has responded with staus ";
            var printedText2 = " and status text ";

            //check Following links will send an api call
            for (var i = 2; i < links.Count; i++)
            {
                var link = links.ElementAt(i);

                _javaScriptExecutor.ExecuteScript("arguments[0].scrollIntoView()", link);
                link.Click();
                Thread.Sleep(3000);
                var name = link.Text;
                var status = 0;

                switch (name)
                {
                    case "Created":
                        status = 201;
                        name = "Created";
                        break;
                    case "No Content":
                        status = 204;
                        name = "No Content";
                        break;
                    case "Moved":
                        status = 301;
                        name = "Moved Permanently";
                        break;
                    case "Bad Request":
                        status = 400;
                        name = "Bad Request";
                        break;
                    case "Unauthorized":
                        status = 401;
                        name = "Unauthorized";
                        break;
                    case "Forbidden":
                        status = 403;
                        name = "Forbidden";
                        break;
                    case "Not Found":
                        status = 404;
                        name = "Not Found";
                        break;
                }

                var resultText = _driverWait.Until(drv => drv.FindElement(By.Id("linkResponse")));
                Assert.AreEqual(resultText.Text, printedText1 + status + printedText2 + name);
            }
        }


        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }
    }
}