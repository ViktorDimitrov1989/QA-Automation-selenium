using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvanced.Pages.Resizable
{
    public partial class ResizablePage : BasePage
    {
        private const string URL = "https://demoqa.com/resizable/";

        public ResizablePage(IWebDriver driver) : base(driver, URL) { }

        public IWebElement Resizable => Driver.FindElement(By.Id("resizable"));
        public IWebElement StartDragPoint => Driver.FindElement(By.XPath(@"//*[@id=""resizable""]/div[3]"));

    }
}
