using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RMS.Service.DTOs.ReservationDTO;
using RMS.Service.Services.Interfaces;
using System.Threading.Tasks;

namespace RMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationsController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            ReservationGetAllDTO<ReservationGetDTO> reservations = await _reservationService.GetAllAsync<ReservationGetDTO>();
            return Ok(reservations);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            ReservationGetDTO reservationDto = await _reservationService.GetByIdAsync<ReservationGetDTO>(id);
            return Ok(reservationDto);
        }
        [HttpPost("")]
        public async Task<IActionResult> Post(ReservationPostDTO reservationDto)
        {
            await _reservationService.CreateAsync(reservationDto);
            return StatusCode(202);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _reservationService.Delete(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, ReservationPostDTO reservationDto)
        {
            await _reservationService.EditAsync(id, reservationDto);
            return NoContent();
        }
    }
}
