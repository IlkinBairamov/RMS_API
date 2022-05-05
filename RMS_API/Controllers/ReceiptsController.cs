using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RMS.Core.Entities;
using RMS.Service.DTOs;
using RMS.Service.DTOs.ReceiptDTO;
using RMS.Service.Services.Interfaces;
using System.Threading.Tasks;

namespace RMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiptsController : ControllerBase
    {
        private readonly IReceiptService _receiptService;

        public ReceiptsController(IReceiptService receiptService)
        {
            _receiptService = receiptService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            PagenatedListDTO<ReceiptGetDTO> receipts = await _receiptService.GetAllFilteredAsync(1, 10);
            return Ok(receipts);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            ReceiptGetDTO receiptDto = await _receiptService.GetByIdAsync<ReceiptGetDTO>(id);
            return Ok(receiptDto);
        }
        [HttpPost("")]
        public async Task<IActionResult> Post([FromForm] ReceiptPostDTO receiptDto)
        {
            await _receiptService.CreateAsync(receiptDto);
            return StatusCode(202);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _receiptService.Delete(id);
            return NoContent();
        }
    }
}
