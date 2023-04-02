using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTecnico.Infra.Repositories;
using TesteTecnico.Models;
using TesteTecnico.Models.Filters;
using TesteTecnico.Models.Inputs;

namespace TesteTecnico.Services
{
    public interface ICategoriaService
    {
        Task<Categoria> GetCategoriasById(Guid idCategoria);
        Task<List<Categoria>> GetCategorias(CategoriaFilter filtros);
        Categoria PostCategorias(CategoriaInput input);
        Task<Categoria> PutCategorias(Categoria input, Guid idCategoria);
    }

    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService (ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public Task<Categoria> GetCategoriasById(Guid idCategoria)
        {
            var retorno = _categoriaRepository.GetCategoriasById(idCategoria);

            return retorno;
        }

        public async Task<List<Categoria>> GetCategorias(CategoriaFilter filtros)
        {
            #region Filtro - Tratativas
            /*Tratativa para inicializar os filtros*/
            if (filtros.Nome == null)
                filtros.Nome = new List<string>();          

            if (filtros.Situacao == null)
                filtros.Situacao = new List<string>();

            filtros.Nome.RemoveAll(x => String.IsNullOrEmpty(x));
            filtros.Situacao.RemoveAll(x => String.IsNullOrEmpty(x));
            #endregion

            var retorno = await _categoriaRepository.GetCategorias(filtros);

            return retorno;
        }

        public Categoria PostCategorias(CategoriaInput input)
        {
            try
            {
                Categoria categoria = new Categoria();

                categoria.IdCategoria = Guid.NewGuid();
                categoria.Nome = input.Nome;               
                categoria.Situacao = "Ativo";

                _categoriaRepository.PostCategorias(categoria);

                return categoria;
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    throw new Exception(ex.InnerException.Message);
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            
        }

        public async Task<Categoria> PutCategorias(Categoria input, Guid idCategoria)
        {

            try
            {
                if (input.IdCategoria != idCategoria)
                    throw new Exception("Id informado não corresponde ao objeto informado");

                var categoria = await _categoriaRepository.GetCategoriasById(idCategoria);

                if (categoria == null)
                    throw new Exception("Categoria não encontrado");

                categoria.Nome = input.Nome;                
                categoria.IdCategoria = input.IdCategoria;
                

                if (!(input.Situacao == "Ativo" || input.Situacao == "Inativo"))
                {
                    throw new Exception("A situação de categoria deve ser Ativo ou Inativo");
                }

                categoria.Situacao = input.Situacao;

                _categoriaRepository.PutCategorias(categoria);

                return categoria;
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    throw new Exception(ex.InnerException.Message);
                }
                else
                {
                    throw new Exception(ex.Message);
                }
                    


            }
            

        }
    }
}
