using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using nUnitWSEI.BaseClass;
using OpenQA.Selenium.Support.UI;
using nUnitWSEI.Utilities;

namespace nUnitWSEI
{
    [TestFixture]
    public class ParallelTesing
    {
        readonly IWebDriver driver;
        [Test]
        [Category("UAT Testing"), Category("Module1")]
        public void TestMethod1()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='u_0_s']"));
            emailTextField.SendKeys("Selenium C#");

            Driver.Close();
        }

        [Test]
        [Category("UAT Testing"), Category("Module1")]
        public void TestMethod2()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='u_0_s']"));
            emailTextField.SendKeys("Selenium C#");

            Driver.Close();
        }

        [Test]
        [Category("UAT Testing"), Category("Module1")]
        public void TestMethod3()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='u_0_s']"));
            emailTextField.SendKeys("Selenium C#");

            Driver.Close();
        }

        [Test]
        [Category("UAT Testing"), Category("Module1")]
        public void TestMethod4()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='u_0_s']"));
            emailTextField.SendKeys("Selenium C#");

            Driver.Close();
        }

        [Test]
        [Category("UAT Testing"), Category("Module1")]
        public void TestMethod5()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='u_0_s']"));
            emailTextField.SendKeys("Selenium C#");

            Driver.Close();
        }

        [Test]
        [Category("UAT Testing"), Category("Module1")]
        public void TestMethod6()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='u_0_s']"));
            emailTextField.SendKeys("Selenium C#");

            Driver.Close();
        }

        [Test]
        [Category("UAT Testing"), Category("Module1")]
        public void TestMethod7()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='u_0_s']"));
            emailTextField.SendKeys("Selenium C#");

            Driver.Close();
        }

        [Test]
        [Category("UAT Testing"), Category("Module1")]
        public void TestMethod8()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='u_0_s']"));
            emailTextField.SendKeys("Selenium C#");

            Driver.Close();
        }


        [Test]
        [Category("UAT Testing"), Category("Module1")]
        public void TestMethod9()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='u_0_s']"));
            emailTextField.SendKeys("Selenium C#");

            Driver.Close();
        }

        //[Test]
        [Category("UAT Testing"), Category("Module1")]
        public void TestMethod10()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='u_0_s']"));
            emailTextField.SendKeys("Selenium C#");

            Driver.Close();
        }


    }
}