using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RMS.Core.Entities;
using RMS.Service.DTOs.StaffTypeDTO;
using RMS.Service.Services.Interfaces;
using System.Threading.Tasks;

namespace RMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffTypesController : ControllerBase
    {
        private readonly IStaffTypeService _staffTypeService;

        public StaffTypesController(IStaffTypeService staffTypeService)
        {
            _staffTypeService = staffTypeService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            StaffTypeGetAllDTO<StaffTypeGetDTO> staffTypes = await _staffTypeService.GetAllAsync<StaffTypeGetDTO>();
            return Ok(staffTypes);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            StaffTypeGetDTO staffTypeDto = await _staffTypeService.GetByIdAsync<StaffTypeGetDTO>(id);
            return Ok(staffTypeDto);
        }
        [HttpPost("")]
        public async Task<IActionResult> Post(StaffTypePostDTO staffTypeDto)
        {
            await _staffTypeService.CreateAsync(staffTypeDto);
            StaffType staffType = await _staffTypeService.GetByNameAsync<StaffType>(staffTypeDto.Name);
            return StatusCode(202, staffType);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _staffTypeService.Delete(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, StaffTypePostDTO staffTypeDto)
        {
            await _staffTypeService.EditAsync(id, staffTypeDto);
            return NoContent();
        }
    }
}
