using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

            var titles2 = chromeDriver.FindElementByClassName("title").ToString();
            var titles = new List<string> {titles2} ;


            foreach (var title in titles)
            {
                Console.WriteLine("it works");
                Console.WriteLine(title);

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
