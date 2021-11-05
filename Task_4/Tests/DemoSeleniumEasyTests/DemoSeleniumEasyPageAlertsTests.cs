using NUnit.Framework;
using Task_4.Page_Object_Entities;

namespace Task_4.Tests
{
    [TestFixture]
    public class DemoSeleniumEasyPageAlertsTests : BaseTest
    {
        private DemoSeleniumEasyPageAlerts? _demoSeleniumEasyPageAlerts;

        [Test]
        public void DemoSeleniumEasyJavaScriptConfirmBoxCancelClickTest()
        {
            _demoSeleniumEasyPageAlerts = new DemoSeleniumEasyPageAlerts(driver);

            _demoSeleniumEasyPageAlerts?
                .GoToDemoSeleniumEasyPageJavaScripAlertBoxes()
                .AlertClickCancelOnJavaScriptConfirmBox();

            Assert.AreEqual("You pressed Cancel!", _demoSeleniumEasyPageAlerts?.CurrentTextAfterClickingAlert(), "You are not pressed Cancel!");
        }

        [Test]
        public void DemoSeleniumEasyJavaScriptConfirmBoxOkClickTest()
        {
            _demoSeleniumEasyPageAlerts = new DemoSeleniumEasyPageAlerts(driver);

            _demoSeleniumEasyPageAlerts?
                .GoToDemoSeleniumEasyPageJavaScripAlertBoxes()
                .AlertClickOkOnJavaScriptConfirmBox();

            Assert.AreEqual("You pressed OK!", _demoSeleniumEasyPageAlerts?.CurrentTextAfterClickingAlert(), "You are not pressed OK");
        }

        [Test]
        public void DemoSeleniumEasyJavaScriptAlertBoxOkClickTest()
        {
            _demoSeleniumEasyPageAlerts = new DemoSeleniumEasyPageAlerts(driver);

            _demoSeleniumEasyPageAlerts?.GoToDemoSeleniumEasyPageJavaScripAlertBoxes();

            Assert.IsTrue(_demoSeleniumEasyPageAlerts?.AlertClickOkOnJavaScriptAlertBox(), "No click on Alert");              
        }
    }
}
