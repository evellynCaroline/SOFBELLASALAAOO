using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using SOFBELLASALAOOO.Models;

namespace SOFBELLASALAOOO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloqueioController : ControllerBase
    {
        private static List<Bloqueio> listaBloqueio = new List<Bloqueio>();

        // Método GET para retornar todos os bloqueios
        [HttpGet]
        public ActionResult<List<Bloqueio>> GetBloqueio()
        {
            return Ok(listaBloqueio);
        }

        // Método GET para retornar um bloqueio específico por ID
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var bloqueio = listaBloqueio.ElementAtOrDefault(id);
            if (bloqueio == null)
            {
                return NotFound();
            }
            return Ok(bloqueio);
        }

        // Método POST para criar um novo bloqueio
        [HttpPost]
        public IActionResult Post([FromBody] Bloqueio novoBloqueio)
        {
            listaBloqueio.Add(novoBloqueio);
            return CreatedAtAction(nameof(GetById), new { id = listaBloqueio.Count - 1 }, novoBloqueio);
        }

        // Método PUT para atualizar um bloqueio existente
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Bloqueio item)
        {
            var bloqueio = listaBloqueio.ElementAtOrDefault(id);

            if (bloqueio == null)
            {
                return NotFound();
            }

            // Atualizando os valores do bloqueio
            bloqueio.Profissional = item.Profissional;
            bloqueio.DataInicio = item.DataInicio;
            bloqueio.HoraInicio = item.HoraInicio;
            bloqueio.DataFinal = item.DataFinal;
            bloqueio.HoraFinal = item.HoraFinal;
            bloqueio.Motivo = item.Motivo;

            return Ok(bloqueio);
        }

        // Método DELETE para remover um bloqueio
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var bloqueio = listaBloqueio.ElementAtOrDefault(id);

            if (bloqueio == null)
            {
                return NotFound();
            }

            listaBloqueio.RemoveAt(id);

            return Ok(bloqueio);
        }
    }
}
