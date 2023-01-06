using Homework11.Common.WebElements;
using OpenQA.Selenium;

namespace Homework11.PageObjects.DemoQA.Elements
{
    public class WebTablesPage : BaseDemoQAPage
    {
        private MyWebTable _addButton = new MyWebTable(By.Id("addNewRecordButton"));
        private MyWebTable _rowWithElements = new MyWebTable(By.XPath("//*[@class='rt-tr-group'][4]//*[@class='rt-td']"));

        public void ClickAddButton() => _addButton.Click();

        public int GetAmountOfCells() => _rowWithElements.GetAmountOfElements();

        public string GetCellText(int index) => _rowWithElements.GetElementAt(index).Text;
    }
}
