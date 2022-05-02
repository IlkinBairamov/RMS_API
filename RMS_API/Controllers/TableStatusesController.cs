using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RMS.Core.Entities;
using RMS.Service.DTOs;
using RMS.Service.DTOs.TableStatusDTO;
using RMS.Service.Services.Interfaces;
using System.Threading.Tasks;

namespace RMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableStatusesController : ControllerBase
    {
        private readonly ITableStatusService _tableStatusService;

        public TableStatusesController(ITableStatusService tableStatusService)
        {
            _tableStatusService = tableStatusService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            PagenatedListDTO<TableStatusGetDTO> tables = await _tableStatusService.GetAllFilteredAsync(1, 10);
            return Ok(tables);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            TableStatusGetDTO hallDto = await _tableStatusService.GetByIdAsync<TableStatusGetDTO>(id);
            return Ok(hallDto);
        }
        [HttpPost("")]
        public async Task<IActionResult> Post(TableStatusPostDTO statusDto)
        {
            await _tableStatusService.CreateAsync(statusDto);
            TableStatus table = await _tableStatusService.GetByNameAsync<TableStatus>(statusDto.Status);
            return StatusCode(202, table);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _tableStatusService.Delete(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TableStatusPostDTO statusDto)
        {
            await _tableStatusService.EditAsync(id, statusDto);
            return NoContent();
        }
    }
}
