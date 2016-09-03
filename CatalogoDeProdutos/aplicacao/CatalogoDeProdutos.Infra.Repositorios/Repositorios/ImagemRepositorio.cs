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
    public class ImagemRepositorio : IImagemRepositorio
    {
        protected CatalogoDeProdutosContexto Contexto { get; private set; }

        public ImagemRepositorio()
        {
            var gerenciadorContexto = ServiceLocator.Current.GetInstance<GerenciadorContexto>();
            Contexto = gerenciadorContexto.Contexto;
        }

        public Imagem Buscar(int id)
        {
            return Contexto.Imagens.Where(p => p.Id == id).First();
        }
    }
}
