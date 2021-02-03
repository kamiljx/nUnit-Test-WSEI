using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using nUnitWSEI.BaseClass;

namespace nUnitWSEI
{
    [TestFixture]
    public class Tests : BaseTest
    {
        [Test]
        public void TestMethod1()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='u_0_s']"));
            emailTextField.SendKeys("Selenium C#");
        }

        [Test]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='u_0_s']"));
            emailTextField.SendKeys("Selenium C#");
        }

        [Test]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='u_0_s']"));
            emailTextField.SendKeys("Selenium C#");
        }


    }
}