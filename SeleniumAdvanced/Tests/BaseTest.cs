using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
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
            var sauceOptions = new Dictionary<string, object>();

            ChromeOptions options = new ChromeOptions();
            options.PlatformName = "windows";
            options.BrowserVersion = "77.0";
            
            Driver = new RemoteWebDriver(
                new Uri("http://172.21.64.1:6069/wd/hub"),
                options.ToCapabilities(),
                TimeSpan.FromSeconds(10)
                );

            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
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
