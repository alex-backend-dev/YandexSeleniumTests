using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;

namespace Task_4.Page_Object_Entities.DemoSeleniumEasyPages_Entities
{
    public class DemoSeleniumEasyPageTableSortSearch : BasePage
    {
        public DemoSeleniumEasyPageTableSortSearch(IWebDriver _driver) : base(_driver)
        {
        }

        public const string DemoSeleniumEasyPageTableSortSearchURL = "http://demo.seleniumeasy.com/table-sort-search-demo.html";

        public DemoSeleniumEasyPageTableSortSearch GoToDemoSeleniumEasyPageTableSortSearch()
        {
            _driver.Navigate().GoToUrl(DemoSeleniumEasyPageTableSortSearchURL);

            return this;
        }

        public const string CorrectOptionFromDropDown = "example_length";
        public bool SelectCorrectOption()
        {
            var correctOption = _driver.FindElement(By.Name(CorrectOptionFromDropDown));
            var selectElement = new SelectElement(correctOption);

            selectElement.SelectByValue("10");

            return true; 
        }

        private const string NamesElements = "//tr[@role = 'row']/td[1]";
        private const string PositionElements = "//tr[@role = 'row']/td[2]";
        private const string OfficesElements = "//tr[@role = 'row']/td[3]";
        private const string AgesElements = "//tr[@role = 'row']/td[4]";
        private const string SalariesElements = "//tr[@role = 'row']/td[6]";

        public List<CustomObject> GetCustomObjects(int x, int y)
        {
            var names = _driver.FindElements(By.XPath(NamesElements)).ToList();
            var positions = _driver.FindElements(By.XPath(PositionElements)).ToList();
            var offices = _driver.FindElements(By.XPath(OfficesElements)).ToList();
            var ages = _driver.FindElements(By.XPath(AgesElements));
            var salaries = _driver.FindElements(By.XPath(SalariesElements));

            var convertedAges = ages.Select(a => int.Parse(a.Text)).ToList();
            var convertedSalaries = salaries.Select(s => int.Parse(s.Text.Trim('$', '/', 'y').Replace(",", ""))).ToList();

            var resultList = new List<CustomObject>();

            for (int i = 0; i < convertedAges.Count; i++)
            {
                if (convertedAges.ElementAt(i) > x && convertedSalaries.ElementAt(i) <= y)
                {
                    resultList.Add(new CustomObject
                    {
                        Name = names.ElementAt(i).Text,
                        Position = positions.ElementAt(i).Text,
                        Office = offices.ElementAt(i).Text
                    });
                }
            }

            return resultList;
        }
    }
}
