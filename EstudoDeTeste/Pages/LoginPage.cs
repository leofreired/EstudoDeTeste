using OpenQA.Selenium;

namespace EstudoDeTeste.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        public void PreencherUsuario(string usuario)
        {
            driver.FindElement(By.Id("username")).SendKeys(usuario);
        }

        public void PreencherSenha(string senha)
        {
            driver.FindElement(By.Id("password")).SendKeys(senha);
        }

        public void ClicarLogin()
        {
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();
        }

        public bool MensagemDeSucessoVisivel()
        {
            return driver.PageSource.Contains("You logged into a secure area!");
        }

        public bool MensagemDeErroVisivel()
        {
            return driver.PageSource.Contains("Your password is invalid!")
                || driver.PageSource.Contains("Your username is invalid!");
        }

        public void RealizarLogin(string usuario, string senha)
        {
            PreencherUsuario(usuario);
            PreencherSenha(senha);
            ClicarLogin();
        }
    }
}
