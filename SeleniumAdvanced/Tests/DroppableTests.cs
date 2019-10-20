using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumAdvanced.Pages.Droppable;
using SeleniumAdvanced.Tests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace SeleniumAdvanced
{
    [TestFixture]
    class DroppableTests : BaseTest
    {

        DroppablePage _droppablePage;

        [SetUp]
        public void Init()
        {
            _droppablePage = new DroppablePage(Driver);

            _droppablePage.Navigate();
        }


        [Test]
        public void DropDraggableOnTargetShouldChangeTargetsColorToYellow()
        {
            _droppablePage.MoveDraggable(145, 25);
            _droppablePage.AssertDroppableColor("rgba(51, 51, 51, 1)", "Target color is not changed!");
        }

        [Test]
        public void DropDraggableOnTargetShouldChangeTargetText()
        {
            _droppablePage.MoveDraggable(145, 25);
            _droppablePage.AssertDroppableTextWhenTargetIsCorrectlyDropped("Dropped!");
        }

        [Test]
        public void DropDraggableNotFullyOnTargetShouldNotChangeTargetsColor()
        {
            int draggableX = _droppablePage.Draggable.Location.X;
            int draggableY = _droppablePage.Draggable.Location.Y;

            _droppablePage.MoveDraggable(70, 15);
            _droppablePage.AssertDroppableColor("rgba(233, 233, 233, 1)", "Target color should not be changed!");
        }


    }
}
