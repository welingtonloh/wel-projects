using CatalogoDeProdutos.Dominio.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoDeProdutos.Dominio.Entidades
{
    public class Imagem
    {
        public Imagem()
        {
            Produtos = new List<Produto>();
        }

        public int Id { get; set; }

        public string NomeDoArquivo { get; set; }

        public byte[] Arquivo { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
