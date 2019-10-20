using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvanced.Pages.Droppable
{
    public partial class DroppablePage
    {
        public void AssertDroppableColor(string expectedColor, string message)
        {
            Assert.AreNotEqual(expectedColor, Droppable.GetCssValue("color"), message);
        }

        public void AssertDroppableTextWhenTargetIsCorrectlyDropped(string expectedMessage)
        {
            Assert.AreEqual("Dropped!", expectedMessage, "Invalid droppable text!");
        }

    }
}
