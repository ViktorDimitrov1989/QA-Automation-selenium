using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvanced.Pages.Resizable
{
    public partial class ResizablePage
    {

        public void AssertResizableDimensions(int dimentioonExpectedNumericValue, int dimentionActualNumericValue, string dimentionStringValue)
        {
            Assert.AreEqual(
                dimentioonExpectedNumericValue, 
                dimentionActualNumericValue, 
                "The" + dimentionStringValue + "value of the resizable is not valid!"
                );

        }

    }
}
