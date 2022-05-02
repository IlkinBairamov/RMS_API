using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RMS.Core.Entities;
using RMS.Service.DTOs;
using RMS.Service.DTOs.ProductDTO;
using RMS.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService tableService)
        {
            _productService = tableService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            PagenatedListDTO<ProductGetDTO> products = await _productService.GetAllFilteredAsync(1, 10);
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            ProductGetDTO productDto = await _productService.GetByIdAsync<ProductGetDTO>(id);
            return Ok(productDto);
        }

        [HttpPost("")]
        public async Task<IActionResult> Post(ProductPostDTO productPost)
        {
            await _productService.CreateAsync(productPost);
            Product product = await _productService.GetByNameAsync<Product>(productPost.Name);
            return StatusCode(202, product);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _productService.Delete(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, ProductPostDTO productDTO)
        {
            await _productService.EditAsync(id, productDTO);
            return NoContent();
        }
    }
}
