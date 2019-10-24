using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Selenium
{
    class Program
    {
        private static IWebDriver _driverFf;

        public Program(IWebDriver driverFf)
        {
            _driverFf = driverFf;
        }
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            _driverFf = new FirefoxDriver(@"E:\ASP_CORE\Selenium_Work\Selenium\Selenium\Driver");
            _driverFf.Navigate().GoToUrl("http://cryptopal1408.herokuapp.com/");
            _driverFf.FindElement(By.ClassName("js-scroll-trigger")).Click();
        }
    }
}