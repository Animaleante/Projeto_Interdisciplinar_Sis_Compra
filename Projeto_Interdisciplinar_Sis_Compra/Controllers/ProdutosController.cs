using Projeto_Interdisciplinar_Sis_Compra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto_Interdisciplinar_Sis_Compra.Controllers
{
    public class ProdutosController : Controller
    {
        private EFContext context = new EFContext();
        // GET: Produtos
        public ActionResult Index()
        {
            return View(/*context.Produtos.OrderBy(p => p.Nome)*/);
        }
    }
}