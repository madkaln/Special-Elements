using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

   class Entry
    {

    static IWebDriver driver = new ChromeDriver();
    static IWebElement dropDownMenu;
    static IWebElement elementFromTheDropDownMenu;

        static void Main()
        {
        string url = "http://testing.todvachev.com/special-elements/drop-down-menu-test/";
        string dropDownMenuElements = " #post-6 > div > p:nth-child(6) > select > option:nth-child(3)";

        driver.Navigate().GoToUrl(url);

        dropDownMenu = driver.FindElement(By.Name("DropDownTest"));

        // Simple test of getting the first attribute on the dropdwon menu.
        Console.WriteLine(dropDownMenu.GetAttribute("value"));
        Console.ReadLine();

        //simple select of third value in te menue and click on it.

        elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));
        elementFromTheDropDownMenu.Click();
        Console.WriteLine(dropDownMenu.GetAttribute("value"));
        Console.ReadLine();
 
     /*  Simple loop representing a loop that goes through all the elements int he menue and then displays them.
     * 
     */
        
        for (int i = 1; i <= 4; i++)
        {
             dropDownMenuElements = " #post-6 > div > p:nth-child(6) > select > option:nth-child(" + i + ")";
             elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));

            Console.WriteLine("The " + i + "option from the drop down menu is: " + elementFromTheDropDownMenu.GetAttribute("value"));
        }

        Thread.Sleep(3900);


        driver.Quit();

        }
    }
