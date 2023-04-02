using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteTecnico.Extensions;
using TesteTecnico.Infra.Data;
using TesteTecnico.Models;
using TesteTecnico.Models.Filters;
using TesteTecnico.Models.Inputs;
using TesteTecnico.Services;

namespace TesteTecnico.Controllers
{
    [ApiController]
    [Route("produtos")]
    public class ProdutoController : ControllerBase
    {

        private readonly TesteDbContext _context;
        private readonly IProdutoService _produtoService;

        public ProdutoController(
            TesteDbContext context
            ,IProdutoService produtoService)
        {
            _context = context;
            _produtoService = produtoService;
        }

        [HttpGet]        
        public async Task<IActionResult> GetProdutos([FromQuery] ProdutoFilter filtros)
        {
                       

            var retorno = await _produtoService.GetProdutos(filtros);

            return Ok(retorno);

        }


        [HttpPost]
        public async Task<IActionResult> PostProdutos([FromBody] ProdutoInput input)
        {
            try
            {

                var retorno = _produtoService.PostProdutos(input);

                return Ok(retorno);
            }
            catch (Exception ex)
            {
                return BadRequest("Ocorreu um erro ao cadastrar novo produto: " + ex.Message);
            }
            

        }

        [HttpPut("{idProduto}")]
        public async Task<IActionResult> PutProdutos(Guid idProduto, [FromBody] Produto input)
        {
            try
            {

                var retorno = await _produtoService.PutProdutos(input, idProduto);
                

                return Ok(retorno);
            }
            catch (Exception ex)
            {
                return BadRequest("Ocorreu um erro ao alterar o produto: " + ex.Message);
            }
        }

    }
}
