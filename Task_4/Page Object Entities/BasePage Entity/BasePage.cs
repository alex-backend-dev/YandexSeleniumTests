using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Task_4.Page_Object_Entities
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        public bool IsDisplayed(IWebDriver driver, By by, int timeoutInSeconds)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));

            var element = wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed = driver.FindElement(by);
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

        public bool IsSelected(IWebDriver driver, By by, int timeoutInSeconds)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            var element = wait.Until(condition =>
            {
                try
                {
                    var elementToBeSelected = driver.FindElement(by);
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

        public bool IsAlertVisible(IWebDriver driver, int timeoutInSeconds)
        {
            try
            {
                if (timeoutInSeconds > 0)
                {
                    WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                    webDriverWait.Until(ExpectedConditions.AlertIsPresent());
                }
            }

            catch (StaleElementReferenceException)
            {
                return false;
            }

            catch (NoSuchElementException)
            {
                return false;
            }

            return true;
        }    
    }
}

