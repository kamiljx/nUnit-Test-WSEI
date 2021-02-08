using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using nUnitWSEI.BaseClass;
using OpenQA.Selenium.Support.UI;

namespace nUnitWSEI
{
    [TestFixture]
    public class Tests : BaseTest
    {
        [Test]
        [Category("Smoke testing")]
        public void TestMethod1()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='u_0_s']"));
            emailTextField.SendKeys("Selenium C#");

            IWebElement monthDropDownList = driver.FindElement(By.XPath("//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropDownList);
            element.SelectByIndex(1);
            element.SelectByText("Jul");
            element.SelectByValue("12");
        }

        //[Test]
        [Category("Regression Tesing")]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='u_0_s']"));
            emailTextField.SendKeys("Selenium C#");
        }

      //  [Test]
        [Category("Smoke testing")]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='u_0_s']"));
            emailTextField.SendKeys("Selenium C#");
        }


    }
}