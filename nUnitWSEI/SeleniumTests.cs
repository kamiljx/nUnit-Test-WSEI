using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace nUnitWSEI
{
    [TestFixture]
    public class SeleniumTests
    {
        [Test]
        [Author("Kamil Rzeszutek", "rzeszutek98@gmail.com")]
        [Description("Facebook login verify")]
        [TestCaseSource("DataDrivenTesting")]
        public void Test1(String urlName)
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "https://facebook.com/register";
                driver.Url = urlName;
                IWebElement allowCookies = driver.FindElement(By.XPath("//*[@id='u_0_1e']"));
                allowCookies.Click();
                //IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='u_0_s']"));
                IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='abcd']"));
                emailTextField.SendKeys("Selenium C#");

                driver.Quit();

            }
            catch (Exception ex)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("/Users/kamilrzeszutek/Repos/nUnitWSEI/nUnitWSEI/Screenshots/sc1.png", ScreenshotImageFormat.Png);
                Console.WriteLine(ex.StackTrace);
                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
        }
        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://facebook.com/register");
            //list.Add("https://youtube.com");
            //list.Add("https://gmail.com");
            return list;
        }

        //[Test]
        //[Author("Kamil Rzeszutek", "rzeszutek98@gmail.com")]
        //[Description("Facebook login verify")]
        //public void Test2()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Url = "https://facebook.com/register";
        //    IWebElement allowCookies = driver.FindElement(By.XPath("//*[@id='u_0_1e']"));
        //    allowCookies.Click();
        //    IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='u_0_s']"));
        //    emailTextField.SendKeys("Selenium C#");

        //    driver.Close();
        //}

    }
}
