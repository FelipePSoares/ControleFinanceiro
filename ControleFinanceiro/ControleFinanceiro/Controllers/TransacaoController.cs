using ControleFinanceiro.App_Start;
using ControleFinanceiro.Models;
using DomainService;
using DomainService.Contracts;
using Entities;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleFinanceiro.Controllers
{
    public class TransacaoController : Controller
    {
        public ITransacaoBO BO { get; set; }

        public TransacaoController()
        {
            BO = SimpleInjectorInitializer.Container.GetInstance<TransacaoBO>();
        }

        public ActionResult Entrada()
        {
            var transacoes = BO.Search(t => t.Opcao == TipoOpcao.Entrada).OrderBy(t => t.Data);
            var entradas = new EntradaModel().ConverterParaEntrada(transacoes.ToList());

            return View(entradas);
        }

        public ActionResult Saida()
        {
            var transacoes = BO.Search(t => t.Opcao == TipoOpcao.Saída).OrderBy(t => t.Data);
            var saidas = new SaidaModel().ConverterParaSaida(transacoes.ToList());

            return View(saidas);
        }

        public ActionResult CadastrarTransacao(HomeModel home)
        {
            var transacao = home.ConverterParaTransacao();

            BO.Add(transacao);
            
            return RedirectToAction("Index", "Home");
        }
    }
}
