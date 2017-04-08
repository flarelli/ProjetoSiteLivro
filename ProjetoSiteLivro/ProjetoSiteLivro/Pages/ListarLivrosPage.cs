using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoSiteLivro.Pages
{
 
    public class ListarLivrosPage
    {
        public static bool IsAt
        {
            get
            {
                var h2s = Driver.Instance.FindElements(By.XPath("html/body/div[1]/div/div[1]/div/div/ul/li[5]/a"));
                if (h2s.Count > 0)
                    return h2s[0].Text == "Sair";
                return false;
            }
        }

        public void AcessarMenuLivros()
        {
            var loginButton = Driver.Instance.FindElement(By.XPath(".//*[@id='nav']/li[2]/a/span"));
            loginButton.Click();
        }
        public void AcessarSubMenuInformatica()
        {
            var loginButton = Driver.Instance.FindElement(By.XPath(".//*[@id='narrow-by-list']/dd[1]/ol/li[2]/a"));
            loginButton.Click();
        }
        public void AcessarSubMenuJava()
        {
            var loginButton = Driver.Instance.FindElement(By.XPath(".//*[@id='narrow-by-list']/dd[1]/ol/li[1]/a"));
            loginButton.Click();
        }
        public void BntComprarProdutoUseACabecaJava()
        {
            var loginButton = Driver.Instance.FindElement(By.XPath("html/body/div[1]/div/div[3]/div/div[2]/div[3]/ul/li[1]/div[2]/button"));
            loginButton.Click();
        }
    }
   
}
