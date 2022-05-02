using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RMS.Core.Entities;
using RMS.Service.DTOs;
using RMS.Service.DTOs.FoodDTO;
using RMS.Service.DTOs.TableStatusDTO;
using RMS.Service.Services.Interfaces;
using System.Threading.Tasks;

namespace RMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        private readonly IFoodService _foodService;

        public FoodsController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            PagenatedListDTO<FoodGetDTO> tables = await _foodService.GetAllFilteredAsync(1, 10);
            return Ok(tables);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            FoodGetDTO hallDto = await _foodService.GetByIdAsync<FoodGetDTO>(id);
            return Ok(hallDto);
        }
        [HttpPost("")]
        public async Task<IActionResult> Post([FromForm] FoodPostDTO foodDto)
        {
            await _foodService.CreateAsync(foodDto);
            Food food = await _foodService.GetByNameAsync<Food>(foodDto.Name);
            return StatusCode(202, food);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _foodService.Delete(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromForm] FoodEditDTO foodDto)
        {
            await _foodService.EditAsync(id, foodDto);
            return NoContent();
        }
    }
}
