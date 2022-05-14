using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RMS.Core.Entities;
using RMS.Service.DTOs;
using RMS.Service.DTOs.HallDTO;
using RMS.Service.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HallsController : ControllerBase
    {
        private readonly IHallService _hallService;

        public HallsController(IHallService hallService)
        {
            _hallService = hallService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            HallGetAllDTO halls = await _hallService.GetAllAsync();
            return Ok(halls);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            HallGetDTO hallDto = await _hallService.GetByIdAsync<HallGetDTO>(id);
            return Ok(hallDto);
        }
        [HttpPost("")]
        public async Task<IActionResult> Post(HallPostDTO hallDto)
        {
            await _hallService.CreateAsync(hallDto);
            Hall hall = await _hallService.GetByNameAsync<Hall>(hallDto.Name);
            return StatusCode(202, hall);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _hallService.Delete(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id,HallPostDTO hallDto)
        {
            await _hallService.EditAsync(id,hallDto);
            return NoContent();
        }
    }
}
