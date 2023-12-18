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

            bool dayCheck =     greetings.Contains("День")  && UsedFunctions.DayNightCheck().Contains("day");
            bool nightCheck =   greetings.Contains("Вечер") && UsedFunctions.DayNightCheck().Contains("night");

            //одна из проверок должна пройти, вторая нет, так как сейчас либо день, либо ночь:
            Assert.AreNotEqual(dayCheck && nightCheck, "Неверное отображение дня и ночи!");

        }

        [TearDown]
        public void TearDown() 
        {  
            _webDriver?.Quit(); 
        }
    }
}
