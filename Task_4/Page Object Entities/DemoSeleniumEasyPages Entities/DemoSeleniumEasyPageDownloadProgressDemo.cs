using OpenQA.Selenium;

namespace Task_4.Page_Object_Entities.DemoSeleniumEasyPages_Entities
{
    public class DemoSeleniumEasyPageDownloadProgressDemo : BasePage
    {
        private const string DemoSeleniumEasyPageDownloadProgressDemoURL = "http://demo.seleniumeasy.com/bootstrap-download-progress-demo.html";

        private By DownloadButton = By.XPath("//button[@id = 'cricle-btn']");
        private By DownloadButtonPercentage = By.XPath("//div[@class = 'percenttext']");

        private IWebElement SearchDownloadButton => driver.FindElement(DownloadButton);
        private IWebElement SearchDownloadButtonPercentage => driver.FindElement(DownloadButtonPercentage);

        public DemoSeleniumEasyPageDownloadProgressDemo(IWebDriver _driver) : base(_driver)
        {
        }

        public DemoSeleniumEasyPageDownloadProgressDemo GoToDemoSeleniumEasyPageDownloadProgressDemo()
        {
            driver.Navigate().GoToUrl(DemoSeleniumEasyPageDownloadProgressDemoURL);

            return this;
        }

        public DemoSeleniumEasyPageDownloadProgressDemo ClickOnDownloadButton()
        {
            SearchDownloadButton.Click();

            return this;
        }

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
