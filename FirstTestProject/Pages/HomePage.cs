using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace FirstTestProject.Pages
{
    public class HomePage : PageObject
    {
        private IWebElement _field;
        private WebDriverWait _wait;
        private By nav = By.ClassName("nav-input");

        public HomePage(IWebDriver driver) : base(driver)
        {
            _wait = new WebDriverWait(driver,TimeSpan.Parse("10"));
        }

        public void FillField(string iostring)
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _field = _driver.FindElement(nav);
            _field.SendKeys(iostring);
        }

        public SearchPage Submit()
        {
            _field.Submit();
            return new SearchPage(_driver);
        }
    }
}