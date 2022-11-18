using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeginReal
{
    [TestClass]
    [TestCategory("POM")]
    public class UnitTest1
    {
        static IWebDriver driver = new ChromeDriver();
        Strana1 homepage = new Strana1(driver);
        [TestMethod]
        public void TestMethod1()
        {
            homepage.NapisiTekstVoPoleto("Sirup");

            Thread.Sleep(3000);

            string strurl = driver.Url;

            Assert.AreEqual("https://www.zegin.com.mk/mk/products?product=Sirup", strurl);
        }
        [TestMethod]
        public void Kategorii()
        {
            homepage.Kategorii();

            String strUrl = driver.Url;

            Assert.AreEqual("https://www.zegin.com.mk/mk/istorija", strUrl);
        }


    }
}