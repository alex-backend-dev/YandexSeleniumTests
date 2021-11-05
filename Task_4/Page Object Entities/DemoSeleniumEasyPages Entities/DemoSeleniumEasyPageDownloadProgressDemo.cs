using OpenQA.Selenium;

namespace Task_4.Page_Object_Entities.DemoSeleniumEasyPages_Entities
{
    public class DemoSeleniumEasyPageDownloadProgressDemo : BasePage
    {
        public DemoSeleniumEasyPageDownloadProgressDemo(IWebDriver _driver) : base(_driver)
        {
        }

        private const string DemoSeleniumEasyPageDownloadProgressDemoURL = "http://demo.seleniumeasy.com/bootstrap-download-progress-demo.html";
        public DemoSeleniumEasyPageDownloadProgressDemo GoToDemoSeleniumEasyPageDownloadProgressDemo()
        {
            driver.Navigate().GoToUrl(DemoSeleniumEasyPageDownloadProgressDemoURL);

            return this;
        }

        private By DownloadButton = By.XPath("//button[@id = 'cricle-btn']");

        private IWebElement SearchDownloadButton => driver.FindElement(DownloadButton);

        public DemoSeleniumEasyPageDownloadProgressDemo ClickOnDownloadButton()
        {
            SearchDownloadButton.Click();
            return this;
        }

        private By DownloadButtonPercentage = By.XPath("//div[@class = 'percenttext']");

        private IWebElement SearchDownloadButtonPercentage => driver.FindElement(DownloadButtonPercentage);

        public bool RefreshPage()
        {
            while(true)
            {
                var text = int.Parse(SearchDownloadButtonPercentage.Text.Trim('%'));

                if (text >= 50)
                {
                    driver.Navigate().Refresh();
                    return true;
                }
            }
        } 
    }
}
