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

    static IWebDriver driver = new ChromeDriver();
    static IWebElement checkBox;

    static void Main()
    {
        string option = "1";
        string url = "http://testing.todvachev.com/special-elements/check-button-test-3/";

        
        driver.Navigate().GoToUrl(url);

        IWebElement oCheckBox = driver.FindElement(By.Name("vehicle"));

        if(!oCheckBox.Selected)
        {
            oCheckBox.Click();
        }

       // checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkBox\"]:nth-child(" + option + ") "));
        //call the method to check the checkbox.
       // checkBox.Click();

        Thread.Sleep(3000);


        /*This attribute looking at the checkbox value 
         * Prints if its checked or not and retrieves the value 
         * 
        if (checkBox.GetAttribute("checked") == "true")
        {
            Console.WriteLine(checkBox.GetAttribute("value"));
            Console.WriteLine("The checkbox is checked");
            Console.ReadLine();
        }

        else
        {
            Console.WriteLine(checkBox.GetAttribute("value"));
            Console.WriteLine("The checkbox is not checked");
            Console.ReadLine();
        }
        */


        driver.Quit();
        
    }

}

