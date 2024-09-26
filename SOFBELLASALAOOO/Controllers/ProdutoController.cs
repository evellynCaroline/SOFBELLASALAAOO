using Microsoft.AspNetCore.Mvc;
using SOFBELLASALAOOO.DTO;
using SOFBELLASALAOOO.DTOS;
using SOFBELLASALAOOO.Models;
using System.Collections.Generic;
using System.Linq;

namespace SOFBELLASALAOOO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        // Simulação de uma lista de produtos para armazenar em memória
        private static List<Produto> listaProdutos = new List<Produto>();

        // GET: api/Produto
        [HttpGet]
        public ActionResult<List<Produto>> GetProdutos()
        {
            return Ok(listaProdutos);
        }

        // GET: api/Produto/{id}
        [HttpGet("{id}")]
        public IActionResult GetProdutoById(int id)
        {
            var produto = listaProdutos.ElementAtOrDefault(id);
            if (produto == null)
            {
                return NotFound();
            }
            return Ok(produto);
        }

        // POST: api/Produto
        [HttpPost]
        public IActionResult CreateProduto([FromBody] ProdutoDTO produtoDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Cria um novo produto baseado no DTO
            var novoProduto = new Produto(
                produtoDTO.Nome,
                produtoDTO.Unidade,
                produtoDTO.Descricao,
                produtoDTO.CodigoBarras,
                produtoDTO.Categoria,
                produtoDTO.Preco,
                produtoDTO.PrecoCusto,
                produtoDTO.Comissao
            );

            // Adiciona o novo produto à lista
            listaProdutos.Add(novoProduto);

            // Retorna o produto criado
            return CreatedAtAction(nameof(GetProdutoById), new { id = listaProdutos.Count - 1 }, novoProduto);
        }

        // PUT: api/Produto/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateProduto(int id, [FromBody] ProdutoDTO produtoDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var produtoExistente = listaProdutos.ElementAtOrDefault(id);
            if (produtoExistente == null)
            {
                return NotFound();
            }

            // Atualiza os dados do produto
            produtoExistente.Nome = produtoDTO.Nome;
            produtoExistente.Unidade = produtoDTO.Unidade;
            produtoExistente.Descricao = produtoDTO.Descricao;
            produtoExistente.CodigoBarras = produtoDTO.CodigoBarras;
            produtoExistente.Categoria = produtoDTO.Categoria;
            produtoExistente.Preco = produtoDTO.Preco;
            produtoExistente.PrecoCusto = produtoDTO.PrecoCusto;
            produtoExistente.Comissao = produtoDTO.Comissao;

            return Ok(produtoExistente);
        }

        // DELETE: api/Produto/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteProduto(int id)
        {
            var produto = listaProdutos.ElementAtOrDefault(id);
            if (produto == null)
            {
                return NotFound();
            }

            // Remove o produto da lista
            listaProdutos.RemoveAt(id);

            return Ok(produto);
        }
    }
}
