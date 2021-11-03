using NUnit.Framework;
using System.Threading;

namespace Task_4.Tests
{
    [TestFixture]
    public class DemoSeleniumEasyDropDownTests : BaseTest
    {
        [Test]
        public void DemoSeleniumEasyDropDownTest()
        {
            _demoSeleniumEasyPage?.GoToDemoSeleniumEasyPage();

            Assert.IsTrue(_demoSeleniumEasyPage?.ClickOnThreeOptions(), "No click on three options");
        }
    }
}
