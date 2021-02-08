using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;

namespace nUnitWSEI
{
    [TestFixture]
    public class OrderSkipAttribute
    {
        [Test]
        [Order(2)]
        [Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            Assert.Ignore("Defect 12345");
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/register";

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='u_0_s']"));
            emailTextField.SendKeys("Selenium C#");
        }

        [Test]
        [Order(1)]
        [Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/register";

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='u_0_s']"));
            emailTextField.SendKeys("Selenium C#");
        }

        [Test]
        [Order(0)]
        [Category("OrderSkipAttribute")]
        public void TestMethod3()
        {
            IWebDriver driver = new OperaDriver();
            driver.Url = "https://www.facebook.com/register";

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='u_0_s']"));
            emailTextField.SendKeys("Selenium C#");
        }
    }
}
