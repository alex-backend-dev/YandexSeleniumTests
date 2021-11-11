using OpenQA.Selenium;

namespace Task_4.Page_Object_Entities
{
    public class DemoSeleniumEasyPageAlerts : BasePage
    {
        private const string DemoSeleniumEasyPageJavaScriptAlertBoxURL = "http://demo.seleniumeasy.com/javascript-alert-box-demo.html";

        private By ClickMeButtonJavaScriptConfirmBox = By.XPath("//button[@onclick = 'myConfirmFunction()']");
        private By ValidationElementAfterClickingOnButton = By.CssSelector("#confirm-demo");
        private By ClickMeButtonJavaScriptAlertBox = By.XPath("//button[@onclick = 'myAlertFunction()']");

        private IWebElement SearchClickMeButtonJavaScriptConfirmBox => driver.FindElement(ClickMeButtonJavaScriptConfirmBox);
        public  IWebElement SearchValidationElementAfterClicking => driver.FindElement(ValidationElementAfterClickingOnButton);
        private IWebElement SearchClickOnMeButtonJavaScriptAlertBox => driver.FindElement(ClickMeButtonJavaScriptAlertBox);

        public DemoSeleniumEasyPageAlerts(IWebDriver _driver) : base(_driver)
        {
        }

        public DemoSeleniumEasyPageAlerts GoToDemoSeleniumEasyPageJavaScripAlertBoxes()
        {
            driver.Navigate().GoToUrl(DemoSeleniumEasyPageJavaScriptAlertBoxURL);

            return this;
        }

        public void AlertClickCancelOnJavaScriptConfirmBox()
        {
            SearchClickMeButtonJavaScriptConfirmBox.Click();
            IsAlertVisible(driver, 5);

            IAlert alert = driver.SwitchTo().Alert();
            alert.Dismiss();
        }

        public void AlertClickOkOnJavaScriptConfirmBox()
        {
            SearchClickMeButtonJavaScriptConfirmBox.Click();
            IsAlertVisible(driver, 5);

            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        public string AlertClickOkOnJavaScriptAlertBox()
        {
            SearchClickOnMeButtonJavaScriptAlertBox.Click();
            IsAlertVisible(driver, 4);

            IAlert alert = driver.SwitchTo().Alert();

            string alertText = alert.Text;
            alert.Accept();

            return alertText;
        }
    }
}
