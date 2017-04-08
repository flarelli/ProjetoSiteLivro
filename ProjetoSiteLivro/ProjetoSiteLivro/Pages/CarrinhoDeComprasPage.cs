using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoSiteLivro.Pages
{
    public class CarrinhoDeComprasPage
    {
        public void AtualizarValorQtde()
        {
            var valor = Driver.Instance.FindElement(By.XPath(".//*[@id='shopping-cart-table']/tbody/tr/td[5]/input"));
            valor.Clear();
            valor.SendKeys("1");
        }
        public void BntAtualizarCarrinho()
        {
            Driver.Instance.FindElement(By.XPath(".//*[@id='shopping-cart-table']/tfoot/tr/td/button[2]")).Click();
        }
        public void BntContinuarComprando()
        {
            var loginButton = Driver.Instance.FindElement(By.XPath(".//*[@id='shopping-cart-table']/tfoot/tr/td/button[1]"));
            loginButton.Click();
        }
        public String RetornarQuantidade()
        {
            Driver.Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            var quantidade = Driver.Instance.FindElement(By.XPath(".//*[@class='input-text qty']"));
            quantidade.Click();
            return quantidade.GetAttribute("value");

        }
    }
}
