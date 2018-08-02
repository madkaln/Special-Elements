using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class TextInputField
{
    /*This part of code represents how to access text box
     * initialising drivers outside main for the code to access it globally
     */

    static IWebDriver driver = new ChromeDriver();
    static IWebElement textBox;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/text-input-field/";
        driver.Navigate().GoToUrl(url);

        textBox = driver.FindElement(By.Name("username"));
        textBox.SendKeys("Test Text");

        Thread.Sleep(3000);

        //Have to specify value as otherwise return an empty string
        //Console.WriteLine(textBox.GetAttribute("value"));

        //Return max length available in the text box

        Console.WriteLine(textBox.GetAttribute("maxlength"));

        Thread.Sleep(3000);

        driver.Quit();

    }
}

