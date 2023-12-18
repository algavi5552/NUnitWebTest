using OpenQA.Selenium;

namespace NUnitWebTest.PageObjects
{
    internal class MainMenuPageObject
    {
        private IWebDriver _webDriver;

        private readonly string firstPageUrl = "https://my.life-pos.ru/auth/login";
        private readonly By _greetings = By.CssSelector("body > app-root > app-auth > div > div > div.wrapper-container > div.content > div.column.router-portal > app-login > div > div.header > h2");

        public MainMenuPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainMenuPageObject GoToAuthMenu() 
        {
            _webDriver.Navigate().GoToUrl(firstPageUrl);
            return new MainMenuPageObject(_webDriver);
        }

        public IWebElement FindGreetings()
        {
            return _webDriver.FindElement(_greetings);
        }
    }
}
