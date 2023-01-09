using Homework11.Common.WebElements;
using OpenQA.Selenium;

namespace Homework11.PageObjects.DemoQA.Popups
{
    public class RegistrationForm : BasePopup
    {
        private MyWebElement _firstNameTextBox = new MyWebElement(By.Id("firstName"));
        private MyWebElement _lastNameTextBox = new MyWebElement(By.Id("lastName"));
        private MyWebElement _emailTextBox = new MyWebElement(By.Id("userEmail"));
        private MyWebElement _ageTextBox = new MyWebElement(By.Id("age"));
        private MyWebElement _salaryTextBox = new MyWebElement(By.Id("salary"));
        private MyWebElement _departmentTextBox = new MyWebElement(By.Id("department"));
        private MyWebElement _submitButton = new MyWebElement(By.Id("submit"));

        public void EnterFirstName(string firstName) => _firstNameTextBox.SendKeys(firstName);

        public void EnterLastName(string lastName) => _lastNameTextBox.SendKeys(lastName);

        public void EnterEmail(string email) => _emailTextBox.SendKeys(email);

        public void EnterAge(string age) => _ageTextBox.SendKeys(age);

        public void EnterSalary(string salary) => _salaryTextBox.SendKeys(salary);

        public void EnterDepartment(string department) => _departmentTextBox.SendKeys(department);

        public void ClickSubmitButton() => _submitButton.Click();
    }
}
