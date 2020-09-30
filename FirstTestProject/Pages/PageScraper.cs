using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FirstTestProject.Pages
{
    public class PageScraper : PageObject
    {
        private List<string> _urls;
        private List<Book> _bookList = new List<Book>();
        private ReadOnlyCollection<IWebElement> _listOfAutors;
        private WebDriverWait _wait;
        private StringBuilder _author = new StringBuilder();
        public PageScraper(IWebDriver driver) : base(driver) {}

        private void RemoveExtraLinks()
        {
            for (int i = 0; i < _urls.Count; i++) {
                if(_urls[i].Contains("true")){
                    _urls.Remove(_urls[i]);
                }
            }
            ScrapNames();
        }

        private void ScrapNames()
        {
            foreach (var s in _urls)
            {
        //        IsExists(s);
            }
        }
        
    }
}