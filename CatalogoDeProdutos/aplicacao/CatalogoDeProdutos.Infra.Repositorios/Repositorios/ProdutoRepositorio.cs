using CatalogoDeProdutos.Dominio;
using CatalogoDeProdutos.Dominio.Entidades;
using CatalogoDeProdutos.Dominio.Interfaces.Repositorios;
using CatalogoDeProdutos.Infra.Repositorios.EF;
using Microsoft.Practices.ServiceLocation;
using System.Collections.Generic;
using System.Linq;
using System;

namespace CatalogoDeProdutos.Infra.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        protected CatalogoDeProdutosContexto Contexto { get; private set; }

        public ProdutoRepositorio()
        {
            var gerenciadorContexto = ServiceLocator.Current.GetInstance<GerenciadorContexto>();
            Contexto = gerenciadorContexto.Contexto;
        }

        public void Adicionar(Produto produto)
        {
            Contexto.Produtos.Add(produto);
        }

        public IEnumerable<Produto> Listar()
        {
            return Contexto.Produtos.ToList().OrderBy(c => c.Nome);
        }

        public IEnumerable<Produto> Filtrar(List<Predicate<Produto>> especificacoes)
        {
            var produtos = Contexto.Produtos.ToList();

            foreach (var especificacao in especificacoes)
            {
                produtos = FiltrarPorEspecificacoes(especificacao, produtos);
            }

            return produtos;
        }

        private List<Produto> FiltrarPorEspecificacoes(Predicate<Produto> especificacao, List<Produto> produtos)
        {
            List<Produto> listaDeProdutos = new List<Produto>();

            foreach (Produto p in produtos)
            {
                if (especificacao(p))
                {
                    listaDeProdutos.Add(p);
                }
            }

            return listaDeProdutos;
        }
    }
}
