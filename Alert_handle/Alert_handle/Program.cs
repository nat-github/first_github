using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace Alert_handle
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver;
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.javascriptsandmore.com/javascript-alert-box.html");
            IAlert alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            alert.Accept();
            IAlert next_alert = driver.SwitchTo().Alert();
            Console.WriteLine(next_alert.Text);
            next_alert.Accept();
            driver.Quit();
            Console.Read();
        }
    }
}
