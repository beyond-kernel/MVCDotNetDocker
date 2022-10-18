using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc1.Models
{
    public interface IRepository
    {
        public IEnumerable<Produto> Produtos {get;}
    }
}