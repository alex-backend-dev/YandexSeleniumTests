using OpenQA.Selenium;

namespace Task_4.Page_Object_Entities
{
    public class YandexHomePage : BasePage
    {
        private By EnterFormXpath = By.XPath("//div[contains(text(),'Войти')]");
        private By LoginFormSelector = By.CssSelector("#passp-field-login");
        private By PasswordFormSelector = By.CssSelector("#passp-field-passwd");
        private By WaitForLoginName = By.CssSelector(".username__first-letter");

        private const string YandexByHomePageUrl = "https://yandex.by/";
        private const string YandexHomePageTitle = "Яндекс";

        public YandexHomePage(IWebDriver _driver): base(_driver)
        {
        }

        private IWebElement SearchResultEnter => driver.FindElement(EnterFormXpath);
        private IWebElement SearchResultLogin => driver.FindElement(LoginFormSelector);
        private IWebElement SearchResultPassword => driver.FindElement(PasswordFormSelector);

        public YandexHomePage GoToYandexHomePage()
        {
            driver.Navigate().GoToUrl(YandexByHomePageUrl);

            return this;
        }

        public YandexHomePage CustomClickOnEnterForm()
        {
            SearchResultEnter.Click();
            return this;
        }

        public YandexHomePage EnterLoginData(string loginData)
        {
            SearchResultLogin.SendKeys(loginData);
            SearchResultLogin.SendKeys(Keys.Enter);

            return this;
        }

        public YandexHomePage EnterPasswordData(string passwordData)
        {
            SearchResultPassword.SendKeys(passwordData);
            SearchResultPassword.SendKeys(Keys.Enter);
            IsDisplayed(driver, WaitForLoginName, 4);

            return this;
        }

        public bool YandexCorrectLoginByUrl() => driver.Url.Contains(YandexByHomePageUrl);

        public bool YandexCorrectLoginByTitle() => driver.Title.Contains(YandexHomePageTitle);
    }
}
