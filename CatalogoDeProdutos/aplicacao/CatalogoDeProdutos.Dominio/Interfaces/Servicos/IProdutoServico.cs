using CatalogoDeProdutos.Dominio.Entidades;
using CatalogoDeProdutos.Dominio.Enums;
using System.Collections.Generic;

namespace CatalogoDeProdutos.Dominio.Interfaces
{
    public interface IProdutoServico
    {
        void Adicionar(Produto produto);

        IEnumerable<Produto> Listar();

        IEnumerable<Produto> Filtrar(Categorias categoria, SubCategorias subcategoria);
    }
}
