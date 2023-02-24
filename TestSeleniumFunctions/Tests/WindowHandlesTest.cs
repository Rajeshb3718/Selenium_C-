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
    public class WindowHandlesTest : BaseClass
    {
        [Test]
        public void WindowHandles()
        {
            HeroKuApp();
            internetHomePage internetHomePage = new internetHomePage(driver);
            string Page2Title = internetHomePage.ClickMultipleWindows();
            Assert.AreEqual("New Window", Page2Title);
            CleanUp();
        }
    }
}
