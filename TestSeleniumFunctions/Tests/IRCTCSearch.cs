using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumFunctions.Common;
using TestSeleniumFunctions.Pages;

namespace TestSeleniumFunctions.Tests
{
    public class IRCTCSearch : BaseClass
    {
        [Test]
        public void IRCTCSearchTest()
        {
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://www.irctc.co.in/nget/train-search");
            //driver.Manage().Window.Maximize();
            IRCTC();
            RCTCHomePage iRCTCHomePage = new RCTCHomePage(driver);
            iRCTCHomePage.FillDetailsAndSearch();
            driver.Dispose();

        }
    }
}
