﻿using CatalogoDeProdutos.Dominio.Entidades;
using CatalogoDeProdutos.Dominio.Enums;
using System;

namespace CatalogoDeProdutos.Dominio.Especificacoes
{
    public class Casacos
    {
        public static Predicate<Produto> EhSatisfeito
        {
            get
            {
                return delegate (Produto produto)
                {
                    return (produto.SubCategoria == SubCategorias.Casacos);
                };
            }
        }
    }
}
