using CatalogoDeProdutos.Dominio.Entidades;
using CatalogoDeProdutos.Dominio.Enums;
using CatalogoDeProdutos.Dominio.Especificacoes;
using CatalogoDeProdutos.Dominio.Especificacoes.Gerenciadores;
using CatalogoDeProdutos.Dominio.Interfaces;
using CatalogoDeProdutos.Dominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;

namespace CatalogoDeProdutos.Dominio.Servicos
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoServico(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public void Adicionar(Produto produto)
        {
            _produtoRepositorio.Adicionar(produto);
        }

        public IEnumerable<Produto> Listar()
        {
            return _produtoRepositorio.Listar();
        }

        public IEnumerable<Produto> Filtrar(Categorias categoria, SubCategorias subcategoria)
        {
            GerenciadorEspecificacoesProdutos gerenciador = new GerenciadorEspecificacoesProdutos(categoria, subcategoria);
            return _produtoRepositorio.Filtrar(gerenciador.ObterEspecificacoes());
        }
    }
}
