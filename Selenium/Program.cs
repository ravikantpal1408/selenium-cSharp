using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            string url = "http://testing.todorvachev.com/selectors/id/";
            string ID = "testImage";
            string CLASSNAME = "testClass1sdfsdf";
            
            
            _driverFf = new ChromeDriver(@"E:\ASP_CORE\Selenium_Work\Selenium\Selenium\Driver");
            _driverFf.Navigate().GoToUrl(url);
            
            IWebElement element = _driverFf.FindElement(By.Id(ID));

            try
            {
                if (element.Displayed)
                {
                    GreenMessage("Yes, I can see it");
                    Console.WriteLine(element.Text);
                    _driverFf.Quit();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Exception : "+ ex.ToString());
                RedMessage("Nope, Its not there");
                _driverFf.Quit();
            }
           
            _driverFf.Quit();

        }

        static void RedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
        }
        
        static void GreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(message);
        }
    }
}