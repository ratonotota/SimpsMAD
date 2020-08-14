using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace learningSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments(@"user-data-dir=C:\Users\raton\AppData\Local\Google\Chrome\User Data");
            ChromeDriver driver = new ChromeDriver(options);
       
            driver.Navigate().GoToUrl("https://discord.com/invite/pokimane");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.ClassName("contents-18-Yxp")).Click();
            System.Threading.Thread.Sleep(6200);
            var captureds = driver.FindElementsByXPath("//div[@class='name-3_Dsmg overflow-WK9Ogt']");
            captureds.First(x => x.Text == "verification").Click();
            System.Threading.Thread.Sleep(1000);
            driver.SwitchTo().ActiveElement().SendKeys("!verify");
            driver.SwitchTo().ActiveElement().SendKeys(Keys.Enter);
            driver.FindElementByClassName("homeIcon-tEMBK1").Click();
            driver.FindElementByClassName("overflow-WK9Ogt").Click();
            System.Threading.Thread.Sleep(300);
            driver.SwitchTo().ActiveElement().SendKeys("dqjYN");
            driver.SwitchTo().ActiveElement().SendKeys(Keys.Enter);
                System.Threading.Thread.Sleep(300);
            driver.FindElementByClassName("wrapper-1BJsBx").Click();

            System.Threading.Thread.Sleep(30000);
            var captured = "oi";




        }
    }
}
