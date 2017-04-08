using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoSiteLivro.Pages
{
    public class HomePage
    {
        public void GoTo()
        {
            Driver.Initialize();
            Driver.Instance.Navigate().GoToUrl("http://www.lojaexemplodelivros.com.br/");
        }
    }
}
