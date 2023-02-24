using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using TestSeleniumFunctions.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestSeleniumFunctions.Pages
{
    public class internetHomePage
    {
        IWebDriver driver;

        public internetHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By JavascriptAlert = By.XPath("//a[contains(text(),'JavaScript Alerts')]");
        public By ClickForJSAlert = By.XPath("//button[contains(text(),'Click for JS Alert')]");
        public By ClickForJSConfirm = By.XPath("//button[contains(text(),'Click for JS Confirm')]");
        public By ClickOnJSPrompt = By.XPath("//button[contains(text(),'Click for JS Prompt')]");
        public By MultipleWindows = By.XPath("//a[contains(text(),'Multiple Windows')]");
        public By ClickHereLink = By.XPath("//a[contains(text(),'Click Here')]");




        public void ClickOnJavascriptAlertAndAccept()
        {
            IWebElement javascriptAlert = driver.FindElement(JavascriptAlert);
            javascriptAlert.Click();
            //WebDriverWait webDriverwait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            //webDriverwait.Until(ExpectedConditions.ElementIsVisible(ClickForJSAlert));
            BaseClass.ExplicitWait(ClickForJSAlert);
            IWebElement clickForJSAlert = driver.FindElement(ClickForJSAlert);
            clickForJSAlert.Click();
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        public string GetMessageAndAcceptAlert()
        {
            string alertMessage = "";
            try
            {
                IWebElement clickForJSAlert = driver.FindElement(ClickForJSAlert);
                WebDriverWait webDriverwait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                clickForJSAlert.Click();

                IAlert alert = driver.SwitchTo().Alert();
                alertMessage = alert.Text;
                alert.Accept();
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Alert is not present");
            }
            return alertMessage;
        }

        public string GetMessageAndRejectAlert()
        {
            string getAlertMessaeToReject = "";
            try
            {
                IWebElement clickForJSConfirm = driver.FindElement(ClickForJSConfirm);
                clickForJSConfirm.Click();
                IAlert alert = driver.SwitchTo().Alert();
                alert = driver.SwitchTo().Alert();
                getAlertMessaeToReject = alert.Text;
                alert.Dismiss();
            }
            catch (Exception)
            {
                Console.WriteLine("Alert is not present");
            }
            return getAlertMessaeToReject;
        }

        public void ClickOnJSPromptAndEnterMessageAndOK()
        {
            
            try
            {
                IWebElement clickOnJSPrompt = driver.FindElement(ClickOnJSPrompt);
                clickOnJSPrompt.Click();

                IAlert alert = driver.SwitchTo().Alert();
                alert.SendKeys("My alert message");
                alert.Accept();

            }
            catch (Exception)
            {

                Console.WriteLine("Alert is not present");
            }
            


        }

        public string ClickMultipleWindows()
        {
            string page2Title = "";
            try
            {
                IWebElement multipleWindows = driver.FindElement(MultipleWindows);
                multipleWindows.Click();

                IWebElement clickHereLink = driver.FindElement(ClickHereLink);
                clickHereLink.Click();

                string tab1 = driver.WindowHandles[0];
                string tab2 = driver.WindowHandles[1];

                page2Title = driver.SwitchTo().Window(tab2).Title;

            }
            catch (Exception)
            {

                throw;
            }

            return page2Title;
        }

    }
}
