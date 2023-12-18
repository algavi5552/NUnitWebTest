using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace NUnitWebTest
{
    [TestFixture]
    class MyTestCase
    {
        [TestCase]
        public void FirtsPageGreetingsTest()
        {
            var firstPageUrl = "https://my.life-pos.ru/auth/login";
            var greetingsSelector = "body > app-root > app-auth > div > div > div.wrapper-container > div.content > div.column.router-portal > app-login > div > div.header > h2";
            
            var webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl(firstPageUrl);

            var greetings = webDriver.FindElement(By.CssSelector(greetingsSelector));

            bool dayCheck = greetings.Text.Contains("День") && UsedFunctions.DayNightCheck().Contains("day");
            bool nightCheck = greetings.Text.Contains("Вечер") && UsedFunctions.DayNightCheck().Contains("night");

            //одна из проверок должна пройти, вторая нет, так как сейчас либо день, либо ночь:
            Assert.AreNotEqual(dayCheck && nightCheck, "Неверное отображение дня и ночи!");

            webDriver.Close();
            webDriver.Dispose();

        }
    }
}
