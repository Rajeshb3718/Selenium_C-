using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace TestSeleniumFunctions.Common
{
    public class BaseClass
    {
        public static IWebDriver driver;
        public static JObject jObject = new JObject();



        static BaseClass()
        {
            using (StreamReader file = File.OpenText("C:\\Rajesh\\Testing_Automation_Live_Projects\\TestSeleniumFunctions\\TestSeleniumFunctions\\Data_Source\\DataFile.json"))
            //using (StreamReader file = File.OpenText("~\\DataSource\\DataFile.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                jObject = (JObject)JToken.ReadFrom(reader);
            }
        }

        public void IRCTC()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(jObject["IRCTCUrl"].ToString());
            driver.Manage().Window.Maximize();
        }

        public void YouTube()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(jObject["YouTubeUrl"].ToString());
            driver.Manage().Window.Maximize();
        }

        public void HeroKuApp()
        {

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(jObject["AlertTestUrl"].ToString());
            driver.Manage().Window.Maximize();
        }

        public static void ExplicitWait(By webElement)
        {
            // Explicit wait stops the browser until the condition is met and will proceed with next
            //Steps of execution
            driver = new ChromeDriver();
            WebDriverWait explicitWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            explicitWait.Until(ExpectedConditions.ElementIsVisible(webElement));
        }

        public static void ImplicitWait()
        {

            //Implicit wait is usually not recommended, If we declare implicit wait once it will be 
            //applicable for entire driver session and will cause performance issue.
            //Here in below code, if the element is not visible after 10 seconds, it will throw timeout exception.
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void CleanUp()
        {
            //Driver.close() will only close the current window without termination and if there are
            //multiple windows open, driver.close() will only close current window.
            driver.Close();

            //driver.quit() terminated all the open instances and cleans up the memory.
            driver.Quit();

            //driver.dispose() internally calls the driver.quit() to terminate all instances and disposes them.
            driver.Dispose();
        }
    }
}
