using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTecnico.Infra.Repositories;
using TesteTecnico.Models;
using TesteTecnico.Models.Filters;
using TesteTecnico.Models.Inputs;

namespace TesteTecnico.Services
{
    public interface IProdutoService
    {
        Task<Produto> GetProdutosById(Guid idProduto);
        Task<List<Produto>> GetProdutos(ProdutoFilter filtros);
        Produto PostProdutos(ProdutoInput input);
        Task<Produto> PutProdutos(Produto input, Guid idProduto);
    }

    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService (IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public Task<Produto> GetProdutosById(Guid idProduto)
        {
            var retorno = _produtoRepository.GetProdutosById(idProduto);

            return retorno;
        }

        public async Task<List<Produto>> GetProdutos(ProdutoFilter filtros)
        {
            #region Filtro - Tratativas
            /*Tratativa para inicializar os filtros*/
            if (filtros.Nome == null)
                filtros.Nome = new List<string>();

            if (filtros.Descricao == null)
                filtros.Descricao = new List<string>();

            if (filtros.IdCategoria == null)
                filtros.IdCategoria = new List<Guid>();

            if (filtros.Situacao == null)
                filtros.Situacao = new List<string>();

            filtros.Nome.RemoveAll(x => String.IsNullOrEmpty(x));
            filtros.Descricao.RemoveAll(x => String.IsNullOrEmpty(x));
            filtros.IdCategoria.RemoveAll(x => x == Guid.Empty || x == null);
            filtros.Situacao.RemoveAll(x => String.IsNullOrEmpty(x));
            #endregion

            var retorno = await _produtoRepository.GetProdutos(filtros);

            return retorno;
        }

        public Produto PostProdutos(ProdutoInput input)
        {
            try
            {
                Produto produto = new Produto();

                produto.IdProduto = Guid.NewGuid();
                produto.Nome = input.Nome;
                produto.Descricao = input.Descricao;
                produto.IdCategoria = input.IdCategoria;
                produto.Preco = input.Preco;
                produto.Situacao = "Ativo";

                _produtoRepository.PostProdutos(produto);

                return produto;
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

        public async Task<Produto> PutProdutos(Produto input, Guid idProduto)
        {

            try
            {
                if (input.IdProduto != idProduto)
                    throw new Exception("Id informado não corresponde ao objeto informado");

                var produto = await _produtoRepository.GetProdutosById(idProduto);

                if (produto == null)
                    throw new Exception("Produto não encontrado");

                produto.Nome = input.Nome;
                produto.Descricao = input.Descricao;
                produto.IdCategoria = input.IdCategoria;
                produto.Preco = input.Preco;

                if (!(input.Situacao == "Ativo" || input.Situacao == "Inativo"))
                {
                    throw new Exception("A situação do produto deve ser Ativo ou Inativo");
                }

                produto.Situacao = input.Situacao;

                _produtoRepository.PutProdutos(produto);

                return produto;
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
