using NUnit.Framework;
using Task_4.Page_Object_Entities.DemoSeleniumEasyPages_Entities;

namespace Task_4.Tests.DemoSeleniumEasyTests
{
    [TestFixture]
    public class DemoSeleniumEasyPageDynamicDataLoadingTests : BaseTest
    {
        [Test]
        public void DemoSeleniumEasyPageDynamicDataLoadingTest()
        {
            var _demoSeleniumEasyPageDynamicDataLoading = new DemoSeleniumEasyPageDynamicDataLoading(driver);

            _demoSeleniumEasyPageDynamicDataLoading?
                .GoToDemoSeleniumEasyPageDynamicDataLoading()
                .ClickOnGetNewUserButton();

            Assert.IsTrue(_demoSeleniumEasyPageDynamicDataLoading?.WaitForUser(), "We didn't wait for the user");
        }
    }
}
