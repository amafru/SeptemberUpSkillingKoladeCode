using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Threading;
using System.Configuration;
using System.Diagnostics;
using OpenQA.Selenium.Support.UI;

namespace CourseManagementSystemAutomation.Hooks
{
    public class Context
    {
        public IWebDriver driver;
        //string baseURL = "http://localhost/CourseManagementSystem/";
        string baseURL = ConfigurationManager.AppSettings["URL"];
        string browser = ConfigurationManager.AppSettings["browser"];

        //public void SetUp()
        //{
        //    driver = new ChromeDriver();  //call a Chrome browser
        //    driver.Navigate().GoToUrl(baseURL);  //it writes to the browser application under test URL
        //    driver.Manage().Window.Maximize();  //maximise the chrome browser window
        //    Thread.Sleep(2000);  //wait for 2 seconds
        //}
        
        public void SetUp()
        {
            //Code to clear all the unkilled browser's driver
            var chromeDriverProcesses = Process.GetProcessesByName("chromedriver");
            foreach (var chromeDriverProcess in chromeDriverProcesses)
            {
                try
                {
                    chromeDriverProcess.Kill();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    break;
                case "InternetExplorer":
                    driver = new InternetExplorerDriver();
                    break;                               
            }
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        public void ShutDown()  //This is to close the browser regardless the outcome of the test
        {
            driver.Quit();
            driver.Dispose();    
        }
    }

    public static class WebDriverExtensions
    {
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }
    }
}
