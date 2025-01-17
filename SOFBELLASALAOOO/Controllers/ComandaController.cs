﻿using Microsoft.AspNetCore.Mvc;
using SOFBELLASALAOOO.DTO;
using SOFBELLASALAOOO.Models;
using System.Collections.Generic;
using System.Linq;

namespace SOFBELLASALAOOO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComandaController : ControllerBase
    {
        // Simulação de uma lista de comandas e clientes para armazenar em memória
        private static List<Comanda> listaComandas = new List<Comanda>();
        private static List<Cliente> listaClientes = new List<Cliente>
        {
            new Cliente(1, "Cliente 1"),
            new Cliente(2, "Cliente 2")
        };

        // GET: api/Comanda
        [HttpGet]
        public ActionResult<List<Comanda>> GetComandas()
        {
            return Ok(listaComandas);
        }

        // GET: api/Comanda/{id}
        [HttpGet("{id}")]
        public IActionResult GetComandaById(int id)
        {
            var comanda = listaComandas.ElementAtOrDefault(id);
            if (comanda == null)
            {
                return NotFound();
            }
            return Ok(comanda);
        }

        // POST: api/Comanda
        [HttpPost]
        public IActionResult CreateComanda([FromBody] ComandaDTO comandaDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Busca o cliente pelo ID fornecido no DTO
            var cliente = listaClientes.FirstOrDefault(c => c.Id == comandaDTO.ClienteId);
            if (cliente == null)
            {
                return NotFound("Cliente não encontrado.");
            }

            // Cria uma nova comanda baseada no DTO
            var novaComanda = new Comanda(
                comandaDTO.Data,
                cliente,
                comandaDTO.Email,
                comandaDTO.CPF,
                comandaDTO.Telefone
            );

            // Adiciona a nova comanda à lista
            listaComandas.Add(novaComanda);

            // Retorna a comanda criada
            return CreatedAtAction(nameof(GetComandaById), new { id = listaComandas.Count - 1 }, novaComanda);
        }

        // PUT: api/Comanda/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateComanda(int id, [FromBody] ComandaDTO comandaDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var comandaExistente = listaComandas.ElementAtOrDefault(id);
            if (comandaExistente == null)
            {
                return NotFound();
            }

            // Busca o cliente pelo ID fornecido no DTO
            var cliente = listaClientes.FirstOrDefault(c => c.Id == comandaDTO.ClienteId);
            if (cliente == null)
            {
                return NotFound("Cliente não encontrado.");
            }

            // Atualiza os dados da comanda
            comandaExistente.Data = comandaDTO.Data;
            comandaExistente.Cliente = cliente;
            comandaExistente.Email = comandaDTO.Email;
            comandaExistente.CPF = comandaDTO.CPF;
            comandaExistente.Telefone = comandaDTO.Telefone;

            return Ok(comandaExistente);
        }

        // DELETE: api/Comanda/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteComanda(int id)
        {
            var comanda = listaComandas.ElementAtOrDefault(id);
            if (comanda == null)
            {
                return NotFound();
            }

            // Remove a comanda da lista
            listaComandas.RemoveAt(id);

            return Ok(comanda);
        }
    }
}
