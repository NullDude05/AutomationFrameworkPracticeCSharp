using FramewordPractice.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestClass
{
    public static class TestClass
    {
        public static IWebDriver driver;

        [SetUp]
        public static void startBrowser()
        {
            //ChromeOptions chromeoptions = new ChromeOptions();
            //chromeoptions.AddArgument("start-maximized");

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public static void test()
        {
            HomePage home = new HomePage(driver);
            home.goToPage();
            AboutPage about = home.goToAboutPage();
            ResultPage result = about.search("selenium c#");
            Thread.Sleep(5000);
            result.clickOnFirstArticle();

            //driver.Navigate().GoToUrl("http://google.com");
            //Thread.Sleep(5000);
            //driver.Url = "http://www.google.com";
        }

        [TearDown]
        public static void closeBrowser()
        {
            driver.Close();
        }

    }
}