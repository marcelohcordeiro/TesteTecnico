using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
    [Route("categorias")]
    public class CategoriaController : ControllerBase
    {

        private readonly ICategoriaService _categoriaService;

        public CategoriaController(
            ICategoriaService categoriaService)
        {
            
            _categoriaService = categoriaService;
        }

        [HttpGet]        
        public async Task<IActionResult> GetCategorias([FromQuery] CategoriaFilter filtros)
        {

            var retorno = await _categoriaService.GetCategorias(filtros);

            return Ok(retorno);

        }


        [HttpPost]
        public async Task<IActionResult> PostCategorias([FromBody] CategoriaInput input)
        {
            try
            {
                var retorno = _categoriaService.PostCategorias(input);

                return Ok(retorno);
               
            }
            catch (Exception ex)
            {
                return BadRequest("Ocorreu um erro ao cadastrar novo categoria: " + ex.Message);
            }
            

        }

        [HttpPut("{idCategoria}")]
        public async Task<IActionResult> PutCategorias(Guid idCategoria, [FromBody] Categoria input)
        {
            try
            {
                var retorno = await _categoriaService.PutCategorias(input, idCategoria);

                return Ok(retorno);
            }
            catch (Exception ex)
            {
                return BadRequest("Ocorreu um erro ao alterar o categoria: " + ex.Message);
            }
        }

    }
}
