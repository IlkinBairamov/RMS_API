﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RMS.Core.Entities;
using RMS.Service.DTOs;
using RMS.Service.DTOs.TableDTO;
using RMS.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TablesController : ControllerBase
    {
        private readonly ITableService _tableStatusService;

        public TablesController(ITableService tableService)
        {
            _tableStatusService = tableService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            PagenatedListDTO<TableGetDTO> tables = await _tableStatusService.GetAllFilteredAsync(1, 10);
            return Ok(tables);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            TableGetDTO hallDto = await _tableStatusService.GetByIdAsync<TableGetDTO>(id);
            return Ok(hallDto);
        }
        [HttpPost("")]
        public async Task<IActionResult> Post(TablePostDTO hallDto)
        {
            await _tableStatusService.CreateAsync(hallDto);
            Table table = await _tableStatusService.GetByNumberAsync<Table>(hallDto.Number);
            return StatusCode(202, table);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _tableStatusService.Delete(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TablePostDTO tableDto)
        {
            await _tableStatusService.EditAsync(id, tableDto);
            return NoContent();
        }
    }
}
