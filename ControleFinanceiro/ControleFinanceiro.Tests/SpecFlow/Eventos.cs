using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using System;

namespace ControleFinanceiro.Tests.SpecFlow
{
    [Binding]
    public static class Eventos
    {
        public static FirefoxDriver Selenium;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Selenium = new FirefoxDriver();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Selenium.Quit();
        }
    }
}
