using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvanced.Pages.Droppable
{
    public partial class DroppablePage
    {
        public void MoveDraggable(int offsetX, int offsetY)
        {
            Actions builder = new Actions(Driver);
            builder
                .MoveToElement(Draggable)
                .ClickAndHold()
                .MoveByOffset(offsetX, offsetY)
                .Release()
                .Perform();
        }


    }
}
