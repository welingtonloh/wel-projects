using CatalogoDeProdutos.Dominio.Enums;
using System.Collections.Generic;

namespace CatalogoDeProdutos.Dominio.Entidades
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string Descricao { get; set; }

        public string InformacoesAdicionais { get; set; }

        public Categorias Categoria { get; set; }

        public SubCategorias SubCategoria { get; set; }

        public virtual Imagem Imagem { get; set; }
    }
}
