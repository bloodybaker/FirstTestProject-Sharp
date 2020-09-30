using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace FirstTestProject.Pages
{
    public class SearchPage : PageObject
    {
        private By _elements = By.XPath("//div[contains(@class,'s-main-slot')]//div[@data-index]//a[@class='a-link-normal a-text-normal']");
        private By _category = By.XPath("//span[text()='Books']");
        
        private ReadOnlyCollection<IWebElement> _names;
        private List<string> _urls = new List<string>();
        
        public SearchPage(IWebDriver driver) : base(driver) {}

        public void SetCategory()
        {
            while (IsElementExists(_category))
            {
                _driver.FindElement(_category).Click();
            }
        }

        public void GetElements()
        {
            _names = _driver.FindElements(_elements);
            foreach (var element in _names)
            {
                _urls.Add(element.GetAttribute("href"));
            }
        }
        
        public List<string> GetUrls()
        {
            return _urls;
        }

        public PageScraper Confirm()
        {
            //SetCategory();
            GetElements();
            return new PageScraper(_driver);
        }
    }
}