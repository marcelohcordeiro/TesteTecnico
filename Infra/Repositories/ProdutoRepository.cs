using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTecnico.Extensions;
using TesteTecnico.Infra.Data;
using TesteTecnico.Models;
using TesteTecnico.Models.Filters;
using TesteTecnico.Models.Inputs;

namespace TesteTecnico.Infra.Repositories
{
    public interface IProdutoRepository
    {
        Task<Produto> GetProdutosById(Guid idProduto);
        Task<List<Produto>> GetProdutos(ProdutoFilter filtros);
        void PostProdutos(Produto input);
        void PutProdutos(Produto produto);
    }

    public class ProdutoRepository : IProdutoRepository
    {
        private readonly TesteDbContext _context;

        public ProdutoRepository(TesteDbContext context)
        {
            _context = context;
        }

        public async Task<Produto> GetProdutosById(Guid idProduto)
        {
            var retorno = await _context.Produtos.FirstOrDefaultAsync(x => x.IdProduto == idProduto);               

            return retorno;
        }

        public async Task<List<Produto>> GetProdutos(ProdutoFilter filtros)
        {
            var retorno = await _context.Produtos
                .WhereIf(filtros.Nome.Count > 0, x => filtros.Nome.Contains(x.Nome))
                .WhereIf(filtros.IdCategoria.Count > 0, x => filtros.IdCategoria.Contains(x.IdCategoria))
                .WhereIf(filtros.Descricao.Count > 0, x => filtros.Descricao.Contains(x.Descricao))
                .WhereIf(filtros.Situacao.Count > 0, x => filtros.Situacao.Contains(x.Situacao)).Include("Categoria")
                .ToListAsync();

            return retorno;
        }

        public void PostProdutos(Produto input)
        {                     

            _context.Produtos.Add(input);
            _context.SaveChanges();            

        }

        public void PutProdutos(Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }
    }
}
