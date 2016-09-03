using CatalogoDeProdutos.Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace CatalogoDeProdutos.Dominio.Interfaces.Repositorios
{
    public interface IProdutoRepositorio
    {
        void Adicionar(Produto produto);

        IEnumerable<Produto> Listar();

        IEnumerable<Produto> Filtrar(List<Predicate<Produto>> especificacoes);
    }
}
