using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc1.Models
{
    public class TestRepository : IRepository
    {
        public static Produto[] produtos = new Produto[]{
            new Produto{ProdutoId = 1, Nome = "Caneta", Categoria = "Material", Preco = 2.0M},
            new Produto{ProdutoId = 2, Nome = "Borracha", Categoria = "Material", Preco = 0.5M},
            new Produto{ProdutoId = 3, Nome = "Estojo", Categoria = "Material", Preco = 3.0M},  
        }; 
        public IEnumerable<Produto> Produtos {get => produtos;}

    }
}