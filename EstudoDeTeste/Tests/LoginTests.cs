using EstudoDeTeste;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using EstudoDeTeste.Data;

namespace EstudoDeTeste.Tests
{
    public class LoginTests
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void LoginComCredenciaisValidas_DeveExibirMensagemDeSucesso()
        {
            // Acessa a página de login
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

            // Realiza o login com usuário e senha válidos
            var loginPage = new LoginPage(driver);
            loginPage.RealizarLogin( DadosLogin.UsuarioValido, DadosLogin.SenhaValida);

            // Verifica se a mensagem de sucesso apareceu após o login
            Assert.IsTrue(loginPage.MensagemDeSucessoVisivel(), "Mensagem de sucesso não apareceu após o login.");
        }

        [Test]
        public void LoginComUsuarioInvalido_DeveExibirMensagemDeErro()
        {
            // Acessa a página de login
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

            // Realiza o login com usuário e senha válidos
            var loginPage = new LoginPage(driver);
            loginPage.RealizarLogin(DadosLogin.UsuarioInvalido, DadosLogin.SenhaValida);

            // Verifica se a mensagem de sucesso não apareceu após o login
            Assert.IsTrue(loginPage.MensagemDeErroVisivel(), "Mensagem de erro não foi exibida após o login inválido.");
        }

        [Test]
        public void LoginComSenhaInvalida_DeveExibirMensagemDeErro()
        {
            // Acessa a página de login
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

            // Realiza o login com usuário e senha válidos
            var loginPage = new LoginPage(driver);
            loginPage.RealizarLogin(DadosLogin.UsuarioValido, DadosLogin.SenhaInvalida);

            // Verifica se a mensagem de sucesso não apareceu após o login
            Assert.IsTrue(loginPage.MensagemDeErroVisivel(), "Mensagem de erro não foi exibida após o login inválido.");
        }

        [Test]
        public void LoginComCredenciaisInvalidas_DeveExibirMensagemDeErro()
        {
            // Acessa a página de login
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

            // Realiza o login com usuário e senha válidos
            var loginPage = new LoginPage(driver);
            loginPage.RealizarLogin(DadosLogin.UsuarioInvalido, DadosLogin.SenhaInvalida);

            // Verifica se a mensagem de sucesso não apareceu após o login
            Assert.IsTrue(loginPage.MensagemDeErroVisivel(), "Mensagem de erro não foi exibida após o login inválido.");
        }

        [Test]
        public void Logout_DeveExibirMensagemDeSucesso()
        {
            // Acessa a página de login
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

            // Realiza o login com usuário e senha válidos
            var loginPage = new LoginPage(driver);
            loginPage.RealizarLogin(DadosLogin.UsuarioValido, DadosLogin.SenhaValida);

            // Verifica se a mensagem de sucesso apareceu após o login
            Assert.IsTrue(loginPage.MensagemDeSucessoVisivel(), "Mensagem de sucesso não apareceu após o login.");

            // Realiza o logout do usuário
            var logoutPage = new LoginPage(driver);
            logoutPage.RealizarLogout();

            // Verifica se a mensagem de sucesso apareceu após o logout
            Assert.IsTrue(loginPage.MensagemDeSucessoVisivel(), "Mensagem de sucesso não apareceu após o logout.");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
