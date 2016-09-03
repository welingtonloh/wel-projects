using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CatalogoDeProdutos.Infra.Repositorios.EF
{
    public class GerenciadorContexto
    {
        private const string ChaveContexto = "GerenciadorContexto.Contexto";

        public CatalogoDeProdutosContexto Contexto
        {
            get
            {
                if (HttpContext.Current.Items[ChaveContexto] == null)
                {
                    HttpContext.Current.Items[ChaveContexto] = new CatalogoDeProdutosContexto();
                }

                return (CatalogoDeProdutosContexto)HttpContext.Current.Items[ChaveContexto];
            }
        }
    }
}
