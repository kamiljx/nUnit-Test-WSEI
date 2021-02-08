using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace nUnitWSEI.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/register";
            IWebElement allowCookies = driver.FindElement(By.XPath(".//*[@id='u_0_h']"));
            allowCookies.Click();

        }
        [TearDown]
        public void Close()
        {
            // driver.Quit();
        }

    }
}

