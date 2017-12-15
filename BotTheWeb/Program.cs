using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BotTheWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            var chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl("https://www.google.com");

            chromeDriver.FindElementById("lst-ib").Click(); // clicking 
            chromeDriver.Keyboard.SendKeys("Litecoin");     // typing
            chromeDriver.Keyboard.SendKeys(Keys.Enter);     // searching

            /* 
            xpath: //*[@id="thing_t3_77ofz0"]/div[2]/div/p[1]/a
            */

        }
    }
}
