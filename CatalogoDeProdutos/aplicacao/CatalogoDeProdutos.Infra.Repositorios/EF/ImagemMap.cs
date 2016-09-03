using CatalogoDeProdutos.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace CatalogoDeProdutos.Infra.Repositorios.EF
{
    public class ImagemMap : EntityTypeConfiguration<Imagem>
    {
        public ImagemMap()
        {
            
        }
    }
}
