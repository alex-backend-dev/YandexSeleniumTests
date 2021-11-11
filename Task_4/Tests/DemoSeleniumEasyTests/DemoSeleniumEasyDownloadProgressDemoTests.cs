using NUnit.Framework;
using Task_4.Page_Object_Entities.DemoSeleniumEasyPages_Entities;

namespace Task_4.Tests.DemoSeleniumEasyTests
{
    [TestFixture]
    public class DemoSeleniumEasyDownloadProgressDemoTests : BaseTest
    {
        [Test]
        public void DownloadProgressDemoTest()
        {
            var _demoSeleniumEasyPageDownloadProgressDemo = new DemoSeleniumEasyPageDownloadProgressDemo(driver);

            _demoSeleniumEasyPageDownloadProgressDemo?
                .GoToDemoSeleniumEasyPageDownloadProgressDemo()
                .ClickOnDownloadButton();

            Assert.IsTrue(_demoSeleniumEasyPageDownloadProgressDemo?.RefreshPage(), "Page wasn't refreshed");
        }
    }
}
