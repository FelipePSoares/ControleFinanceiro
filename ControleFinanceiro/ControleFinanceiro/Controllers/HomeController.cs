using ControleFinanceiro.App_Start;
using ControleFinanceiro.Models;
using DomainService;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace ControleFinanceiro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var home = new HomeModel()
            {
                Opcoes = PegarListaEnum(typeof(TipoOpcao)),
                Importancias = PegarListaEnum(typeof(TipoImportancia))
            };

            return View(home);
        }

        private List<SelectListItem> PegarListaEnum(Type type)
        {
            var list = new List<SelectListItem>();
            var valores = Enum.GetValues(type);

            foreach (var value in valores)
                list.Add(new SelectListItem { Value = ((int)value).ToString(), Text = GetEnumDescription((Enum)value) });

            return list;
        }

        public string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }
}
