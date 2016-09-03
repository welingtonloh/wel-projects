using CatalogoDeProdutos.Dominio.Entidades;
using CatalogoDeProdutos.Dominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoDeProdutos.Dominio.Servicos
{
    public class ImagemServico
    {
        private readonly IImagemRepositorio _imagemRepositorio;

        public ImagemServico(IImagemRepositorio imagemRepositorio)
        {
            _imagemRepositorio = imagemRepositorio;
        }

        public Imagem Buscar(int id)
        {
            return _imagemRepositorio.Buscar(id);
        }
    }
}
