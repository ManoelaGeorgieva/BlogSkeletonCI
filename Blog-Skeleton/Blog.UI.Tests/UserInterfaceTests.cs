﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Blog.UI.Tests
{
    [TestFixture]
    public class UserInterfaceTests
    {
        [Test]
        public void CheckSiteLoads()
        {
            IWebDriver driver = BrowserHost.Instance.Application.Browser;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
           // Thread.Sleep(3000);
            driver.Navigate().GoToUrl(@"http://demoqa.com/registration/");
           // Thread.Sleep(3000);
          //  var text = driver.Title;
            
         //   IWebElement helloWorld = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/article/header/h2/a"));
           // IWebElement logo = wait.Until(w => w.FindElement(By.XPath("/html/body/div[1]/div/div[1]/a")));
            Assert.AreEqual("Registration | Demoqa", driver.Title);
        }

        [Test]
        public void ClickOnDraggable()
        {
            IWebDriver driver = BrowserHost.Instance.Application.Browser;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            driver.Navigate().GoToUrl(@"http://demoqa.com/registration/");
            var draggable = driver.FindElement(By.XPath("//*[@id=\"menu-item-140\"]/a"));
            draggable.Click();
            Assert.AreEqual("Draggable | Demoqa", driver.Title);
        }
    }
}
