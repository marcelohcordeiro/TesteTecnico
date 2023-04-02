using System;

namespace TesteTecnico.Models.Inputs
{
    public class ProdutoInput
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Guid IdCategoria { get; set; }
        public Decimal Preco { get; set; }        
       
    }
}
