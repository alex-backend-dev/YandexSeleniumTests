using NUnit.Framework;
using Task_4.Page_Object_Entities.DemoSeleniumEasyPages_Entities;

namespace Task_4.Tests.DemoSeleniumEasyTests
{
    [TestFixture]
    public class DemoSeleniumEasyTableSortSearchTests : BaseTest
    {
        [Test]
        public void DemoSeleniumTableSortTests()
        {
            var _demoSeleniumEasyPageTableSortSearch = new DemoSeleniumEasyPageTableSortSearch(driver);

            _demoSeleniumEasyPageTableSortSearch?
                .GoToDemoSeleniumEasyPageTableSortSearch();

            Assert.IsTrue(_demoSeleniumEasyPageTableSortSearch?.SelectCorrectOption("10"), "Corrected option wasn't selected");
        }
    }
}
