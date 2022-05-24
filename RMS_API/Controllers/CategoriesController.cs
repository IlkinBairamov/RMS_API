using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RMS.Core.Entities;
using RMS.Service.DTOs.CategoryDTO;
using RMS.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService cateogoryService)
        {
            _categoryService = cateogoryService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
           CategoryGetAllDTO<CategoryGetDTO> tables = await _categoryService.GetAllAsync<CategoryGetDTO>();
            return Ok(tables);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            CategoryGetDTO categoryDto = await _categoryService.GetByIdAsync<CategoryGetDTO>(id);
            return Ok(categoryDto);
        }
        [HttpPost("")]
        public async Task<IActionResult> Post([FromForm]CategoryPostDTO categoryDto)
        {
            await _categoryService.CreateAsync(categoryDto);
            Category category = await _categoryService.GetByNameAsync<Category>(categoryDto.Name);
            return StatusCode(202, category);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _categoryService.Delete(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromForm] CategoryEditDTO categoryDto)
        {
            await _categoryService.EditAsync(id, categoryDto);
            return NoContent();
        }
    }
}
