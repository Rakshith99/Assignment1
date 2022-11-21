using System;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Chrome;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;


namespace ConsoleApp2
{
    internal class Program
    {
        static IWebDriver driver = new ChromeDriver();
        private static IWebElement element;
        private static IWebElement element1;

        static void Main(string[] args)
        {
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            // Console.WriteLine("Hello World!");
            //excerciseone();
            //excercisetwo();
             excercise5();
            //switchTab();
            //excercisefour();
            //excercisenine();
             // excerciseten();




        }

        public static void excerciseone()
        {

            IWebElement p1 = driver.FindElement(By.XPath("//input[@value='radio1']"));
            p1.Click();
            if (p1.GetAttribute("checked") == "true")
            {
                Console.WriteLine("The radio button 1 is checked");
            }
            else
            {
                Console.WriteLine("This is one of the uncheked radio button ");
            }
            Thread.Sleep(3000);

            IWebElement p2 = driver.FindElement(By.XPath("//input[@value='radio2']"));
            p2.Click();
            if (p2.GetAttribute("checked") == "true")
            {
                Console.WriteLine("The radio button 2 is checked");
            }
            else
            {
                Console.WriteLine("This is one of the uncheked radio button ");
            }
            Thread.Sleep(3000);

            IWebElement p3 = driver.FindElement(By.XPath("//input[@value='radio3']"));
            p3.Click();
            if (p3.GetAttribute("checked") == "true")
            {
                Console.WriteLine("The radio button 3 is checked");
            }
            else
            {
                Console.WriteLine("This is one of the uncheked radio button ");
            }
            Thread.Sleep(3000);
        }




        public static void excercisetwo()
        {
            //string url = "https://rahulshettyacademy.com/AutomationPractice/";
            // string option = "1";
            // driver.Navigate().GoToUrl(url);

            string option = "1";

            IWebElement Checkbox1 = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption" + option + "\"]"));
            Checkbox1.Click();
            Thread.Sleep(2000);
            Checkbox1.Click();

            Thread.Sleep(2000);

            Console.WriteLine(Checkbox1.GetAttribute("value"));
            string option2 = "2";

            IWebElement Checkbox2 = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption" + option2 + "\"]"));
            Checkbox2.Click();
            Thread.Sleep(2000);
            Checkbox2.Click();

            string option3 = "3";

            IWebElement Checkbox3 = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption" + option3 + "\"]"));
            Checkbox3.Click();
            Thread.Sleep(2000);
            Checkbox3.Click();
            Thread.Sleep(2000);

            for (int i = 1; i <= 3; i++)
            {
                IWebElement Checkall = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption" + i + "\"]"));
                Checkall.Click();
                Thread.Sleep(2000);
            }
            driver.Quit();
        }
        public static void excercisethree()
        {
            IWebElement selection = driver.FindElement(By.Id("autocomplete"));
            selection.SendKeys("united");
            IList<IWebElement> ubox = driver.FindElements(By.XPath("//div[@class='ui-menu-item-wrapper']"));

            //int count = ubox.Count;
            foreach (var uelement in ubox)
            {
                if (uelement.Text.Contains("United States (USA)"))
                {
                    uelement.Click();
                }
            }
        }

        public static void excercise5()
        {
            IWebElement switchwind = driver.FindElement(By.Id("openwindow"));
            switchwind.Click();
            Thread.Sleep(3000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }

        public static void switchTab()
        {
            IWebElement switchtab = driver.FindElement(By.Id("opentab"));
            switchtab.Click();
            Thread.Sleep(3000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }

        public static void excercisefour()
        {
            IWebElement below = driver.FindElement(By.Id("dropdown-class-example"));

            for (int i = 2; i < 5; i++)
            {
                IWebElement below1 = driver.FindElement(By.CssSelector("#dropdown-class-example"));
                below1.Click();
                Thread.Sleep(2000);
                below1.Click();
                Thread.Sleep(2000);
            }
        }

        public static void excerciseten()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(System.String.Format("window.scrollTo({0}, {1})", 400, 627));
            Thread.Sleep(1000);
        }

        public static void excercisenine()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(System.String.Format("window.scrollTo({0}, {1})", 400, 1000));
            Thread.Sleep(1000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            Actions action = new Actions(driver);
            element = driver.FindElement(By.XPath("//*[@id=\"mousehover\"]"));
            element1 = driver.FindElement(By.XPath("/html/body/div[4]/div/fieldset/div/div/a[1]"));
            action.MoveToElement(element).Perform();
            action.MoveToElement(element1).Perform();
            element1.Click();
        }

    }

}
