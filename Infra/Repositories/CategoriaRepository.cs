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
    public interface ICategoriaRepository
    {
        Task<Categoria> GetCategoriasById(Guid idCategoria);
        Task<List<Categoria>> GetCategorias(CategoriaFilter filtros);
        void PostCategorias(Categoria input);
        void PutCategorias(Categoria categoria);
    }

    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly TesteDbContext _context;

        public CategoriaRepository(TesteDbContext context)
        {
            _context = context;
        }

        public async Task<Categoria> GetCategoriasById(Guid idCategoria)
        {
            var retorno = await _context.Categorias.FirstOrDefaultAsync(x => x.IdCategoria == idCategoria);               

            return retorno;
        }

        public async Task<List<Categoria>> GetCategorias(CategoriaFilter filtros)
        {
            var retorno = await _context.Categorias
                .WhereIf(filtros.Nome.Count > 0, x => filtros.Nome.Contains(x.Nome))                
                .WhereIf(filtros.Situacao.Count > 0, x => filtros.Situacao.Contains(x.Situacao))
                .ToListAsync();

            return retorno;
        }

        public void PostCategorias(Categoria input)
        {                     

            _context.Categorias.Add(input);
            _context.SaveChanges();            

        }

        public void PutCategorias(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
            _context.SaveChanges();
        }
    }
}
