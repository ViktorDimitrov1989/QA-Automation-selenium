using System;
using System.Collections.Generic;
using System.Text;
using AutoFixture;
using OpenQA.Selenium;

namespace SeleniumAdvanced.Pages.Login
{
    public partial class LoginPage
    {

        public void FillLoginForm()
        {
            Fixture fixture = new Fixture();
            string randomEmailPrefix = fixture.Create<String>().Substring(0,5);
            Email.SendKeys(randomEmailPrefix + "@gmail.com");
            Submit.Click();
        }

    }
}
