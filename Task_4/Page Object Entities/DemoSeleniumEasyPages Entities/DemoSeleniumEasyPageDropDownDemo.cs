using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace Task_4.Page_Object_Entities
{
    public class DemoSeleniumEasyPageDropDownDemo : BasePage
    {
        private const string DemoSeleniumEasyPageSelectDropDownURL = "http://demo.seleniumeasy.com/basic-select-dropdown-demo.html";

        private By SelectElements = By.CssSelector("#multi-select");
        private IWebElement SearchSelectElem => driver.FindElement(SelectElements);

        public DemoSeleniumEasyPageDropDownDemo(IWebDriver _driver): base(_driver)
        {
        }

        public DemoSeleniumEasyPageDropDownDemo GoToDemoSeleniumEasyPage()
        {
            driver.Navigate().GoToUrl(DemoSeleniumEasyPageSelectDropDownURL);

            return this;
        }

        public bool ClickOnThreeOptions()
        {
            var collection = new List<string>();
            collection.Add("California");
            collection.Add("Florida");
            collection.Add("New Jersey");

            SelectElement selectList = new SelectElement(SearchSelectElem);
            IList<IWebElement> options = selectList.Options;

            foreach(var option in options)
            {
                if(collection.Contains(option.Text)) 
                {
                    option.Click();
                    return true;
                }
            }

            return false;
        }
    }
}
