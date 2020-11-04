using NUnit.Framework;
using OpenQA.Selenium;
using System.IO;
using OpenQA.Selenium.Firefox;

namespace Royale.Tests
{
   public class AITTestsFirefox

    {
        IWebDriver driver;

        [SetUp]
        public void BeforeEach()
        {
            driver = new FirefoxDriver(Path.GetFullPath(@"../../../../" + "_drivers"));
        }

        [TearDown]
        public void AfterEach()
        {
            driver.Quit();
        }

        [Test]

        public void AIT_Principles_Is_Naviable()
        {
            //1. Maximise window
            driver.Manage().Window.Maximize();
            //2. go to AIT home page         
            driver.Url = "https://automationintesting.com";
            //4. click principles area
            driver.FindElement(By.Id("quicklook-principes")).Click();
            //5. Assert principles section shown
            var principles = driver.FindElement(By.Id("principles"));
            Assert.That(principles.Displayed);
        }
    }
}