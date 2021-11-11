using NUnit.Framework;
using System.Threading;
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

            Assert.AreEqual("You pressed Cancel!", _demoSeleniumEasyPageAlerts?.SearchValidationElementAfterClicking.Text, "You are not pressed Cancel!");
        }

        [Test]
        public void DemoSeleniumEasyJavaScriptConfirmBoxOkClickTest()
        {
            _demoSeleniumEasyPageAlerts = new DemoSeleniumEasyPageAlerts(driver);

            _demoSeleniumEasyPageAlerts?
                .GoToDemoSeleniumEasyPageJavaScripAlertBoxes()
                .AlertClickOkOnJavaScriptConfirmBox();

            Assert.AreEqual("You pressed OK!", _demoSeleniumEasyPageAlerts?.SearchValidationElementAfterClicking.Text, "You are not pressed OK");
        }

        [Test]
        public void DemoSeleniumEasyJavaScriptAlertBoxOkClickTest()
        {
            _demoSeleniumEasyPageAlerts = new DemoSeleniumEasyPageAlerts(driver);

            _demoSeleniumEasyPageAlerts?
                .GoToDemoSeleniumEasyPageJavaScripAlertBoxes();

            Assert.AreEqual("I am an alert box!", _demoSeleniumEasyPageAlerts?.AlertClickOkOnJavaScriptAlertBox(), "Alert didn't appear");              
        }
    }
}
