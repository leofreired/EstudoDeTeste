using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

public class LoginPage
{
    private readonly IWebDriver driver;
    private WebDriverWait wait;

    public LoginPage(IWebDriver webDriver)
    {
        driver = webDriver;
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));  // 10 segundos de timeout
    }

    public void PreencherUsuario(string usuario)
    {
        var campoUsuario = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("username")));
        campoUsuario.SendKeys(usuario);
    }

    public void PreencherSenha(string senha)
    {
        var campoSenha = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("password")));
        campoSenha.SendKeys(senha);
    }

    public void ClicarLogin()
    {
        var botaoLogin = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("button[type='submit']")));
        botaoLogin.Click();
    }

    public void RealizarLogin(string usuario, string senha)
    {
        PreencherUsuario(usuario);
        PreencherSenha(senha);
        ClicarLogin();
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
}
