using AutoMapper;
using CatalogoDeProdutos.Dominio.Entidades;
using CatalogoDeProdutos.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatalogoDeProdutos.UI.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Produto, ProdutoViewModel>();
        }
    }
}