using CatalogoDeProdutos.Aplicacao;
using CatalogoDeProdutos.Aplicacao.Interfaces;
using CatalogoDeProdutos.Dominio.Interfaces;
using CatalogoDeProdutos.Dominio.Interfaces.Repositorios;
using CatalogoDeProdutos.Dominio.Servicos;
using CatalogoDeProdutos.Infra.Repositorios;
using CatalogoDeProdutos.Infra.Repositorios.EF;
using Ninject.Modules;

namespace CatalogoDeProdutos.Infra.IoC
{
    public class IoCModulo : NinjectModule
    {
        public override void Load()
        {
            Bind<GerenciadorContexto>().ToSelf();
            Bind<IUnidadeDeTrabalho>().To<UnidadeDeTrabalho>();

            Bind<IProdutoAplicacaoServico>().To<ProdutoAplicacaoServico>();
            Bind<IProdutoServico>().To<ProdutoServico>();
            Bind<IProdutoRepositorio>().To<ProdutoRepositorio>();
        }
    }
}
