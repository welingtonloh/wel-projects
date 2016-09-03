using CatalogoDeProdutos.Dominio.Entidades;
using CatalogoDeProdutos.Dominio.Enums;
using System;
using System.Collections.Generic;

namespace CatalogoDeProdutos.Dominio.Especificacoes.Gerenciadores
{
    public class GerenciadorEspecificacoesProdutos
    {
        public List<Predicate<Produto>> _especificacoes;

        public GerenciadorEspecificacoesProdutos(Categorias categoria, SubCategorias subcategoria)
        {
            _especificacoes = new List<Predicate<Produto>>();

            DefinirEspecificacoesCategoria(categoria);
            DefinirEspecificacoesSubCategoria(subcategoria);
        }

        public List<Predicate<Produto>> ObterEspecificacoes()
        {
            return this._especificacoes;
        }

        public void DefinirEspecificacoesCategoria(Categorias categoria)
        {
            if (categoria == Categorias.Feminino)
            {
                _especificacoes.Add(Feminino.EhSatisfeito);
            }
            else if (categoria == Categorias.Linhas)
            {
                _especificacoes.Add(Linhas.EhSatisfeito);
            }
            else if (categoria == Categorias.Masculino)
            {
                _especificacoes.Add(Masculino.EhSatisfeito);
            }
            else if (categoria == Categorias.Novidades)
            {
                _especificacoes.Add(Novidades.EhSatisfeito);
            }
            else if (categoria == Categorias.Ofertas)
            {
                _especificacoes.Add(Ofertas.EhSatisfeito);
            }
        }

        public void DefinirEspecificacoesSubCategoria(SubCategorias subCategoria)
        {
            if (subCategoria == SubCategorias.Basicos)
            {
                _especificacoes.Add(Basicos.EhSatisfeito);
            }
            else if (subCategoria == SubCategorias.BlusasTShirts)
            {
                _especificacoes.Add(BlusasTShirts.EhSatisfeito);
            }
            else if (subCategoria == SubCategorias.Calcas)
            {
                _especificacoes.Add(Calcas.EhSatisfeito);
            }
            else if (subCategoria == SubCategorias.Camisas)
            {
                _especificacoes.Add(Camisas.EhSatisfeito);
            }
            else if (subCategoria == SubCategorias.CamisasPolos)
            {
                _especificacoes.Add(CamisasPolos.EhSatisfeito);
            }
            else if (subCategoria == SubCategorias.Casacos)
            {
                _especificacoes.Add(Casacos.EhSatisfeito);
            }
            else if (subCategoria == SubCategorias.CasacosBlazers)
            {
                _especificacoes.Add(CasacosBlazers.EhSatisfeito);
            }
            else if (subCategoria == SubCategorias.Fitness)
            {
                _especificacoes.Add(Fitness.EhSatisfeito);
            }
            else if (subCategoria == SubCategorias.Jardineiras)
            {
                _especificacoes.Add(Jardineiras.EhSatisfeito);
            }
            else if (subCategoria == SubCategorias.Jeans)
            {
                _especificacoes.Add(Jeans.EhSatisfeito);
            }
            else if (subCategoria == SubCategorias.Macacoes)
            {
                _especificacoes.Add(Macacoes.EhSatisfeito);
            }
            else if (subCategoria == SubCategorias.Pijamas)
            {
                _especificacoes.Add(Pijamas.EhSatisfeito);
            }
            else if (subCategoria == SubCategorias.PlusSize)
            {
                _especificacoes.Add(PlusSize.EhSatisfeito);
            }
            else if (subCategoria == SubCategorias.Saias)
            {
                _especificacoes.Add(Saias.EhSatisfeito);
            }
            else if (subCategoria == SubCategorias.ShortsBermudas)
            {
                _especificacoes.Add(ShortsBermudas.EhSatisfeito);
            }
            else if (subCategoria == SubCategorias.TShirtsRegatas)
            {
                _especificacoes.Add(TShirtsRegatas.EhSatisfeito);
            }
            else if (subCategoria == SubCategorias.Vestidos)
            {
                _especificacoes.Add(Vestidos.EhSatisfeito);
            }
        }
    }
}
