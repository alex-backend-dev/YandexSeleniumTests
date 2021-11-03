using NUnit.Framework;

namespace Task_4.Tests.DemoSeleniumEasyTests
{
    [TestFixture]
    public class DemoSeleniumEasyPageDynamicDataLoadingTests : BaseTest
    {
        [Test]
        public void DemoSeleniumEasyPageDynamicDataLoadingTest()
        {
            _demoSeleniumEasyPageDynamicDataLoading?
                .GoToDemoSeleniumEasyPageDynamicDataLoading()
                .ClickOnGetNewUserButton();

            Assert.IsTrue(_demoSeleniumEasyPageDynamicDataLoading?.WaitForUser(), "We are not waited for a user");
        }
    }
}
