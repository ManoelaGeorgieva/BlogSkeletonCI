using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;

namespace Blog.UI.Tests.RegistrationTesting
{
   public class RegisterMap
    {
        private IWebDriver driver;

        public IWebElement Email { get
            { return driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[2]/label")); }
        }

        public IWebElement FullName
        {
            get
            { return driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[3]/label")); }
        }
    }
}
