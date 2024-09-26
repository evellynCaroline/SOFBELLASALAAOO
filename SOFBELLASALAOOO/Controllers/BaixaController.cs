using Microsoft.AspNetCore.Mvc;
using SOFBELLASALAOOO.DTO;
using System.Collections.Generic;
using System.Linq;

namespace SOFBELLASALAOOO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaixaController : ControllerBase
    {
        // Simulação de uma lista estática para armazenar as baixas
        private static List<BaixaDTO> listaBaixa = new List<BaixaDTO>();

        // GET: api/Baixa
        [HttpGet]
        public ActionResult<List<BaixaDTO>> GetBaixas()
        {
            return Ok(listaBaixa);
        }

        // GET: api/Baixa/{id}
        [HttpGet("{id}")]
        public IActionResult GetBaixaById(int id)
        {
            var baixa = listaBaixa.ElementAtOrDefault(id);
            if (baixa == null)
            {
                return NotFound();
            }
            return Ok(baixa);
        }

        // POST: api/Baixa
        [HttpPost]
        public IActionResult CreateBaixa([FromBody] BaixaDTO baixaDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Adiciona a nova baixa à lista
            listaBaixa.Add(baixaDTO);

            // Retorna o recurso criado com o seu "ID" (índice na lista)
            return CreatedAtAction(nameof(GetBaixaById), new { id = listaBaixa.Count - 1 }, baixaDTO);
        }

        // PUT: api/Baixa/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateBaixa(int id, [FromBody] BaixaDTO baixaDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var baixa = listaBaixa.ElementAtOrDefault(id);
            if (baixa == null)
            {
                return NotFound();
            }

            // Atualizando os dados da baixa
            baixa.Descricao = baixaDTO.Descricao;
            baixa.Servico = baixaDTO.Servico;
            baixa.ConfirmarQuantidadeAoFinalizar = baixaDTO.ConfirmarQuantidadeAoFinalizar;
            baixa.PermitirAlterarProduto = baixaDTO.PermitirAlterarProduto;

            return Ok(baixa);
        }

        // DELETE: api/Baixa/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteBaixa(int id)
        {
            var baixa = listaBaixa.ElementAtOrDefault(id);
            if (baixa == null)
            {
                return NotFound();
            }

            // Remove a baixa da lista
            listaBaixa.RemoveAt(id);

            return Ok(baixa);
        }

        public class BaixaDTO
        {
            internal object Descricao;
            internal object Servico;
            internal object ConfirmarQuantidadeAoFinalizar;
            internal object PermitirAlterarProduto;
        }
    }
}
