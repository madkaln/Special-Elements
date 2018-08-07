using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class Program
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement radioButton;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/radio-button-test/";


        string[] option = { "1", "3", "5" };

        driver.Navigate().GoToUrl(url);

        /* This allows the radiio buttons to be looped through a for loop and select appropriate from the array list above
         * as a kind reminder, array starts from index 0.
         * Element found with CssSelector and then option 0,1,2 is inputed into the selector. 
         */

        for (int i = 0; i < option.Length; i++)
        {
            radioButton = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=\"radio\"]:nth-child(" + option[2] + ")"));

            if (!radioButton.Selected)
            {
                radioButton.Click();
            }

            Thread.Sleep(3000);

        }

        /* Creating array to hold all the radio button options
        * Using for loop to loop through  
        *  Take the first element in the loop, then check if element is checked, then print the message and then take the second and again check 
        *  Checks all the options within the array
        *
           string url = "http://testing.todvachev.com/special-elements/radio-button-test/";


              string[] option = { "1", "3", "5" };

              driver.Navigate().GoToUrl(url);

                 for (int i = 0; i < option.Length; i++)
                 {
                     radioButton = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=\"radio\"]:nth-child(" + option[i] + ")"));

                     if (radioButton.GetAttribute("checked") == "true")
                     {
                         Console.WriteLine("The " + (i+1) + "radio button is checked");
                         Console.ReadLine();
                     }

                     else
                     {
                         Console.WriteLine("This is one of the unchecked radio buttons");
                         Console.ReadLine();
                     }
                 }
                 */
    }

}

