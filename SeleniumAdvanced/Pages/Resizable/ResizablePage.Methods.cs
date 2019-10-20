using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvanced.Pages.Resizable
{
    public partial class ResizablePage
    {
        public void DragAndDropToOffset(int offsetX, int offsetY)
        {
            new Actions(Driver)
                .DragAndDropToOffset(StartDragPoint, offsetX, offsetY)
                .Perform();
        }
    }
}
