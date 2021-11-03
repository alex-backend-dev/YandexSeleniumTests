using NUnit.Framework;

namespace Task_4.Tests
{
    [TestFixture]
    public class DemoSeleniumEasyPageAlertsTests : BaseTest
    {
        [Test]
        public void DemoSeleniumEasyJavaScriptConfirmBoxCancelClickTest()
        {
            _demoSeleniumEasyPageAlerts?
                .GoToDemoSeleniumEasyPageJavaScripAlertBoxes()
                .AlertClickCancelOnJavaScriptConfirmBox();

            Assert.AreEqual("You pressed Cancel!", _demoSeleniumEasyPageAlerts?.CurrentTextAfterClickingAlert(), "You are not pressed Cancel!");
        }

        [Test]
        public void DemoSeleniumEasyJavaScriptConfirmBoxOkClickTest()
        {
            _demoSeleniumEasyPageAlerts?
                .GoToDemoSeleniumEasyPageJavaScripAlertBoxes()
                .AlertClickOkOnJavaScriptConfirmBox();

            Assert.AreEqual("You pressed OK!", _demoSeleniumEasyPageAlerts?.CurrentTextAfterClickingAlert(), "You are not pressed OK");
        }

        [Test]
        public void DemoSeleniumEasyJavaScriptAlertBoxOkClickTest()
        {
            _demoSeleniumEasyPageAlerts?.GoToDemoSeleniumEasyPageJavaScripAlertBoxes();

            Assert.IsTrue(_demoSeleniumEasyPageAlerts?.AlertClickOkOnJavaScriptAlertBox(), "No click on Alert");              
        }
    }
}
