using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Task_4.Page_Object_Entities;
using Task_4.Page_Object_Entities.DemoSeleniumEasyPages_Entities;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Task_4.Tests
{
    public class BaseTest
    {
        protected IWebDriver? _driver;
        protected YandexHomePage? _yandexHomePage;
        protected DemoSeleniumEasyPageDropDownDemo? _demoSeleniumEasyPage;
        protected DemoSeleniumEasyPageAlerts? _demoSeleniumEasyPageAlerts;
        protected DemoSeleniumEasyPageDynamicDataLoading? _demoSeleniumEasyPageDynamicDataLoading;
        protected DemoSeleniumEasyPageDownloadProgressDemo? _demoSeleniumEasyPageDownloadProgressDemo;
        protected DemoSeleniumEasyPageTableSortSearch? _demoSeleniumEasyPageTableSortSearch;

        [SetUp]
        public void SetupEntities()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
            _driver.Manage().Window.Maximize();
            _yandexHomePage = new YandexHomePage(_driver);
            _demoSeleniumEasyPage = new DemoSeleniumEasyPageDropDownDemo(_driver);
            _demoSeleniumEasyPageAlerts = new DemoSeleniumEasyPageAlerts(_driver);
            _demoSeleniumEasyPageDynamicDataLoading = new DemoSeleniumEasyPageDynamicDataLoading(_driver);
            _demoSeleniumEasyPageDownloadProgressDemo = new DemoSeleniumEasyPageDownloadProgressDemo(_driver);
            _demoSeleniumEasyPageTableSortSearch = new DemoSeleniumEasyPageTableSortSearch(_driver);
        }

        [TearDown]
        public void QuitDriver()
        {
            _driver?.Quit();
        }
    }
}
