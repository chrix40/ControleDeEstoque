using ControleEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleEstoque.Controllers
{
    public class CadastroController : Controller
    {
        private static List<GrupoProdutoModel> _ListaGrupoProduto = new List<GrupoProdutoModel>()
        {
            new GrupoProdutoModel() {Id=1, Nome="Livros", Ativo=true },
            new GrupoProdutoModel() {Id=2, Nome="Mouse Razor", Ativo=true },
            new GrupoProdutoModel() {Id=3, Nome="Monitores", Ativo=false },
            new GrupoProdutoModel() {Id=4, Nome="Iphones", Ativo=true },

        };

        [Authorize]
        public ActionResult GrupoProduto()
        {
            return View(_ListaGrupoProduto);
        }

        [HttpPost]
        [Authorize]
        public ActionResult RecuperarGrupoProduto(int id)
        {
            return Json(_ListaGrupoProduto.Find(x => x.Id == id));
        }

        [HttpPost]
        [Authorize]
        public ActionResult ExcluirGrupoProduto(int id)
        {
            var ret = false;
            var registoBD = _ListaGrupoProduto.Find(x => x.Id == id);
            if (registoBD != null)
            {
                _ListaGrupoProduto.Remove(registoBD);
            }
            return Json(ret);
        }

        [HttpPost]
        [Authorize]
        public ActionResult SalvarGrupoProduto(GrupoProdutoModel model)
        {
            var registoBD = _ListaGrupoProduto.Find(x => x.Id == model.Id);

            if (registoBD == null)
            {
                registoBD = model;
                registoBD.Id = _ListaGrupoProduto.Max(x => x.Id) + 1;
                _ListaGrupoProduto.Add(registoBD);
            }
            else
            {
                registoBD.Nome = model.Nome;
                registoBD.Ativo = model.Ativo;
            }
            return Json(registoBD);
        }

        [Authorize]
        public ActionResult MarcaProduto()
        {
            return View();
        }
        [Authorize]
        public ActionResult LocalProduto()
        {
            return View();
        }
        [Authorize]
        public ActionResult UnidadeMedida()
        {
            return View();
        }
        [Authorize]
        public ActionResult Produto()
        {
            return View();
        }
        [Authorize]
        public ActionResult Pais()
        {
            return View();
        }
        [Authorize]
        public ActionResult Estado()
        {
            return View();
        }
        [Authorize]
        public ActionResult Cidade()
        {
            return View();
        }
        [Authorize]
        public ActionResult Fornecedor()
        {
            return View();
        }
        [Authorize]
        public ActionResult PerfilUsuario()
        {
            return View();
        }
        [Authorize]
        public ActionResult Usuario()
        {
            return View();
        }
    }
}