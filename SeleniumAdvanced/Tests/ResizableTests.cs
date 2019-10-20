using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using SeleniumAdvanced.Pages.Resizable;
using SeleniumAdvanced.Tests;

namespace SeleniumAdvanced
{
    [TestFixture]
    class ResizableTests : BaseTest
    {
        private ResizablePage _resizablePage;

        [SetUp]
        public void Init()
        {
            _resizablePage = new ResizablePage(Driver);

            _resizablePage.Navigate();
        }

        [Test]
        public void ResizedResizableShouldBeWithCorrectWithAfterResizeByXCoordinate()
        {
            int xOffset = 145;
            int borderOffset = 17;
            int startWidth = _resizablePage.Resizable.Size.Width;

            new Actions(Driver)
                .DragAndDropToOffset(_resizablePage.StartDragPoint, xOffset, 0)
                .Perform();

            int endWidth = _resizablePage.Resizable.Size.Width;
            _resizablePage.AssertResizableDimensions((endWidth + borderOffset), (startWidth + xOffset), "Width");
        }

        [Test]
        public void ResizedResizableShouldBeWithCorrectHeightAfterResizeByYCoordinate()
        {
            int yOffset = 45;
            int borderOffset = 17;
            int startHeight = _resizablePage.Resizable.Size.Height;

            _resizablePage.DragAndDropToOffset(0, yOffset);

            int endHeight = _resizablePage.Resizable.Size.Height;

            _resizablePage.AssertResizableDimensions((endHeight + borderOffset), (startHeight + yOffset), "Height");
        }


    }
}
