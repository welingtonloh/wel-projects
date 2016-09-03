using CatalogoDeProdutos.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace CatalogoDeProdutos.Infra.Repositorios.EF
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            Property(x => x.Nome).IsRequired().HasMaxLength(100);
            Property(x => x.Preco).IsRequired().HasPrecision(10, 2);

            this.HasOptional<Imagem>(x => x.Imagem)
                .WithMany(x => x.Produtos);
        }
    }
}
