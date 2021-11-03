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
            _driver.Navigate().GoToUrl(DemoSeleniumEasyPageDownloadProgressDemoURL);

            return this;
        }

        private const string DownloadButton = "//button[@id = 'cricle-btn']";

        private IWebElement SearchDownloadButton => _driver.FindElement(By.XPath(DownloadButton));

        public DemoSeleniumEasyPageDownloadProgressDemo ClickOnDownloadButton()
        {
            SearchDownloadButton.Click();
            return this;
        }

        private const string DownloadButtonPercentage = "//div[@class = 'percenttext']";

        private IWebElement SearchDownloadButtonPercentage => _driver.FindElement(By.XPath(DownloadButtonPercentage));

        public bool RefreshPage()
        {
            while(true)
            {
                var text = int.Parse(SearchDownloadButtonPercentage.Text.Trim('%'));

                if (text >= 50)
                {
                    _driver.Navigate().Refresh();
                    return true;
                }
            }
        } 
    }
}
