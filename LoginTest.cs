using NUnit.Framework;
using mark7.Common;
using System;

namespace Tests
{
    public class LoginTest: BaseTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("gomes@mail.com","abc123","Incorrect password")]
        [TestCase("404@papito.io","pwd123","User not found")]
        [TestCase("eu@papito.io","abc123","Incorrect password")]
        [TestCase("","pwd123","Email is required")]  
        [TestCase("gomes@mail.com","","Password is requerid")]  
        public void TentarLogar(string email, string senha, string msg)
        {
             loginPage.Logar(email, senha);
             Assert.AreEqual(msg, loginPage.Notificacao().Text);

        }

        [Test]
        public void DeveAutenticarUsuario()
        {
            loginPage.Logar("gomes@mail.com","pwd123");
            //Console.Write(taskPage.BemVindo().Text);
            Assert.AreEqual("Olá, Carlos Gomes", taskPage.BemVindo().Text);
        }
    }
}