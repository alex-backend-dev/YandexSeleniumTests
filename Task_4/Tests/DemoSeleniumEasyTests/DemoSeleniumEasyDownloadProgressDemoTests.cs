using NUnit.Framework;

namespace Task_4.Tests.DemoSeleniumEasyTests
{
    [TestFixture]
    public class DemoSeleniumEasyDownloadProgressDemoTests : BaseTest
    {
        [Test]
        public void DownloadProgressDemoTest()
        {
            _demoSeleniumEasyPageDownloadProgressDemo?
                .GoToDemoSeleniumEasyPageDownloadProgressDemo()
                .ClickOnDownloadButton();

            Assert.IsTrue(_demoSeleniumEasyPageDownloadProgressDemo?.RefreshPage(), "Page wasn't refreshed");
        }
    }
}
