using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;

namespace Tests
{
    public class Tests
    {
        IWebDriver Driver;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            if (Driver == null)
            {
                Driver = new ChromeDriver(@"D:\chromedriver");
                Driver.Manage().Window.Maximize();
            }
           // Driver = BaseDriver.GetDriver();
            Driver.Navigate().GoToUrl("https://www.google.com");
           // Driver.FindElement(By.Name("q")).SendKeys("Selenium");
            System.Threading.Thread.Sleep(5000);
            //Driver.FindElement(By.Name("btnG")).Click();
            //Assert.That(Driver
              //  .PageSource.Contains("Selenium"), Is.EqualTo(true), "The Text selenium does nt exist");
            //Assert.Pass();
        }

        [Test]
        public void Test2(){

        }
    }
}