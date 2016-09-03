using AutoMapper;
using CatalogoDeProdutos.Dominio.Entidades;
using CatalogoDeProdutos.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatalogoDeProdutos.UI.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ProdutoViewModel, Produto>();
        }
    }
}