using System;
using System.Collections.Generic;

namespace TesteTecnico.Models.Filters
{
    public class ProdutoFilter
    {
        public List<string> Nome { get; set; }
        public List<string> Descricao { get; set; }
        public List<Guid> IdCategoria { get; set; }
        public List<string> Situacao { get; set; }
        
    }
}
