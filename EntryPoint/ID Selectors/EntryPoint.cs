using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

/* 
 * Code allow us find elements by ID.
 */

class EntryPoint
{
    static void Main(string[] args)
    {
        string url = "http://testing.todovachev.com/selectors/id";
        string ID = "testImage";
        //IWebDriver allow us to get to the website and find element by ID
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);
        IWebElement element = driver.FindElement(By.Id(ID));

        if (element.Displayed)
        {
            GreenMessage("YES I can see it");
        }
        else
        {
            RedMessage("Oh no, something has gone wrong");
        }

        driver.Quit();
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

