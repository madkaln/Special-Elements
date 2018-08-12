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
    //alert button 
    static IAlert alert;
    static IWebElement image;

    static void Main()
    {

        string url = "http://testing.todvachev.com/special-elements/alert-box/";

        driver.Navigate().GoToUrl(url);

        //this initialises the alert and clicks on the accept button
        alert = driver.SwitchTo().Alert();


        Console.WriteLine(alert.Text);
        Console.ReadLine();

        alert.Accept();

        /* This try and catch block will assist on automation when for some reason the accept button failed but
         * still bassed and we are making sure that we see the image displayed after OK button and
         * see the image afer alert text box.
         */


        image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));
        try
        {
            if (image.Displayed)
            {
                Console.WriteLine("The alert was successfuly accepted and I can see the image");
            }
        }
        catch (NoSuchElementException)
        {
            Console.WriteLine("Something went wrong!!");
        }

        Thread.Sleep(3000);



        driver.Quit();
    }
}

