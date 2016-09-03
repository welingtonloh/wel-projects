using CatalogoDeProdutos.Dominio.Entidades;
using CatalogoDeProdutos.Dominio.Enums;
using System.Collections.Generic;

namespace CatalogoDeProdutos.Dominio.Interfaces
{
    public interface IImagemServico
    {
        Imagem Buscar(int id);
    }
}
