using CatalogoDeProdutos.Dominio.Interfaces;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoDeProdutos.Aplicacao
{
    public class AplicacaoBase
    {
        private IUnidadeDeTrabalho _unidadeDeTrabalho;

        public void IniciarTransacao()
        {
            _unidadeDeTrabalho = ServiceLocator.Current.GetInstance<IUnidadeDeTrabalho>();
            _unidadeDeTrabalho.IniciarTransacao();
        }

        public void EfetivarTransacao()
        {
            _unidadeDeTrabalho.EfetivarTransacao();
        }
    }
}
