using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvanced.Pages.Selectable
{
    public partial class SelectablePage
    {
        private IList<IWebElement> FindLiElements(By elementSelector)
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(15))
                .Until<bool>(w => w.FindElement(elementSelector) != null);

            return this.Driver.FindElements(elementSelector);
        }

        public IWebElement SelectSingleElementByIndex(int index)
        {
            IWebElement selectable = Selectables[index];

            new Actions(Driver)
                .MoveToElement(selectable)
                .Click()
                .Perform();

            return selectable;
        }

        public IList<IWebElement> SelectTwoElementsByIndex(int firstElIndex, int secElIndex)
        {
            IWebElement firstSelectable = Selectables[firstElIndex];
            IWebElement secondSelectable = Selectables[secElIndex];

            new Actions(Driver)
                .KeyDown(Keys.Control)
                .MoveToElement(firstSelectable)
                .Click()
                .MoveToElement(secondSelectable)
                .Click()
                .KeyUp(Keys.Control)
                .Perform();

            return new List<IWebElement>()
            {
                firstSelectable,
                secondSelectable
            };
        }

    }
}
