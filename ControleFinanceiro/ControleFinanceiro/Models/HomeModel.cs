using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleFinanceiro.Models
{
    public class HomeModel : Transacao
    {
        internal Transacao ConverterParaTransacao()
        {
            var transacao = new Transacao
            {
                CpfCnpj = this.CpfCnpj,
                Data = this.Data,
                DeduzDoImpostoDeRenda = this.DeduzDoImpostoDeRenda,
                Descricao = this.Descricao,
                Id = this.Id,
                Importancia = this.Importancia,
                Opcao = this.Opcao,
                Valor = this.Valor
            };

            return transacao;
        }

        public List<SelectListItem> Opcoes { get; set; }
        public List<SelectListItem> Importancias { get; set; }
    }
}