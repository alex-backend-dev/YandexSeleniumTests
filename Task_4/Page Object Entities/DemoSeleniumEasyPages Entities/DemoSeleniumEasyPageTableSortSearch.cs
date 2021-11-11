using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;

namespace Task_4.Page_Object_Entities.DemoSeleniumEasyPages_Entities
{
    public class DemoSeleniumEasyPageTableSortSearch : BasePage
    {
        private const string DemoSeleniumEasyPageTableSortSearchURL = "http://demo.seleniumeasy.com/table-sort-search-demo.html";

        private By CorrectOptionFromDropDown = By.Name("example_length");
        private By NamesElements = By.XPath("//tr[@role = 'row']/td[1]");
        private By PositionElements = By.XPath("//tr[@role = 'row']/td[2]");
        private By OfficesElements = By.XPath("//tr[@role = 'row']/td[3]");
        private By AgesElements = By.XPath("//tr[@role = 'row']/td[4]");
        private By SalariesElements = By.XPath("//tr[@role = 'row']/td[6]");

        private IWebElement correctOption => driver.FindElement(CorrectOptionFromDropDown);
        private IList<IWebElement> SearchRowNames => driver.FindElements(NamesElements).ToList();
        private IList<IWebElement> SearchRowPositions => driver.FindElements(PositionElements).ToList();
        private IList<IWebElement> SearchRowOffices => driver.FindElements(OfficesElements).ToList();
        private IList<IWebElement> SearchRowAges => driver.FindElements(AgesElements);
        private IList<IWebElement> SearchRowSalaries => driver.FindElements(SalariesElements);

        public DemoSeleniumEasyPageTableSortSearch(IWebDriver _driver) : base(_driver)
        {
        }

        public DemoSeleniumEasyPageTableSortSearch GoToDemoSeleniumEasyPageTableSortSearch()
        {
            driver.Navigate().GoToUrl(DemoSeleniumEasyPageTableSortSearchURL);

            return this;
        }

        public bool SelectCorrectOption(string valueParameter)
        {
            try
            {
                var selectElement = new SelectElement(correctOption);
                selectElement.SelectByValue(valueParameter);
                return true;
            }

            catch(NoSuchElementException)
            {
                return false;
            }
        }

        public List<CustomObject> GetCustomObjects(int x, int y)
        {
            var convertedAges = SearchRowAges.Select(a => int.Parse(a.Text)).ToList();
            var convertedSalaries = SearchRowSalaries.Select(s => int.Parse(s.Text.Trim('$', '/', 'y').Replace(",", ""))).ToList();

            var resultList = new List<CustomObject>();

            for (int i = 0; i < convertedAges.Count; i++)
            {
                if (convertedAges.ElementAt(i) > x && convertedSalaries.ElementAt(i) <= y)
                {
                    resultList.Add(new CustomObject
                    {
                        Name = SearchRowNames.ElementAt(i).Text,
                        Position = SearchRowPositions.ElementAt(i).Text,
                        Office = SearchRowOffices.ElementAt(i).Text
                    });
                }
            }

            return resultList;
        }
    }
}
