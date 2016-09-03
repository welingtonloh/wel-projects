using CatalogoDeProdutos.Dominio;
using CatalogoDeProdutos.Dominio.Entidades;
using CatalogoDeProdutos.Dominio.Enums;
using System.ComponentModel.DataAnnotations;

namespace CatalogoDeProdutos.UI.ViewModels
{
    public class ProdutoViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Produto")]
        public string Nome { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Informações adicionais")]
        public string InformacoesAdicionais { get; set; }

        [Display(Name = "Categoria")]
        public Categorias Categoria { get; set; }

        [Display(Name = "SubCategoria")]
        public SubCategorias SubCategoria { get; set; }

        public Imagem Imagem { get; set; }
    }
}