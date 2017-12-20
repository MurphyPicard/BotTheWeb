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

            var titles = chromeDriver.FindElementByClassName("title");

            foreach (var title in titles)
            {
                
                    Console.WriteLine(title.Text);
                
            }

            //var titles = chromeDriver.FindElementByClassName("coin-content-symbol");

            //for(var i = 0; i < titles.)

            // Works on coingecko.com
            //chromeDriver.FindElementById("select2-coins_to_search-container").Click();
            //chromeDriver.Keyboard.SendKeys("bch");
            //chromeDriver.Keyboard.SendKeys(Keys.Enter);
            // obs recording software



        }
    }
}
