using System;
using TechTalk.SpecFlow;

namespace ProjetoSiteLivro...
{
    [Binding]
    public class CarrinhoDeComprasSteps
    {
        [Given(@"informei o noreply@minutrade\.com\.br e minutrade")]
        public void GivenInformeiONoreplyMinutrade_Com_BrEMinutrade()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
