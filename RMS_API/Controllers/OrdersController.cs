using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RMS.Core.Entities;
using RMS.Service.DTOs;
using RMS.Service.DTOs.OrderDTO;
using RMS.Service.Services.Interfaces;
using System.Threading.Tasks;

namespace RMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll(int pageIndex)
        {
            PagenatedListDTO<OrderGetDTO> halls = await _orderService.GetAllFilteredAsync(pageIndex, 10);
            return Ok(halls);
        }
        [HttpGet("{tableId}")]
        public async Task<IActionResult> Get(int tableId = 0)
        {
            OrderGetDTO orderDto = new OrderGetDTO();
            orderDto = await _orderService.GetByTableAsync<OrderGetDTO>(tableId);
            return Ok(orderDto);
        }
        [HttpPost("")]
        public async Task<IActionResult> Post(OrderPostDTO orderDto)
        {
            await _orderService.CreateAsync(orderDto);
            OrderGetDTO order = await _orderService.GetByTableAsync<OrderGetDTO>(orderDto.TableId);
            return StatusCode(202,order);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _orderService.Delete(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, OrderEditDTO orderDto)
        {
            await _orderService.EditAsync(id, orderDto);
            return NoContent();
        }
    }
}
