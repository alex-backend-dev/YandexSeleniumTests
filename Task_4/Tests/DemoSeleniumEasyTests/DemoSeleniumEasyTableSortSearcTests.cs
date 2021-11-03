using NUnit.Framework;

namespace Task_4.Tests.DemoSeleniumEasyTests
{
    [TestFixture]
    public class DemoSeleniumEasyTableSortSearcTests : BaseTest
    {
        [Test]
        public void DemoSeleniumTableSortTests()
        {
            _demoSeleniumEasyPageTableSortSearch?
                .GoToDemoSeleniumEasyPageTableSortSearch();

            Assert.IsTrue(_demoSeleniumEasyPageTableSortSearch?.SelectCorrectOption(), "Corrected option wasn't selected");
        }
    }
}
