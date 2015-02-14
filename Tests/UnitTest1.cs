using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Go_To_HomePage()
        {
            Pages.HomePage.Goto();
            Assert.IsTrue(Pages.HomePage.IsAt());
        }

        [TestMethod]
        public void Can_Go_To_Author_Page()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.SelectAuthor("Matt Milner");
            Assert.IsTrue(Pages.HomePage.IsAtAuthorPage("Matt Milner"));
        }

        [TestCleanup]
        public void CleanUp()
        {
            Browser.Close();
        }

    }
}
