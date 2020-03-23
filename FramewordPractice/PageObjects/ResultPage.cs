using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FramewordPractice.PageObjects
{
    class ResultPage
    {
        private IWebDriver driver;

        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.PartialLinkText, Using = "Selenium C# and NUnit Pain Free Start Guide")]
        private IWebElement firstArticle;

        public void clickOnFirstArticle()
        {
            firstArticle.Click();
        }
    }
}
