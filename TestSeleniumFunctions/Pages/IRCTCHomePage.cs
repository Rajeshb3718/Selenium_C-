using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestSeleniumFunctions.Pages
{
    public class RCTCHomePage
    {
        IWebDriver driver;
        public RCTCHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By From = By.XPath("//input[@class='ng-tns-c57-8 ui-inputtext ui-widget ui-state-default ui-corner-all ui-autocomplete-input ng-star-inserted']");
        public By FromDynamicOptions = By.XPath("//ul[@class='ui-autocomplete-items ui-autocomplete-list ui-widget-content ui-widget ui-corner-all ui-helper-reset ng-tns-c57-8']//li");
        public By To = By.XPath("//input[@class='ng-tns-c57-9 ui-inputtext ui-widget ui-state-default ui-corner-all ui-autocomplete-input ng-star-inserted']");
        public By ToDynamicOptions = By.XPath("//ul[@class='ui-autocomplete-items ui-autocomplete-list ui-widget-content ui-widget ui-corner-all ui-helper-reset ng-tns-c57-9']//li");
        public By Date = By.XPath("//input[@class='ng-tns-c58-10 ui-inputtext ui-widget ui-state-default ui-corner-all ng-star-inserted']");
        public By DateOptions = By.XPath("//td[@class='ng-tns-c58-10 ng-star-inserted']");
        public By CategoryType = By.XPath("//div[@class='ng-tns-c65-12 ui-dropdown ui-widget ui-state-default ui-corner-all']");
        public By CategoryDynamicList = By.XPath("//div[@class='ui-dropdown-items-wrapper ng-tns-c65-12']//ul//li");
        public By Class = By.XPath("//span[@class='ui-dropdown-trigger-icon ui-clickable ng-tns-c65-11 pi pi-chevron-down']");
        public By ClassDynamicOptions = By.XPath("//ul[@class='ui-dropdown-items ui-dropdown-list ui-widget-content ui-widget ui-corner-all ui-helper-reset ng-tns-c65-11']//li");
        public By checkbox = By.XPath("//label[contains(text(),'Person With Disability Concession')]");
        public By Search = By.XPath("//button[contains(text(),'Search')]");         



        public void FillDetailsAndSearch()
        {
            var currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            Actions action = new Actions(driver);

            //Select from

            IWebElement fromField = driver.FindElement(From);
            fromField.Click();

            System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> fromDynamicOptions = driver.FindElements(FromDynamicOptions);

            for(int i=0; i< fromDynamicOptions.Count;i++)
            {
                if (fromDynamicOptions[i].Text== "JAMMU TAWI - JAT")
                {
                    //Thread.Sleep(5000);
                    action.Click(fromDynamicOptions[i]).Build().Perform();
                    //fromDynamicOptions[i].Click();
                    break;
                }
            }

            //Select To

            IWebElement toField = driver.FindElement(To);
            toField.Click();

            System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> toDynamicOptions = driver.FindElements(ToDynamicOptions);

            for(int j=0;j< toDynamicOptions.Count;j++)
            {
                if (toDynamicOptions[j].Text== "JABALPUR - JBP")
                {
                    //Thread.Sleep(5000);
                    action.Click(toDynamicOptions[j]).Build().Perform();
                    //toDynamicOptions[j].Click();
                    //Thread.Sleep(5000);
                    break;
                }
            }

            //Select date

            IWebElement date = driver.FindElement(Date);
            date.Click();
            date.Clear();
            action.SendKeys(currentDate);
            

            //Select category

            IWebElement categoryType = driver.FindElement(CategoryType);
            categoryType.Click();

            System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> categoryDynamicList = driver.FindElements(CategoryDynamicList);
            for (int l = 0; l < categoryDynamicList.Count; l++)
            {
                if (categoryDynamicList[l].Text == "LADIES")
                {
                    //Thread.Sleep(5000);
                    categoryDynamicList[l].Click();
                }
            }

            //select class

            IWebElement sclass = driver.FindElement(Class);
            sclass.Click();

            System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> classDynamicOptions = driver.FindElements(ClassDynamicOptions);
            for(int k=0;k< classDynamicOptions.Count;k++)
            {
                if (classDynamicOptions[k].Text== "Anubhuti Class (EA)")
                {
                    //Thread.Sleep(5000);
                    action.Click(classDynamicOptions[k]).Build().Perform();
                    break;

                }
            }


            IWebElement search = driver.FindElement(Search);
            search.Click();
        } 

        public void  SelectCheckBox()
        {
            bool isChecked = driver.FindElement(checkbox).Selected;

            if(isChecked == false)
            {
                IWebElement checkBox = driver.FindElement(checkbox);
                checkBox.Click();
            }
        }

    }
}

