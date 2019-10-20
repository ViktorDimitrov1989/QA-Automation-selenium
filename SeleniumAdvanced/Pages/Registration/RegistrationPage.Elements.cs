using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAdvanced.Pages.Registration
{
    public partial class RegistrationPage : BasePage
    {
        private const string URL = "http://automationpractice.com/index.php?controller=authentication&back=my-account#account-creation";

        public RegistrationPage(IWebDriver driver) : base(driver, URL){}

        public IList<IWebElement> RadioButtons => Wait.Until(d =>
        {
            var res = d.FindElements(By.XPath("//div[@class='radio']//input"));
            if (res.Count != 0)
            {
                return res;
            }

            //TODO: handle this NPE
            return null;
        });

        public IWebElement CustomerFirstName => Driver.FindElement(By.Id("customer_firstname"));

        public IWebElement CustomerLastName => Driver.FindElement(By.Id("customer_lastname"));

        public IWebElement Password => Driver.FindElement(By.Id("passwd"));

        public IWebElement Errors => Driver.FindElement(By.XPath(@"//*[@id=""center_column""]/div/ol"));

        public SelectElement Days
        {
            get
            {
                IWebElement reminder = Driver.FindElement(By.Id("days"));
                return new SelectElement(reminder);
            }
        }

        public SelectElement Months
        {
            get
            {
                IWebElement reminder = Driver.FindElement(By.Id("months"));
                return new SelectElement(reminder);
            }
        }

        public SelectElement Years
        {
            get
            {
                IWebElement reminder = Driver.FindElement(By.Id("years"));
                return new SelectElement(reminder);
            }
        }

        public IWebElement FirstName => Driver.FindElement(By.Id("firstname"));

        public IWebElement LastName => Driver.FindElement(By.Id("lastname"));

        public IWebElement Address => Driver.FindElement(By.Id("address1"));

        public IWebElement City => Driver.FindElement(By.Id("city"));

        public SelectElement State
        {
            get
            {
                IWebElement reminder = Driver.FindElement(By.Id("id_state"));
                return new SelectElement(reminder);
            }
        }

        public IWebElement PostCode => Driver.FindElement(By.Id("postcode"));

        public IWebElement Phone => Driver.FindElement(By.Id("phone_mobile"));

        public IWebElement Alias => Driver.FindElement(By.Id("alias"));

        public IWebElement RegisterButton => Driver.FindElement(By.Id("submitAccount"));

    }
}
