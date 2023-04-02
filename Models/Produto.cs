using System;

namespace TesteTecnico.Models
{
    public class Produto
    {
        public Guid IdProduto { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Guid IdCategoria { get; set; }
        public Decimal Preco { get; set; }
        public string Situacao { get; set; }

        /*F.K*/
        public Categoria Categoria { get; set; }
    }
}
