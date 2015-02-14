using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public static class Pages
    {
        public static HomePage HomePage
        {
            get 
            { 
                var homePage = new HomePage();
                PageFactory.InitElements(Browser.Driver, homePage);
                return homePage;
            }
        }
    }
    
    
}
