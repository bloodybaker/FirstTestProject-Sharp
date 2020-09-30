using System.Threading;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace FirstTestProject.Pages
{
    public class PageObject
    {
        protected IWebDriver _driver;

        public PageObject(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver,this);
        }

        protected bool IsElementExists(By by)
        {
            try
            {
                _driver.FindElement(by);
                return true;
            }
            catch (StaleElementReferenceException)
            {
                Thread.Sleep(500);
                return false;
            }
        }
    }
}