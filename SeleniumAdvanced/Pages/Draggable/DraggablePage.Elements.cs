using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvanced.Pages.Draggable
{
    public partial class DraggablePage : BasePage
    {
        private const string URL = "https://demoqa.com/draggable/";

        public DraggablePage(IWebDriver driver) : base(driver, URL) { }

        public IWebElement Draggable => Driver.FindElement(By.Id("draggable"));

    }
}
