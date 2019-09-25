using System;
using System.Threading;
using ConsoleApp3.utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ConsoleApp3
{

    internal class TimenMaterialPage
    {
        internal void ClickCreateNew(IWebDriver driver)
        {

            //Click create new button
            driver.FindElement(By.XPath("//a[contains(.,'Create New')]")).Click();
        }

        internal void EnterValidDataandSave(IWebDriver driver)
        {

            //Enter code 
            driver.FindElement(By.Id("Code")).SendKeys("Floods");

            // Enterd description
            driver.FindElement(By.Id("Description")).SendKeys("Be safe");

            //Price per unit
            driver.FindElement(By.XPath("//input[contains(@class,'k-formatted-value k-input')]")).SendKeys("10");

            //click save
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
        }



        internal void ValidateData(IWebDriver driver)
        {
            //ExcelLibHelper.PopulateInCollection("C:\\Users\\sarik\\source\\repos\\Selenium1\\ConsoleApp3\\Testdata\\Test1.xlsx"
            //    , "TMSheet");
            //Wait
            //Thread.Sleep(3000);
            // Wait.ElementIsVisible(driver, "//span[contains(.,'Go to the next page')", "XPath");
            //Verification part
            // assignment 3 is to verify that the time an material object that you created is displayed on the table
            IWebElement code = driver.FindElement(By.Id("Code"));
            Assert.IsTrue(code.Text== "Floods");
            IWebElement disc = driver.FindElement(By.Id("Description"));
            Assert.IsTrue(disc.Text == "Be safe");

        }

      }
}
