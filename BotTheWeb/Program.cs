using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace BotTheWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            var chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl("http://reddit.com");
            //chromeDriver.FindElementByXPath("asdf");


        }
    }
}
