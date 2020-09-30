using System;
using System.Threading;
using FirstTestProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace FirstTestProject
{
    public class Tests
    {
        private By title = By.Name("q");
        private IWebDriver driver;
        private Actions builder;
        
        [SetUp]
        public void Setup()
        {
        }
 
        [Test]
        public void BookTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--window-position=0,0");
            options.AddArguments("--window-size=1920,1080");
            driver = new ChromeDriver(options);
            builder = new Actions(driver);
            driver.Navigate().GoToUrl("https://amazon.com");
            HomePage initPage = new HomePage(driver);
            initPage.FillField("Java");
            initPage.Submit();
            SearchPage search = initPage.Submit();
            search.Confirm();
            driver.Quit();
            //Assert.Pass();
        }
    }
}