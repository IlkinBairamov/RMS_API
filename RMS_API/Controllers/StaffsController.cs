using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RMS.Core.Entities;
using RMS.Service.DTOs.StaffDTO;
using RMS.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffsController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            StaffGetAllDTO<StaffGetDTO> staff = await _staffService.GetAllAsync<StaffGetDTO>();
            return Ok(staff);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            StaffGetDTO saffGetDTO = await _staffService.GetByIdAsync<StaffGetDTO>(id);
            return Ok(saffGetDTO);
        }

        [HttpPost("")]
        public async Task<IActionResult> Post(StaffPostDTO staffDto)
        {
            StaffCreateReturnDTO staff = await _staffService.CreateAsync(staffDto);
            return StatusCode(202, staff);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _staffService.Delete(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, StaffPostDTO staffDto)
        {
            await _staffService.EditAsync(id, staffDto);
            return NoContent();
        }
    }
}
