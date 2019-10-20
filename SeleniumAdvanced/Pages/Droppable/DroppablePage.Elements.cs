using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvanced.Pages.Droppable
{
    public partial class DroppablePage : BasePage
    {
        private const string URL = "https://demoqa.com/droppable/";

        public DroppablePage(IWebDriver driver) : base(driver, URL) { }

        public IWebElement Draggable => Driver.FindElement(By.Id("draggable"));
        public IWebElement Droppable => Driver.FindElement(By.Id("droppable"));
        public IWebElement DroppableText => Driver.FindElement(By.XPath(@"//*[@id=""droppable""]/p"));
    }
}
