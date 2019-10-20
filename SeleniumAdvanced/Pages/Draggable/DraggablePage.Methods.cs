using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvanced.Pages.Draggable
{
    public partial class DraggablePage
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
