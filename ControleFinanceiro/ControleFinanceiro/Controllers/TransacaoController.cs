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
            var Entradas = BO.Search(t => true/*t => t.Opcao == TipoOpcao.Entrada*/).OrderBy(t => t.Data);

            var result = Entradas.ToList();

            return View(result);
        }

        public ActionResult Saida()
        {
            return View();
        }

        public ActionResult CadastrarTransacao(HomeModel home)
        {
            var transacao = home.ConverterParaTransacao();

            BO.Add(transacao);
            
            return RedirectToAction("Index", "Home");
        }
    }
}
