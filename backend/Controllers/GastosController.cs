using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.DTOs.GastoDTOs;
using backend.Mappers;
using backend.Models;
using backend.Repositories.GastoRepository;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class GastosController : ControllerBase
    {
        private readonly IGastoRepository _gastoRepo;

        public GastosController(IGastoRepository gastoRepo)
        {
            _gastoRepo = gastoRepo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var gastos = await _gastoRepo.GetAllAsync();

            return Ok(gastos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var gasto = await _gastoRepo.GetByIdAsync(id);

            if(gasto == null)
                return NotFound();

            return Ok(gasto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateGastoDTO createGastoDTO)
        {
            var gasto = createGastoDTO.ToGastoFromCreateDTO();

            await _gastoRepo.CreateAsync(gasto);

            return CreatedAtAction(nameof(GetById), new {id = gasto.Id}, gasto.ToGastoDTO());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateGastoDTO updateGastoDTO)
        {
            var gasto = await _gastoRepo.UpdateAsync(id, updateGastoDTO);

            if(gasto == null)
                return NotFound();

            return Ok(gasto.ToGastoDTO());
        }
    }
}