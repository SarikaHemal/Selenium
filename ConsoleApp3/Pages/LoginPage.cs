using ConsoleApp3.utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        IWebElement FirstName => Driver.FindElement(By.Id("UserName"));
        IWebElement Password => Driver.FindElement(By.Id("Password"));
        IWebElement Loginbtn => Driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));

        public IWebDriver Driver { get => driver; set => driver = value; }
        public object ExcelReader { get; private set; }

        //Blog about different access specifiers in c#
        internal void LoginSuccess()
        {
            
            // Identfying the username 
            //IWebElement firstName = driver.FindElement(By.Id("UserName"));
            FirstName.SendKeys("hari");

            //Identify password 
            //IWebElement password = driver.FindElement(By.Id("Password"));
            Password.SendKeys("123123");
            // Identify Login and click
            //IWebElement loginbtn = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            Loginbtn.Click();
           
        }
        internal void LoginFailure()
        {
            FirstName.SendKeys("sdfghari");
            Password.SendKeys("12sdfsd3123");
            Loginbtn.Click();
        }
    }
}