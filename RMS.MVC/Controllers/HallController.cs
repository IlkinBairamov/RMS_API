using Microsoft.AspNetCore.Mvc;
using RMS.Service.DTOs.HallDTO;
using RMS.Service.Services.Interfaces;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RMS.MVC.Controllers
{
    public class HallController : Controller
    {
        private readonly IHallService _hallService;

        public HallController(IHallService hallService)
        {
            _hallService = hallService;
        }

        public async Task<IActionResult> Index()
        {
            HallGetAllDTO halls = await _hallService.GetAllAsync();
            return View(halls);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HallPostDTO hallDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _hallService.CreateAsync(hallDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _hallService.Delete(id);
            return Json(new { status = 200 });
        }

        public async Task<IActionResult> Update(int id)
        {
            HallPostDTO hallDTO = await _hallService.GetByIdAsync<HallPostDTO>(id);
            return View(hallDTO);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id,HallPostDTO hallDTO)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _hallService.EditAsync(id, hallDTO);
            return RedirectToAction(nameof(Index));
        }
    }
}
