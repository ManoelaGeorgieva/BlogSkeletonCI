using NUnit.Framework;
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
            Assert.AreEqual("List - My ASP.NET Application", driver.Title);
        }

        [Test]
        public void Register()
        {
            IWebDriver driver = BrowserHost.Instance.Application.Browser;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            driver.FindElement(By.Id("registerLink")).Click();
            Assert.AreEqual("Register", driver.FindElement(By.XPath("/html/body/div[2]/div/div/h2")).Text);
        }


        //[Test]
        //public void ClickOnDraggable()
        //{
        //    IWebDriver driver = BrowserHost.Instance.Application.Browser;
        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
        //    driver.Navigate().GoToUrl(@"http://demoqa.com/registration/");
        //    var draggable = driver.FindElement(By.XPath("//*[@id=\"menu-item-140\"]/a"));
        //    draggable.Click();
        //    Assert.AreEqual("Draggable | Demoqa", driver.Title);
        //}
    }
}
