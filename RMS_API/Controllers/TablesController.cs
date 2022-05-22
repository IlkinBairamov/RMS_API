using Microsoft.AspNetCore.Http;
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
        private readonly ITableService _tableService;

        public TablesController(ITableService tableService)
        {
            _tableService = tableService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll(int hallId = 1)
        {
            TableGetAllDTO tables = await _tableService.GetAllAsync(hallId);
            return Ok(tables);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            TableGetDTO hallDto = await _tableService.GetByIdAsync<TableGetDTO>(id);
            return Ok(hallDto);
        }
        [HttpPost("")]
        public async Task<IActionResult> Post(TablePostDTO hallDto)
        {
            await _tableService.CreateAsync(hallDto);
            Table table = await _tableService.GetByNumberAsync<Table>(hallDto.Number);
            return StatusCode(202, table);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _tableService.Delete(id);
            return NoContent();
        }
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(int id, TablePostDTO tableDto)
        //{
        //    await _tableService.EditAsync(id, tableDto);
        //    return NoContent();
        //}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TableEditDTO tabledto)
        {
            await _tableService.ChangeStatusAsync(id, tabledto.TableStatus);
            return NoContent();
        }
    }
}
