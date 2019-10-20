using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvanced.Pages.Selectable
{
    public partial class SelectablePage : BasePage
    {
        private const string URL = "https://demoqa.com/selectable/";

        public SelectablePage(IWebDriver driver) : base(driver, URL) { }

        public IList<IWebElement> Selectables {
            get
            {
                return Driver.FindElement(By.Id("selectable")).FindElements(By.TagName(@"li"));
            }
        }

    }
}
