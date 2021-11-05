using NUnit.Framework;
using Task_4.Page_Object_Entities;

namespace Task_4.Tests
{
    [TestFixture]
    public class DemoSeleniumEasyDropDownTests : BaseTest
    {
        [Test]
        public void DemoSeleniumEasyDropDownTest()
        {
            var _demoSeleniumEasyPage = new DemoSeleniumEasyPageDropDownDemo(driver);

            _demoSeleniumEasyPage?.GoToDemoSeleniumEasyPage();

            Assert.IsTrue(_demoSeleniumEasyPage?.ClickOnThreeOptions(), "No click on three options");
        }
    }
}
