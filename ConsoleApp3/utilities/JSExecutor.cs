using ConsoleApp1;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.utilities
{
    class JSExecutor
    {

        public static object JavaScriptExec(IWebDriver driver, string cmd)
        {
            return ((IJavaScriptExecutor)driver).ExecuteScript(cmd);
        }
        //flase element color in green 50 times
        internal static void flase(IWebElement element, IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            String bgcolor = element.GetCssValue("backgroundcolor");
                
            
            for (int i = 0; i < 50; i++)
            {
                changeColor("rgb(0,200,0)", element, driver);
                changeColor(bgcolor, element, driver);

            }
        }
        public static void changeColor(String color, IWebElement element, IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].style.backgroundColor='" + color + "'", element);
         
        }

     }
}
