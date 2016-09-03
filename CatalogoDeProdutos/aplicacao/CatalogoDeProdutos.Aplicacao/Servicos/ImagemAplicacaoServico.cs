using CatalogoDeProdutos.Aplicacao.Interfaces;
using CatalogoDeProdutos.Dominio.Entidades;
using CatalogoDeProdutos.Dominio.Interfaces;

namespace CatalogoDeProdutos.Aplicacao
{
    public class ImagemAplicacaoServico : AplicacaoBase, IImagemAplicacaoServico
    {
        private readonly IImagemServico _imagemServico;

        public ImagemAplicacaoServico(IImagemServico imagemServico)
        {
            _imagemServico = imagemServico;
        }

        public Imagem Buscar(int id)
        {
            return _imagemServico.Buscar(id);
        }
    }
}
