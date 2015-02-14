using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public class HomePage
    {

        static string Url = "http://pluralsight.com";
        private static string PageTitle = "Pluralsight – Hardcore Developer and IT Training";

        [FindsBy(How = How.Id, Using = "ui-authors")]
        private IWebElement idLink;

        public void Goto()
        {
            Browser.Goto(Url);
        }

        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        public void SelectAuthor(string authorName)
        {
            idLink.Click();
            var author = Browser.Driver.FindElement(By.LinkText(authorName));
            author.Click();
        }

        public bool IsAtAuthorPage(string authorName)
        {
            var authorPage = new AuthorPage();
            PageFactory.InitElements(Browser.Driver, authorPage);
            return authorPage.AuthorName == authorName;

        }
    }
}
