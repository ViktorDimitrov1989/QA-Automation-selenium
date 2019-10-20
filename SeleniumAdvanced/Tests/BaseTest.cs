using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace SeleniumAdvanced.Tests
{
    [TestFixture]
    class BaseTest
    {
        public IWebDriver Driver{ get; private set; }

        [OneTimeSetUp]
        public void InitializeTest()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }

        /*[TearDown]
        public void CleanUpWithScreenShot()
        {
            string name = TestContext.CurrentContext.Test.Name;
            ResultState result = TestContext.CurrentContext.Result.Outcome;

            if (result != ResultState.Success)
            {
                var screenShot = ((ITakesScreenshot)Driver).GetScreenshot();
                var directory = Directory.GetCurrentDirectory();
                var fullPath = Path.GetFullPath("..\\..\\..\\ScreenShots\\");

                screenShot.SaveAsFile(
                    fullPath + name + ".png", 
                    ScreenshotImageFormat.Png
                    );
            }

        }*/
    }
}
