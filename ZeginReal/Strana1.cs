using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZeginReal
{
    internal class Strana1
    {
        IWebDriver driver = null;
        public Strana1(IWebDriver driver)
        {
            this.driver = driver;
            driver.Navigate().GoToUrl("https://www.zegin.com.mk/mk");
            driver.Manage().Window.Maximize();

            //find kopce ok kukisi i kopce od reklama i klikni
            // linija za commit
           
        }
        public void NapisiTekstVoPoleto(string tekst)
        {
            driver.Navigate().GoToUrl("https://www.zegin.com.mk");
            driver.FindElement(By.XPath("//input[@type='text']")).Click();
            driver.FindElement(By.XPath("//input[@type='text']")).Clear();
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("Sirup");
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys(Keys.Enter);

            //
        }
        public void SocialMediaButtons1()
        {
             
            //test za joco

            // this is just a test or git

        }
    }
}
