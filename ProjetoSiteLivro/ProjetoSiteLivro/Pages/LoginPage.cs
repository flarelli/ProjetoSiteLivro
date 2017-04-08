using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using ProjetoSiteLivro.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoSiteLivro.Pages
{
    public class LoginPage
    {

        public void GoToLogin()
        {
            var entrar = Driver.Instance.FindElement(By.XPath("html/body/div[1]/div/div[1]/div/div/ul/li[5]/a"));
            entrar.Click();
        }
        public void Login(string email, string senha)
        {
            var loginImput = Driver.Instance.FindElement(By.Id("email"));
            loginImput.SendKeys(email);

            var passwordImput = Driver.Instance.FindElement(By.Id("pass"));
            passwordImput.SendKeys(senha);
        }
        public void ClickLogin()
        {
            var loginButton = Driver.Instance.FindElement(By.Id("send2"));
            loginButton.Click();
        }




    }
}


