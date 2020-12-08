using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace gyarorlatdolgozat
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // 1. feladat
            IWebDriver dw = new FirefoxDriver();
            dw.Navigate().GoToUrl("http://atthy4.atspace.cc/seleniumdoga/Hivatalosdoga.html");
            dw.Manage().Window.Maximize();

            dw.FindElement(By.LinkText("DevOps 1")).Click();

            String Url = dw.Url;

            dw.Navigate().Back();

            // 2. feladat
            IWebElement elem = dw.FindElement(By.Name("visitor[a]"));
            SelectElement select = new SelectElement(elem);
            select.SelectByIndex(1);

            IWebElement elem2 = dw.FindElement(By.Name("visitor[b]"));
            SelectElement select2 = new SelectElement(elem2);
            select2.SelectByIndex(2);

            dw.FindElement(By.Id("eredmeny_v01_3")).Click();
            dw.FindElement(By.Id("eredmeny_h01_3")).Click();

            // 2. feladat
            IWebElement the_checkbox = dw.FindElement(By.Id("checkbox_car"));
            if (!the_checkbox.Selected)
            {
                the_checkbox.Click();
            }

            Assert.IsTrue(the_checkbox.Selected);

            // 3. feladat
            IWebElement radio_kivalo = dw.FindElement(By.Id("radio_kivalo"));
            IWebElement radio_jeles = dw.FindElement(By.Id("radio_jeles"));
            if (!radio_kivalo.Selected)
            {
                radio_kivalo.Click();
            }

            Assert.IsFalse(radio_jeles.Selected);

            // 4. feladat
            IWebElement button = dw.FindElement(By.XPath("/html/body/button"));
            button.Click();
            int imgs = dw.FindElements(By.TagName("img")).Count;
            Assert.AreEqual(2, imgs);

            // 5. feladat
            IWebElement img = dw.FindElement(By.XPath("/html/body/img"));
            img.Click();
        }
    }
}
