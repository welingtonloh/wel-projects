using CatalogoDeProdutos.Dominio.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CatalogoDeProdutos.Infra.Repositorios.EF
{
    public class CatalogoDeProdutosContexto : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Imagem> Imagens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new ImagemMap());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
