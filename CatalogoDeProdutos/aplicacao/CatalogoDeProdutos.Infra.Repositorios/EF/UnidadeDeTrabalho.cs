using CatalogoDeProdutos.Dominio.Interfaces;
using Microsoft.Practices.ServiceLocation;
using System.Data.Entity;

namespace CatalogoDeProdutos.Infra.Repositorios.EF
{
    public class UnidadeDeTrabalho : IUnidadeDeTrabalho
    {
        private DbContext _contexto;
        public void EfetivarTransacao()
        {
            _contexto.SaveChanges();
        }

        public void IniciarTransacao()
        {
            var gerenciadorContexto = ServiceLocator.Current.GetInstance<GerenciadorContexto>();
            _contexto = gerenciadorContexto.Contexto;
        }
    }
}
