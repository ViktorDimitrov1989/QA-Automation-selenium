using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumAdvanced.Factories;
using SeleniumAdvanced.Models;
using SeleniumAdvanced.Pages.Login;
using SeleniumAdvanced.Pages.Registration;
using SeleniumAdvanced.Tests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SeleniumAdvanced
{
    
    [TestFixture]
    class RegistrationNegativeTests : BaseTest
    {

        private LoginPage _loginPage;
        private RegistrationPage _registrationPage;
        private RegistrationUser _user;

        [SetUp]
        public void Init()
        {

            //init pages
            _loginPage = new LoginPage(Driver);
            _registrationPage = new RegistrationPage(Driver);

            //init registration user
            _user = RegistrationUserFactory.CreateValidUser();

            //navigate to register page
            _loginPage.Navigate();
            _loginPage.FillLoginForm();
        }

        [Test]
        public void RegistrationAttemptWithInvalidPhoneShouldShowError()
        {
            _user.Phone = "";
            _registrationPage.FillForm(_user);
            _registrationPage.AssertErrorMessage("You must register at least one phone number.");
        }

        [Test]
        public void RegistrationAttemptWithInvalidAdressShouldShowError()
        {
            _user.Address = "";
            _registrationPage.FillForm(_user);
            _registrationPage.AssertErrorMessage("address1 is required.");
        }

        [Test]
        public void RegistrationAttemptWithInvalidLastNameShouldShowError()
        {
            _user.LastName = "";
            _registrationPage.FillForm(_user);
            _registrationPage.AssertErrorMessage("lastname is required.");
        }

        [Test]
        public void RegistrationAttemptWithInvalidCityShouldShowError()
        {
            _user.City = "";
            _registrationPage.FillForm(_user);
            _registrationPage.AssertErrorMessage("city is required.");
        }

        [Test]
        public void RegistrationAttemptWithInvalidPasswordShouldShowError()
        {
            _user.Password = "";
            _registrationPage.FillForm(_user);
            _registrationPage.AssertErrorMessage("passwd is required.");
        }


    }
}
