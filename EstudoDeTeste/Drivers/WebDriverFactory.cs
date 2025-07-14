using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class WebDriverFactory
{
    public static IWebDriver CriarChrome()
    {
        var options = new ChromeOptions();
        options.AddArgument("--disable-notifications");  // Opcional: desabilita notificações
        options.AddArgument("--start-maximized");       // Tenta maximizar ao iniciar

        // Inicia o ChromeDriver com as opções
        IWebDriver driver = new ChromeDriver(options);

        // Maximiza a janela explicitamente após a inicialização
        driver.Manage().Window.Maximize();

        return driver;
    }
}
