using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.Edge;

namespace Royale.Tests
{
   public class AITTestsEdge

    {
        IWebDriver driver;

        [SetUp]
        public void BeforeEach2()
        {
            var options = new EdgeOptions();
            options.UseChromium = true;

            driver = new EdgeDriver(Path.GetFullPath(@"../../../../" + "_drivers"), options);
        }

        [TearDown]
        public void AfterEach2()
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