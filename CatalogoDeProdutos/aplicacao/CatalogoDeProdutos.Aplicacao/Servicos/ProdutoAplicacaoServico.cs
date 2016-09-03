using System;
using System.Collections.Generic;
using CatalogoDeProdutos.Aplicacao.Interfaces;
using CatalogoDeProdutos.Dominio.Entidades;
using CatalogoDeProdutos.Dominio.Interfaces;
using CatalogoDeProdutos.Dominio;
using CatalogoDeProdutos.Dominio.Enums;

namespace CatalogoDeProdutos.Aplicacao
{
    public class ProdutoAplicacaoServico : AplicacaoBase, IProdutoAplicacaoServico
    {
        private readonly IProdutoServico _produtoServico;

        public ProdutoAplicacaoServico(IProdutoServico produtoServico)
        {
            _produtoServico = produtoServico;
        }

        public void Adicionar(Produto produto)
        {
            IniciarTransacao();

            _produtoServico.Adicionar(produto);

            EfetivarTransacao();
        }

        public IEnumerable<Produto> Listar()
        {
            return _produtoServico.Listar();
        }

        public IEnumerable<Produto> Filtrar(Categorias categoria, SubCategorias subcategoria)
        {
            return _produtoServico.Filtrar(categoria, subcategoria);
        }
    }
}
