using CatalogoDeProdutos.Aplicacao.Interfaces;
using System.Web.Mvc;

namespace CatalogoDeProdutos.UI.Controllers
{
    public class ImagemController : Controller
    {
        private readonly IImagemAplicacaoServico _imagemAplicacao;

        public ImagemController(IImagemAplicacaoServico imagemAplicacao)
        {
            _imagemAplicacao = imagemAplicacao;
        }

        public ActionResult Exibir(int id)
        {
            var imagem = _imagemAplicacao.Buscar(1);
            return File(imagem.Arquivo, "image/jpg");
        }
    }
}