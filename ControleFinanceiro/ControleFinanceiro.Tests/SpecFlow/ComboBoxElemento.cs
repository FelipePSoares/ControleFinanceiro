using Entities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleFinanceiro.Tests.SpecFlow.Steps
{
    public class ComboBoxElemento
    {
        private IWebElement elemento;

        public ComboBoxElemento (IWebElement elemento)
	    {
            this.elemento = elemento;
        }

        public void SelecionarValor(String ValorASelecionar)
        {
            var selecionar = ValorASelecionar.ToUpper() == "ENTRADA" ? TipoOpcao.Entrada : TipoOpcao.Saída;
            var all_options = elemento.FindElements(By.TagName("option"));
            foreach (var option in all_options)
	        {
                var valor = Convert.ToInt32(option.GetAttribute("value"));
                if (valor == (Int32)selecionar)
                    option.Click();
            }
        }
    }
}
