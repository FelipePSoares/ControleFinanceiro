using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using FluentAssertions;
using ControleFinanceiro.Models;
using OpenQA.Selenium.Firefox;


namespace ControleFinanceiro.Tests.SpecFlow.Steps
{
    [Binding]
    [Scope(Feature = "Home")]
    public class HomeSteps
    {
        #region [ model ]

        private HomeModel homeEntrada = new HomeModel();

        #endregion

        [When(@"Acessar a home (.*)")]
        public void QuandoAcessarAHome(string site)
        {
            Eventos.Selenium.Navigate().GoToUrl(site);
        }

        [When(@"estiver logado")]
        public void QuandoEstiverLogado()
        {
            ScenarioContext.Current.Pending();
        }

        #region [ Dados de entrada ]

        [Given(@"a opção (.*)")]
        public void DadoAOpcao(string opcao)
        {
            ComboBoxElemento select = new ComboBoxElemento(Eventos.Selenium.FindElementById("Opcao"));
            select.SelecionarValor(opcao);
        }
        
        [Given(@"a descrição (.*)")]
        public void DadoADescricao(string descricao)
        {
            var element = Eventos.Selenium.FindElementById("Descricao");
            element.SendKeys(descricao);
        }
        
        [Given(@"Valor (.*)")]
        public void DadoValor(Decimal valor)
        {
            var element = Eventos.Selenium.FindElementById("Valor");
            element.SendKeys(valor.ToString());
        }
        
        [Given(@"a data (.*)")]
        public void DadoAData(string data)
        {
            var element = Eventos.Selenium.FindElementById("Data");
            element.SendKeys(data);
        }

        [Given(@"a importancia (.*)")]
        public void DadoAImportancia(string importancia)
        {
            ComboBoxElemento select = new ComboBoxElemento(Eventos.Selenium.FindElementById("Importancia"));
            select.SelecionarValor(importancia);
        }

        [Given(@"e tiver saldo")]
        public void DadoETiverSaldo()
        {
            ScenarioContext.Current.Pending();
        }

        #endregion

        #region [ Ação ]

        [Given(@"clicar em cadastrar")]
        public void DadoClicarEmCadastrar()
        {
            Eventos.Selenium.FindElementById("Cadastrar").Click();
        }

        [Then(@"clicar em Últimas Saídas")]
        public void EntaoClicarEmUltimasSaidas()
        {
            Eventos.Selenium.FindElementById("UltimasSaidas").Click();
        }

        [Then(@"clicar em Últimas Entradas")]
        public void EntaoClicarEmUltimasEntradas()
        {
            Eventos.Selenium.FindElementById("UltimasEntradas").Click();
        }

        #endregion

        #region [ Validação ]

        [Then(@"Deve aparecer a mensagem (.*)")]
        public void EntaoDeveAparecerAMensagem(string mensagem)
        {
            var element = Eventos.Selenium.FindElementById("mensagem");
            element.Text.Should().Be(mensagem);
        }
        
        [Then(@"o último registro ter os dados de entrada")]
        public void EntaoOUltimoRegistroTerOsDadosDeEntrada()
        {
            var element = Eventos.Selenium.FindElementById("mensagem");
        }

        #endregion
    }
}
