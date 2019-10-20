using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvanced.Pages
{
    public abstract class BasePage
    {
        private IWebDriver _driver;
        private string _url;
        private WebDriverWait _wait;

        public BasePage(IWebDriver driver, string url)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            _url = url;
        }
        public string Url => _url;

        public IWebDriver Driver => _driver;

        public WebDriverWait Wait => _wait;

        public virtual void Navigate()
        {
            Driver.Url = _url;
        }
    }
}
