using NUnit.Framework;
using Task_4.Page_Object_Entities;
using Task_4.Tests;

namespace Task_4
{
    [TestFixture]
    public class YandexTests : BaseTest
    {
        [Test]
        [TestCase(TestConstants.LoginForFirstTest, TestConstants.PasswordForFirstTest)]
        [TestCase(TestConstants.LoginForSecondTest, TestConstants.PasswordForSecondTest)]
        public void YandexLoginsTest(string loginData, string passwordData)
        {
            var _yandexHomePage = new YandexHomePage(driver);

            _yandexHomePage?
                .GoToYandexHomePage()
                .CustomClickOnEnterForm()
                .EnterLoginData(loginData)
                .EnterPasswordData(passwordData);

            //Thread.Sleep(4000);
            /*
             * Thread.Sleep() causes the current thread to suspend execution for a specified period. 
             * This is an efficient means of making processor time available to the other threads of 
             * an application or other applications that might be running on a computer system.
             */

            Assert.IsTrue(_yandexHomePage?.YandexCorrectLoginByUrl(), $"URL is incorrect - test received {driver?.Url}");
            Assert.IsTrue(_yandexHomePage?.YandexCorrectLoginByTitle(), $"Title is incorrect - test received {driver?.Title}");
        }
    }
}