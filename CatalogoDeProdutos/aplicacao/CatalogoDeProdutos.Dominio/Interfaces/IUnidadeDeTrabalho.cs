using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoDeProdutos.Dominio.Interfaces
{
    public interface IUnidadeDeTrabalho
    {
        void IniciarTransacao();

        void EfetivarTransacao();
    }
}
