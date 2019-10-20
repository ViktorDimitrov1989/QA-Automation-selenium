using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvanced.Pages.Draggable
{
    public partial class DraggablePage
    {

        public void AssertCorrectPosition(int expectedPosition, int actualPosition, string axis)
        {
            Assert.AreEqual(expectedPosition, actualPosition, "Current position" + axis + " of the draggable is not valid!");
        }



    }
}
