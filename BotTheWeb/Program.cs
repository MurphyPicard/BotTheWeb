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

            chromeDriver.Navigate().GoToUrl("https://www.reddit.com");

            //var titles = chromeDriver.FindElementByClassName("may-blank");



            //foreach (var title in titles)
            //{
            //    Console.WriteLine("This is titles: " + title);
            //}
            

            //chromeDriver.FindElementByName("q").Click(); // clicking 
            //chromeDriver.Keyboard.SendKeys("Litecoin");  // typing
            //chromeDriver.Keyboard.SendKeys(Keys.Enter);  // searching


        }
    }
}
