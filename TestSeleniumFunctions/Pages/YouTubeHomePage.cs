using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSeleniumFunctions.Pages
{
    public class YouTubeHomePage
    {
        IWebDriver driver;

        public YouTubeHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By SearchField = By.XPath("//input[@id='search']");
        public By SearchBtn = By.XPath("//button[@id='search-icon-legacy']");
        public By LibBtn = By.XPath("//*[@class='style-scope ytd-guide-entry-renderer']//*[contains(text(),'Library')]");
        public By ShortBtn = By.XPath("//*[@class='style-scope ytd-guide-entry-renderer']//*[contains(text(),'Short')]");
        public void SearchCSharp(string value)
        {
            IWebElement searchField = driver.FindElement(SearchField);
            searchField.SendKeys(value);

            IWebElement searchBtn = driver.FindElement(SearchBtn);
            searchBtn.Click();
        }
        public void SerachLib()
        {
            IWebElement clickLibBtn = driver.FindElement(LibBtn);
            clickLibBtn.Click();
        }
        public void SearchShort()
        {
            IWebElement clickShortBtn = driver.FindElement(ShortBtn);
            clickShortBtn.Click();

        }

    }
}
