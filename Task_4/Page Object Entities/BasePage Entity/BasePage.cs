using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Task_4.Page_Object_Entities
{
    public class BasePage
    {
        protected IWebDriver _driver;
        protected BasePage(IWebDriver _driver)
        {
            this._driver = _driver;
        }
        
        public bool DriverWaitElementIsDisplayed()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            var element = wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed = _driver.FindElement(By.CssSelector(".username__first-letter"));
                    return elementToBeDisplayed.Displayed;
                }

                catch (StaleElementReferenceException)
                {
                    return false;
                }

                catch (NoSuchElementException)
                {
                    return false;
                }
            });

            return true;
        }

        public bool DriverWaitElementIsSelected()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            var element = wait.Until(condition =>
            {
                try
                {
                    var elementToBeSelected = _driver.FindElement(By.XPath("//select[@id = 'multi-select']/option"));
                    return elementToBeSelected.Selected;
                }

                catch (StaleElementReferenceException)
                {
                    return false;
                }

                catch (NoSuchElementException)
                {
                    return false;
                }
            });

            return true;
        }

        public void IsAlertVisible()
        {
            WebDriverWait webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            webDriverWait.Until(ExpectedConditions.AlertIsPresent());
        }

        public bool WaitForUser()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));

            var element = wait.Until(condition =>
            {
                try
                {
                    var elementToBeVisible = _driver.FindElement(By.XPath("//div[@id = 'loading']/img"));
                    return elementToBeVisible.Displayed;
                }

                catch (StaleElementReferenceException)
                {
                    return false;
                }

                catch (NoSuchElementException)
                {
                    return false;
                }
            });

            return true;
        }
    }
}
