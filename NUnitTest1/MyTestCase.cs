using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnitWebTest.PageObjects;

namespace NUnitWebTest
{
    [TestFixture]
    class MyTestCase
    {
        private IWebDriver? _webDriver;

        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl("https://my.life-pos.ru");
        }

        [TestCase]
        public void FirtsPageGreetingsTest()
        {
            var mainMenu = new MainMenuPageObject(_webDriver);
            var greetings = mainMenu.GoToAuthMenu().FindGreetings().Text;

            bool morningCheck = UsedFunctions.TimeCheck(greetings, "Доброе утро", "morning");
            bool dayCheck =     UsedFunctions.TimeCheck(greetings, "Добрый день", "day");
            bool eveningCheck = UsedFunctions.TimeCheck(greetings, "Добрый вечер","evening");
            bool nightCheck =   UsedFunctions.TimeCheck(greetings, "Доброй ночи", "night");

            //одна из проверок должна пройти:
            Assert.IsTrue(morningCheck || dayCheck || eveningCheck || nightCheck);

        }

        [TearDown]
        public void TearDown() 
        {  
            _webDriver?.Quit(); 
        }
    }
}
