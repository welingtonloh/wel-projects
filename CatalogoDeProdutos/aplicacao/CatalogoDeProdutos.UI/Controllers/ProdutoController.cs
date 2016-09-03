using AutoMapper;
using CatalogoDeProdutos.Aplicacao.Interfaces;
using CatalogoDeProdutos.Dominio.Entidades;
using CatalogoDeProdutos.Dominio.Enums;
using CatalogoDeProdutos.UI.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CatalogoDeProdutos.UI.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoAplicacaoServico _produtoAplicacao;
        
        public ProdutoController(IProdutoAplicacaoServico produtoAplicacao)
        {
            _produtoAplicacao = produtoAplicacao;
        }

        public ActionResult Index()
        {
            IEnumerable<ProdutoViewModel> produtos = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoAplicacao.Listar());
            return View(produtos);
        }

        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _produtoAplicacao.Adicionar(produto);
                return RedirectToAction("index");
            }

            return View(produto);
        }

        public ActionResult Filtrar(Categorias categoria, SubCategorias subcategoria)
        {
            IEnumerable<ProdutoViewModel> produtos = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoAplicacao.Filtrar(categoria, subcategoria));
            return View("Index", produtos);
        }
    }
}