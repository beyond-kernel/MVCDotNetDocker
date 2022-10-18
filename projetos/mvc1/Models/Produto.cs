using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc1.Models
{
    public class Produto
    {
        public Produto(){
            
        }
        public Produto(int ProdutoId, string nome, string categoria, decimal preco = 0)
        {
            this.ProdutoId = ProdutoId;
            this.Nome = nome;
            this.Categoria = categoria;
            this.Preco = preco;
        }
        public int ProdutoId { get; set; }
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
        public decimal Preco { get; set; }
    }
}