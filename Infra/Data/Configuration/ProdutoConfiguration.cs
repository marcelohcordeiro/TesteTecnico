using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteTecnico.Models;

namespace TesteTecnico.Infra.Data.Configuration
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.IdProduto);

            builder.Property(p => p.Nome).IsRequired().HasColumnType("varchar(200)");
            builder.Property(p => p.Descricao).IsRequired().HasColumnType("varchar(1000)");
            builder.Property(p => p.Preco).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(p => p.Situacao).IsRequired().HasColumnType("varchar(10)");

            builder.HasOne(x => x.Categoria).WithMany().HasForeignKey(x => x.IdCategoria);

            builder.ToTable("Produto");
        }    
    }
}
