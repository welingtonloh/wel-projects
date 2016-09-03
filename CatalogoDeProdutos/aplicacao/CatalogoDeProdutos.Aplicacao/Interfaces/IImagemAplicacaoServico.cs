using CatalogoDeProdutos.Dominio.Entidades;
using CatalogoDeProdutos.Dominio.Enums;
using System.Collections.Generic;

namespace CatalogoDeProdutos.Aplicacao.Interfaces
{
    public interface IImagemAplicacaoServico
    {
        Imagem Buscar(int id); 
    }
}
