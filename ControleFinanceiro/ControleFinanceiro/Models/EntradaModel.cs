using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleFinanceiro.Models
{
    public class EntradaModel : Transacao
    {
        internal List<EntradaModel> ConverterParaEntrada(List<Transacao> result)
        {
            var entradas = result.Select(t => new EntradaModel
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

            return entradas;
        }
    }
}