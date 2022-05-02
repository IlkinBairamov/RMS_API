using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RMS.Core.Entities;
using RMS.Service.DTOs;
using RMS.Service.DTOs.ProductTypeDTO;
using RMS.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypesController : ControllerBase
    {
        private readonly IProductTypeService _productTypeService;

        public ProductTypesController(IProductTypeService productTypeService)
        {
            _productTypeService = productTypeService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            ProductTypeGetAllDTO<ProductTypeGetDTO> productTypes = await _productTypeService.GetAllAsync<ProductTypeGetDTO>();
            return Ok(productTypes);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            ProductTypeGetDTO productTypeDto = await _productTypeService.GetByIdAsync<ProductTypeGetDTO>(id);
            return Ok(productTypeDto);
        }
        [HttpPost("")]
        public async Task<IActionResult> Post(ProductTypePostDTO productTypeDto)
        {
            await _productTypeService.CreateAsync(productTypeDto);
            ProductType productType = await _productTypeService.GetByNameAsync<ProductType>(productTypeDto.Name);
            return StatusCode(202, productType);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _productTypeService.Delete(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, ProductTypePostDTO productTypeDto)
        {
            await _productTypeService.EditAsync(id, productTypeDto);
            return NoContent();
        }
    }
}
