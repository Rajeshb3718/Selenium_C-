using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestSeleniumFunctions.Common;
using TestSeleniumFunctions.Pages;

namespace TestSeleniumFunctions.Tests
{
    public class YoutubeSearc : BaseClass
    {
        [Test]
        public void YouTubeSearchTest()
        {
            YouTube();
            YouTubeHomePage youTubeHomePage = new YouTubeHomePage(driver);
            youTubeHomePage.SearchCSharp(jObject["SearchValue"].ToString());
            youTubeHomePage.SerachLib();
            youTubeHomePage.SearchShort();

            Thread.Sleep(5000);

            CleanUp();
        }
        

    }
}
