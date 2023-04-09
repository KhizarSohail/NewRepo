using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM
{
    internal class CorePage
    {
        public static IWebDriver driver;

        public static void SeleniumDriver()
        {
            driver = new ChromeDriver();
        }
        public static void Write(By by , string text)
        {
            driver.FindElement(by).SendKeys(text);
        }
        public static void Click(By by)
        {
            driver.FindElement(by).Click();
        }
        public static void Clear(By by)
        {
            driver.FindElement(by).Clear();
        }
        public static void URL(string url) 
        {
            driver.Url = (url);
        }
        public static void Close()
        {
            driver.Close();
        }
        public static void JS_Exe(string script, By by)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript(script, by);
        }
        public static void ChromeWindow(string type)
        {
            if (type == "headless")
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument(type);
            }
            else if (type == "incognito")
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument(type);
            }
            
        }
        public static void DropDown(string type, By by, int index, string value)
        {
            if (type == "index") 
            {
                SelectElement dropDown = new SelectElement(driver.FindElement(by));
                dropDown.SelectByIndex(index);
            }
            else if (type == "value")
            {
                SelectElement dropDown = new SelectElement(driver.FindElement(by));
                dropDown.SelectByValue(value);
            }
            else if (type == "text")
            {
                SelectElement dropDown = new SelectElement(driver.FindElement(by));
                dropDown.SelectByValue(value);
            }
            
        }
        public static void Navigate(string nav_url)
        {
            driver.Navigate().GoToUrl(nav_url);
        }
    }
}
