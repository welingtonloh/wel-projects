using CatalogoDeProdutos.Dominio.Entidades;
using CatalogoDeProdutos.Dominio.Enums;
using System.Collections.Generic;

namespace CatalogoDeProdutos.Aplicacao.Interfaces
{
    public interface IProdutoAplicacaoServico
    {
        IEnumerable<Produto> Listar();

        IEnumerable<Produto> Filtrar(Categorias categoria, SubCategorias subcategoria);

        void Adicionar(Produto produto); 
    }
}
