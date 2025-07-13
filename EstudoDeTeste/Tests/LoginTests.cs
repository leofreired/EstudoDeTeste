using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using EstudoDeTeste.Pages;
using System;

namespace EstudoDeTeste.Tests
{
    [TestFixture]
    public class LoginTests
    {
        private IWebDriver driver;
        private LoginPage loginPage;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://practice.expandtesting.com/login");
            loginPage = new LoginPage(driver);
        }

        [Test]
        public void LoginComCredenciaisValidas_DeveExibirMensagemDeSucesso()
        {
            loginPage.RealizarLogin("practice", "SuperSecretPassword!");
            Assert.IsTrue(loginPage.MensagemDeSucessoVisivel());
        }

        [Test]
        public void LoginComCredenciaisInvalidas_DeveExibirMensagemDeErro()
        {
            loginPage.RealizarLogin("practice", "senhaErrada");
            Assert.IsTrue(loginPage.MensagemDeErroVisivel());
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
