using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumAdvanced.Pages.Draggable;
using SeleniumAdvanced.Tests;

namespace SeleniumAdvanced
{
    [TestFixture]
    class DraggableTests : BaseTest
    {
        private DraggablePage _draggablePage;
        private IWebElement _draggable;

        [SetUp]
        public void Init()
        {
            //init pages
            _draggablePage = new DraggablePage(Driver);

            //navigate to draggable page
            _draggablePage.Navigate();

            //get draggable
            _draggable = _draggablePage.Draggable;
        }

        [Test]
        public void DraggedDraggableShouldBeAtTheDroppedSpotByXCoordinate()
        {
            int xOffset = 145;
            int draggableXBeforeDrag = _draggable.Location.X;

            _draggablePage.MoveDraggable(xOffset, 0);

            int draggableCurrentX = _draggable.Location.X;

            _draggablePage.AssertCorrectPosition(draggableCurrentX, (draggableXBeforeDrag + xOffset), "X");
        }

        [Test]
        public void DraggedDraggableShouldBeAtTheDroppedSpotByYCoordinate()
        {
            int yOffset = 25;
            int draggableYBeforeDrag = _draggable.Location.Y;

            _draggablePage.MoveDraggable(0, yOffset);

            int draggableCurrentY = _draggable.Location.Y;
            _draggablePage.AssertCorrectPosition(draggableCurrentY, (draggableYBeforeDrag + yOffset), "Y");
        }

    }
}
