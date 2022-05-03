using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RMS.Core.Entities;
using RMS.Service.DTOs.OrderTypeDTO;
using RMS.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderTypesController : ControllerBase
    {
        private readonly IOrderTypeService _orderTypeService;

        public OrderTypesController(IOrderTypeService orderTypeService)
        {
            _orderTypeService = orderTypeService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            OrderTypeGetAllDTO<OrderTypeGetDTO> orderTypes = await _orderTypeService.GetAllAsync<OrderTypeGetDTO>();
            return Ok(orderTypes);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            OrderTypeGetDTO orderTypeDto = await _orderTypeService.GetByIdAsync<OrderTypeGetDTO>(id);
            return Ok(orderTypeDto);
        }
        [HttpPost("")]
        public async Task<IActionResult> Post(OrderTypePostDTO orderTypeDto)
        {
            await _orderTypeService.CreateAsync(orderTypeDto);
            OrderType orderType = await _orderTypeService.GetByNameAsync<OrderType>(orderTypeDto.Name);
            return StatusCode(202, orderType);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _orderTypeService.Delete(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, OrderTypePostDTO orderTypeDto)
        {
            await _orderTypeService.EditAsync(id, orderTypeDto);
            return NoContent();
        }
    }
}
