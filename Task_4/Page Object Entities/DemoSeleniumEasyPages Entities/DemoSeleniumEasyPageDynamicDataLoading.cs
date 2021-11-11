using OpenQA.Selenium;

namespace Task_4.Page_Object_Entities.DemoSeleniumEasyPages_Entities
{
    public class DemoSeleniumEasyPageDynamicDataLoading : BasePage
    {
        private const string DemoSeleniumEasyPageDynamicDataLoadingURL = "http://demo.seleniumeasy.com/dynamic-data-loading-demo.html";

        private By WaitForImg = By.XPath("//div[@id = 'loading']/img");
        private By GetNewUserButton = By.XPath("//button[@id = 'save']");

        private IWebElement SearchGetNewUserButton => driver.FindElement(GetNewUserButton);

        public DemoSeleniumEasyPageDynamicDataLoading(IWebDriver _driver) : base(_driver)
        {
        }

        public DemoSeleniumEasyPageDynamicDataLoading GoToDemoSeleniumEasyPageDynamicDataLoading()
        {
            driver.Navigate().GoToUrl(DemoSeleniumEasyPageDynamicDataLoadingURL);

            return this;
        }

        public DemoSeleniumEasyPageDynamicDataLoading ClickOnGetNewUserButton()
        {
            SearchGetNewUserButton.Click();
            return this;
        }

        public bool WaitForUser()
        {
            return IsDisplayed(driver, WaitForImg, 5);
        }
    }
}
