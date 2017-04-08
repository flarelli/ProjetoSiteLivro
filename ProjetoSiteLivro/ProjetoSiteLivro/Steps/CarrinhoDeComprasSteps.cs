using OpenQA.Selenium;
using TechTalk.SpecFlow;
using ProjetoSiteLivro.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjetoSiteLivro.Steps
{
    [Binding]
    public class CarrinhoDeComprasSteps
    {
        LoginPage pagelogin = new LoginPage();
        HomePage pagehome = new HomePage();
        ListarLivrosPage pagelistarlivros = new ListarLivrosPage();
        CarrinhoDeComprasPage pagecarrinhodecompras = new CarrinhoDeComprasPage();

        [Given(@"entrei na tela home do site Loja Livros")]
        public void GivenEntreiNaTelaHomeDoSiteLojaLivros()
        {
            pagehome.GoTo();            
        }

        [Given(@"cliquei no item Entrar no menu horizontal do topo")]
        public void GivenCliqueiNoItemEntrarNoMenuHorizontalDoTopo()
        {
            pagelogin.GoToLogin();
        }

        [Given(@"informei o (.*) e (.*)")]
        public void GivenInformeiOEmail(string email, string senha)
        {
            //System.Threading.Thread.Sleep(2000);
            pagelogin.Login(email, senha);
            
        }

        [Given(@"cliquei no botao Entrar")]
        public void GivenCliqueiNoBotaoEntrar()
        {
            pagelogin.ClickLogin();

        }
        [Given(@"cliquei no menu Livros")]
        public void GivenCliqueiNoMenuLivros()
        {
            pagelistarlivros.AcessarMenuLivros();
        }
        [Given(@"cliquei no submenu Informatica")]
        public void GivenCliqueinoSubmenuInformatica()
        {
            pagelistarlivros.AcessarSubMenuInformatica();
        }
        [Given(@"cliquei no item do submenu Java")]
        public void GivenCliqueiNoItemDoSumenuJava()
        {
            pagelistarlivros.AcessarSubMenuJava();
        }
        [Given(@"cliquei no comprar do livro Use a Cabeca Java")]
        public void GivenCliqueiNoComprarDoLivroUseACabecaJava()
        {
            pagelistarlivros.BntComprarProdutoUseACabecaJava();
        }
        [Given(@"atualizei a quantidade do produto Use a Cabeca Java")]
        public void GivenAtualizeiAQuantidadeDoProdutoUseACabecaJava()
        {
            pagecarrinhodecompras.AtualizarValorQtde();
            pagecarrinhodecompras.BntAtualizarCarrinho();
        }
        [Given(@"cliquei no botão Continuar Comprando")]
        public void GivenCliqueiNoBotaoContinuarComprando()
        {
            var quantidade = pagecarrinhodecompras.RetornarQuantidade();
            pagecarrinhodecompras.BntContinuarComprando();           

        }
        [When(@"cliquei no comprar do livro Use a Cabeca Java")]
        public void WhenCliqueiNoComprarDoLivroUseACabecaJava()
        {
            pagelistarlivros.BntComprarProdutoUseACabecaJava();
        }
        [Then(@"exibe a quantidade (.*) no carrinho de compras para o livro Use a Cabeca Java")]
        public void ThenExibeAQuantidadeNoCarrinhoDeComprasParaOLivroUseACabecaJava(int valor)
        {
            if(valor == 2)
            {
                System.Console.WriteLine("Foi incrementado um valor na quantidade para o mesmo produto");
            }
            else
            {
                System.Console.WriteLine("Não foi incrementado um valor na quantidade para o mesmo produto");
            }

            Driver.Close();
        }
    }
}

