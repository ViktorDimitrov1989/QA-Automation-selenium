using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace SeleniumAdvanced.Pages.Login
{
    public partial class LoginPage : BasePage
    {
        private const string URL = "http://automationpractice.com/index.php?controller=my-account";

        public LoginPage(IWebDriver driver) : base(driver, URL) {}

        public IWebElement Email => Driver.FindElement(By.Id("email_create"));

        public IWebElement Submit => Driver.FindElement(By.Id("SubmitCreate"));

    }
}
