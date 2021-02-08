using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace nUnitWSEI.Utilities
{
    public class BrowserUtility
    {
        public IWebDriver Init (IWebDriver driver)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://facebook.com/register";
            IWebElement allowCookies = driver.FindElement(By.XPath("//*[@id='u_0_1e']"));
            allowCookies.Click();
            return driver;
        }
    }
}
