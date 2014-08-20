using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleFinanceiro.Models
{
    public class SaidaModel : Transacao
    {
        internal List<SaidaModel> ConverterParaSaida(List<Transacao> result)
        {
            var saidas = result.Select(t => new SaidaModel
            {
                CpfCnpj = t.CpfCnpj,
                Data = t.Data,
                DeduzDoImpostoDeRenda = t.DeduzDoImpostoDeRenda,
                Descricao = t.Descricao,
                Id = t.Id,
                Importancia = t.Importancia,
                Opcao = t.Opcao,
                Valor = t.Valor
            }).ToList();

            return saidas;
        }
    }
}