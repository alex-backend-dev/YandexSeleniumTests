using OpenQA.Selenium;

namespace Task_4.Page_Object_Entities
{
    public class DemoSeleniumEasyPageAlerts : BasePage
    {
        public DemoSeleniumEasyPageAlerts(IWebDriver _driver) : base(_driver)
        {
        }

        private const string DemoSeleniumEasyPageJavaScriptAlertBoxURL = "http://demo.seleniumeasy.com/javascript-alert-box-demo.html";

        private const string ClickMeButtonJavaScriptConfirmBox = "//button[@onclick = 'myConfirmFunction()']";
        private const string ValidationElementAfterClickingOnButton = "#confirm-demo";
        private const string ClickMeButtonJavaScriptAlertBox = "//button[@onclick = 'myAlertFunction()']";

        public DemoSeleniumEasyPageAlerts GoToDemoSeleniumEasyPageJavaScripAlertBoxes()
        {
            _driver.Navigate().GoToUrl(DemoSeleniumEasyPageJavaScriptAlertBoxURL);

            return this;
        }

        private IWebElement SearchClickMeButtonJavaScriptConfirmBox => _driver.FindElement(By.XPath(ClickMeButtonJavaScriptConfirmBox));

        public bool AlertClickCancelOnJavaScriptConfirmBox()
        {
            SearchClickMeButtonJavaScriptConfirmBox.Click();
            IsAlertVisible();

            IAlert alert = _driver.SwitchTo().Alert();
            string text = alert.Text;
            alert.Dismiss();

            return true;
        }

        public bool AlertClickOkOnJavaScriptConfirmBox()
        {
            SearchClickMeButtonJavaScriptConfirmBox.Click();
            IsAlertVisible();

            IAlert alert = _driver.SwitchTo().Alert();
            string text = alert.Text;
            alert.Accept();

            return true;
        }

        private IWebElement SearchValidationElementAfterClicking => _driver.FindElement(By.CssSelector(ValidationElementAfterClickingOnButton));

        public string CurrentTextAfterClickingAlert()
        {
            return SearchValidationElementAfterClicking.Text;
        }

        private IWebElement SearchClickOnMeButtonJavaScriptAlertBox => _driver.FindElement(By.XPath(ClickMeButtonJavaScriptAlertBox));
        public bool AlertClickOkOnJavaScriptAlertBox()
        {
            SearchClickOnMeButtonJavaScriptAlertBox.Click();
            IsAlertVisible();

            IAlert alert = _driver.SwitchTo().Alert();
            string text = alert.Text;
            alert.Accept();

            return true;
        }
    }
}
