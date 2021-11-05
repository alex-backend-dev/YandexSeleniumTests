using OpenQA.Selenium;

namespace Task_4.Page_Object_Entities.DemoSeleniumEasyPages_Entities
{
    public class DemoSeleniumEasyPageDynamicDataLoading : BasePage
    {
        public DemoSeleniumEasyPageDynamicDataLoading(IWebDriver _driver) : base(_driver)
        {
        }

        private const string DemoSeleniumEasyPageDynamicDataLoadingURL = "http://demo.seleniumeasy.com/dynamic-data-loading-demo.html";
        private By WaitForImg = By.XPath("//div[@id = 'loading']/img");
        public DemoSeleniumEasyPageDynamicDataLoading GoToDemoSeleniumEasyPageDynamicDataLoading()
        {
            driver.Navigate().GoToUrl(DemoSeleniumEasyPageDynamicDataLoadingURL);

            return this;
        }

        private By GetNewUserButton = By.XPath("//button[@id = 'save']");

        private IWebElement SearchGetNewUserButton => driver.FindElement(GetNewUserButton);

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
