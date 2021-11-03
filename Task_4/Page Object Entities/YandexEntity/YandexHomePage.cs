using OpenQA.Selenium;

namespace Task_4.Page_Object_Entities
{
    public class YandexHomePage : BasePage
    {
        private const string EnterFormXpath = "//div[contains(text(),'Войти')]";
        private const string LoginFormSelector = "#passp-field-login";
        private const string PasswordFormSelector = "#passp-field-passwd";

        private const string YandexByHomePageUrl = "https://yandex.by/";
        private const string YandexHomePageTitle = "Яндекс";

        public YandexHomePage(IWebDriver _driver): base(_driver)
        {
        }

        private IWebElement SearchResultEnter => _driver.FindElement(By.XPath(EnterFormXpath));
        private IWebElement SearchResultLogin => _driver.FindElement(By.CssSelector(LoginFormSelector));
        private IWebElement SearchResultPassword => _driver.FindElement(By.CssSelector(PasswordFormSelector));

        public YandexHomePage GoToYandexHomePage()
        {
            _driver.Navigate().GoToUrl(YandexByHomePageUrl);

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
            DriverWaitElementIsDisplayed();

            return this;
        }

        public bool YandexCorrectLoginByUrl() => _driver.Url.Contains(YandexByHomePageUrl);

        public bool YandexCorrectLoginByTitle() => _driver.Title.Contains(YandexHomePageTitle);
    }
}
