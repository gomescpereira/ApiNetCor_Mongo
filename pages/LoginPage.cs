using OpenQA.Selenium;

namespace mark7.Pages
{
    public class LoginPage
    {

        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Logar(string email, string senha)
        {
            _driver.FindElement(By.CssSelector("input[name=email]")).SendKeys(email);
            _driver.FindElement(By.CssSelector("input[name=password]")).SendKeys(senha);
            _driver.FindElement(By.ClassName("loginButton")).Click();
        }

        public IWebElement Notificacao()
        {
            return _driver.FindElement(By.CssSelector(".alert-login div"));
        }

    }
}
