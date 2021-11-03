using OpenQA.Selenium;

namespace Task_4.Page_Object_Entities.DemoSeleniumEasyPages_Entities
{
    public class DemoSeleniumEasyPageDynamicDataLoading : BasePage
    {
        public DemoSeleniumEasyPageDynamicDataLoading(IWebDriver _driver) : base(_driver)
        {
        }

        private const string DemoSeleniumEasyPageDynamicDataLoadingURL = "http://demo.seleniumeasy.com/dynamic-data-loading-demo.html";

        public DemoSeleniumEasyPageDynamicDataLoading GoToDemoSeleniumEasyPageDynamicDataLoading()
        {
            _driver.Navigate().GoToUrl(DemoSeleniumEasyPageDynamicDataLoadingURL);

            return this;
        }

        private const string GetNewUserButton = "//button[@id = 'save']";

        private IWebElement SearchGetNewUserButton => _driver.FindElement(By.XPath(GetNewUserButton));

        public DemoSeleniumEasyPageDynamicDataLoading ClickOnGetNewUserButton()
        {
            SearchGetNewUserButton.Click();
            return this;
        }
    }
}
