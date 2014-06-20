﻿using ControleFinanceiro.App_Start;
using ControleFinanceiro.Models;
using DomainService;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleFinanceiro.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        //
        // POST: /Home/

        public ActionResult CadastrarTransacao(HomeModel home)
        {
            var bo = SimpleInjectorInitializer.Container.GetInstance<TransacaoBO>();

            bo.repository.add<Transacao>(home);

            return View();
        }
    }
}
