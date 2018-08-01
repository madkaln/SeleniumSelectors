using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


/* Find element by name
 * Best is to use Name and ID selectors. Speak with dev team and ask them to include them in their code
 * After, Class name and last css and xpath if no other avilable. 
 */

class EntryPoint
{
    static void Main()
    {
        //drives the browser directly using the browser’s built in support for automation.
        //this case we using Chrome Driver 
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://testing.todorvachev.com/selectors/name/");

        //
        IWebElement element = driver.FindElement(By.Name("myName"));
        if (element.Displayed)
        {
            GreenMessage("Pass!!!");
        }
        else
        {
            RedMessage("Something went Wrong!");
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