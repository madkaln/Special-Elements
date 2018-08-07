using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement raidoButtons;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/radio-button-test/";
        string option = 1;

        driver.Navigate().GoToUrl(url);

   
    }
}

