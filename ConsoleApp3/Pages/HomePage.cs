﻿using System;
using OpenQA.Selenium;

namespace ConsoleApp3
{
    internal class HomePage
    {
        IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void VerifyHomePage()
        {
            //assignment is to check whether hello hari is displayed on the page 
            IWebElement username = driver.FindElement(By.XPath("//a[contains(.,'Hello hari!')]"));
            Console.WriteLine("username.Text " + username.Text);

            if (username.Text == "Hello hari!")
                Console.WriteLine("verification passed - username disaplyed on home page");
            else
                Console.WriteLine("verification failed - username not disaplyed on home page ");
        }

        internal void ClickAdminstration()
        {

            // assignment 2 admin > time n material > create new 

            //Click adminstration 
            driver.FindElement(By.XPath("//a[contains(.,'Administration')]")).Click();
        }

        internal void ClickTimenMaterial()
        {
            //Click Time n Material 
            driver.FindElement(By.XPath("//a[contains(.,'Time & Materials')]")).Click();
        }
    }
}