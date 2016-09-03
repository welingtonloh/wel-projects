using CatalogoDeProdutos.Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace CatalogoDeProdutos.Dominio.Interfaces.Repositorios
{
    public interface IImagemRepositorio
    {
        Imagem Buscar(int id);
    }
}
