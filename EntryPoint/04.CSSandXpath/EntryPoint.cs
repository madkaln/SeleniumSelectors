using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string url = "http://testing.todvachev.com/selectors/css-path/";
            
            /* To get ccsPath- go to inspect element, copy-> select selector.
            * Tells selenium what rules to follow HTML code. 
            * Creates a crumbtrailer. 
            */
            string cssPath = "#post-108 > div > figure > img";
            /* Go to inspect element, copy -> Xpath
             * Remove spaces and remove ""
             */
            string xPath = "//*[@id=\"post-108\"]/div/figure/img";

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            /* In general use cssPath, IE works faster and often have difficulties to find the element if its Xpath
             * if out for performance, they are faster
             */
            IWebElement cssPathElement = driver.FindElement(By.CssSelector(cssPath));
            IWebElement xpathElement = driver.FindElement(By.XPath(xPath));

            if (cssPathElement.Displayed && xpathElement.Displayed)
            {
            GreenMessage("Well done, its there");
            
            }
            else
            {
            RedMessage("can't see it, something gone wrong");
            }

        driver.Quit();
            Thread.Sleep(4000);
        }

        private static void RedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        private static void GreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
