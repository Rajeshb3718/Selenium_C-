using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumFunctions.Common;
using TestSeleniumFunctions.Pages;

namespace TestSeleniumFunctions.Tests
{
    public class CheckBox_CheckAndUnCheck_Test : BaseClass
    {
        [Test]
        public void CheckBox_CheckAndUnCheck()
        {
            IRCTC();
            RCTCHomePage rCTCHomePage = new RCTCHomePage(driver);
            rCTCHomePage.SelectCheckBox();
            CleanUp();
        }
    }
}
