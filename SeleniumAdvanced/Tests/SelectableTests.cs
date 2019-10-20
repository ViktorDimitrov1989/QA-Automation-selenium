using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumAdvanced.Pages.Selectable;
using SeleniumAdvanced.Tests;
using System.Collections.Generic;

namespace SeleniumAdvanced
{
    [TestFixture]
    class SelectableTests : BaseTest
    {

        private SelectablePage _selectablePage;

        [SetUp]
        public void Init()
        {
            _selectablePage = new SelectablePage(Driver);

            _selectablePage.Navigate();
        }


        [Test]
        public void SelectFirstItemShouldChangeItsColor()
        {
            IWebElement firstSelectable = _selectablePage.SelectSingleElementByIndex(0);

            _selectablePage.AssertSelectedElementsSelectedColors(_selectablePage.Selectables[0].GetCssValue("background-color"), "Selected elemend has not chaged it's color!");
        }

        [Test]
        public void SelectFirstAndSecondItemShouldChangeTheirColor()
        {
            IList<IWebElement> selectables = _selectablePage.SelectTwoElementsByIndex(0,1);

            _selectablePage.AssertMultipleSelectedElementsSelectedColors(selectables, "Selected elemend has not chaged it's color!");
        }

    }
}
