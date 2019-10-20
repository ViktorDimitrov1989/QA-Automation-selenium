using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvanced.Pages.Registration
{
    public partial class RegistrationPage
    {
        public void AssertErrorMessage(string expectedMessage)
        {
            IList<IWebElement> errors = Errors.FindElements(By.TagName(@"li"));
            String errorText = errors[0].Text;
            Assert.AreEqual(expectedMessage, errorText, "Error message differs from the expected error message!");
        }

    }
}
