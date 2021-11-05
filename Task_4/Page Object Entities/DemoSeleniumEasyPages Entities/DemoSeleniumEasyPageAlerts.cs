using OpenQA.Selenium;

namespace Task_4.Page_Object_Entities
{
    public class DemoSeleniumEasyPageAlerts : BasePage
    {
        public DemoSeleniumEasyPageAlerts(IWebDriver _driver) : base(_driver)
        {
        }

        private const string DemoSeleniumEasyPageJavaScriptAlertBoxURL = "http://demo.seleniumeasy.com/javascript-alert-box-demo.html";

        private By ClickMeButtonJavaScriptConfirmBox = By.XPath("//button[@onclick = 'myConfirmFunction()']");
        private By ValidationElementAfterClickingOnButton = By.CssSelector("#confirm-demo");
        private By ClickMeButtonJavaScriptAlertBox = By.XPath("//button[@onclick = 'myAlertFunction()']");

        public DemoSeleniumEasyPageAlerts GoToDemoSeleniumEasyPageJavaScripAlertBoxes()
        {
            driver.Navigate().GoToUrl(DemoSeleniumEasyPageJavaScriptAlertBoxURL);

            return this;
        }

        private IWebElement SearchClickMeButtonJavaScriptConfirmBox => driver.FindElement(ClickMeButtonJavaScriptConfirmBox);

        public bool AlertClickCancelOnJavaScriptConfirmBox()
        {
            SearchClickMeButtonJavaScriptConfirmBox.Click();
            IsAlertVisible(driver, 4);

            IAlert alert = driver.SwitchTo().Alert();
            string text = alert.Text;
            alert.Dismiss();

            return true;
        }

        public bool AlertClickOkOnJavaScriptConfirmBox()
        {
            SearchClickMeButtonJavaScriptConfirmBox.Click();
            IsAlertVisible(driver, 4);

            IAlert alert = driver.SwitchTo().Alert();
            string text = alert.Text;
            alert.Accept();

            return true;
        }

        private IWebElement SearchValidationElementAfterClicking => driver.FindElement(ValidationElementAfterClickingOnButton);

        public string CurrentTextAfterClickingAlert()
        {
            return SearchValidationElementAfterClicking.Text;
        }

        private IWebElement SearchClickOnMeButtonJavaScriptAlertBox => driver.FindElement(ClickMeButtonJavaScriptAlertBox);
        public bool AlertClickOkOnJavaScriptAlertBox()
        {
            SearchClickOnMeButtonJavaScriptAlertBox.Click();
            IsAlertVisible(driver, 4);

            IAlert alert = driver.SwitchTo().Alert();
            string text = alert.Text;
            alert.Accept();

            return true;
        }
    }
}
