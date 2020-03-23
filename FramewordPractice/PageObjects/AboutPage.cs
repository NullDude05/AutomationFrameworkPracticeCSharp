using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FramewordPractice.PageObjects
{
    class AboutPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public AboutPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "input[class='s']")]
        private IWebElement searchText;

        [FindsBy(How = How.CssSelector, Using = "a[class='fusion-main-menu-icon fusion-bar-highlight']")]
        private IWebElement seachButton;

        public ResultPage search(string text)
        {
            seachButton.Click();
            searchText.SendKeys(text);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input[class='fusion-search-submit searchsubmit']"))).Click();
            return new ResultPage(driver);
        }
    }
}
