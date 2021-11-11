using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Task_4.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void SetupEntities()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void QuitDriver()
        {
            driver?.Quit();
        }
    }
}
