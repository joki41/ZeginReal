using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
            Thread.Sleep(3000); // morav da dodam pauza tuka posho mi frlashe error "element is not clickable at point blabla"
            driver.FindElement(By.XPath("//*[@id=\"popup-buttons\"]/button[1]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"cboxClose\"]")).Click();
            Thread.Sleep(1000);
           
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
        public void Kategorii()
        {
            var element = driver.FindElement(By.CssSelector("#block-main-navigation > ul > li:nth-child(1) > a"));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            driver.FindElement(By.LinkText("Историја")).Click();




        }
           
           
            
             
         



      
    }
}
