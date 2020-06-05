using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.utilities
{
    class Wait
    {
        //generic wait method to determine web element visible
        public static void ElementIsVisible(IWebDriver driver,string value,string key)
        {
            try
            {
                if (key == "id")
                { 
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    var Element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(value)));
                }
                if (key == "XPath")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    var Element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(value)));
                }
                if (key == "ClassName")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    var Element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName(value)));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        
        }
        
    }
}
