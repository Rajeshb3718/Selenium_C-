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

    public class AlertHandlingTest:BaseClass
    {
        [Test]
        public void AlertHandling()
        {
            HeroKuApp();
            internetHomePage internetHomePage = new internetHomePage(driver);
            internetHomePage.ClickOnJavascriptAlertAndAccept();

            string AlertMessage = internetHomePage.GetMessageAndAcceptAlert();
            Assert.AreEqual("I am a JS Alert", AlertMessage);

            string AlertMessageToReject = internetHomePage.GetMessageAndRejectAlert();
            Assert.AreEqual("I am a JS Confirm", AlertMessageToReject);

            internetHomePage.ClickOnJSPromptAndEnterMessageAndOK();

            CleanUp();
        }

    }
}
