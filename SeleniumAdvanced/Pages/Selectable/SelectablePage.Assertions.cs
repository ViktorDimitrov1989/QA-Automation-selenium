using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvanced.Pages.Selectable
{
    public partial class SelectablePage
    {
        private const string SELECTED_ELEMENT_RGBA = "rgba(243, 152, 20, 1)";

        public void AssertSelectedElementsSelectedColors(string colorAfterSelection, String message)
        {

            Assert.AreEqual(
                SELECTED_ELEMENT_RGBA, 
                colorAfterSelection, 
                message
                );

        }

        public void AssertMultipleSelectedElementsSelectedColors(
            IList<IWebElement> selectedElements, 
            String message)
        {

            foreach (IWebElement element in selectedElements)
            {
                Assert.AreEqual(
                                SELECTED_ELEMENT_RGBA,
                                element.GetCssValue("background-color"),
                                message
                                );
            }
            
        }

    }
}
