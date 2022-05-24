using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RMS.MVC.ViewModels;
using RMS.MVC.ViewModels.Food;
using RMS.MVC.ViewModels.Hall;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RMS.MVC.Controllers
{
    public class FoodController : Controller
    {
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://localhost:44355/api/foods");
            var responseJsonStr = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                FoodIndexVM model = JsonConvert.DeserializeObject<FoodIndexVM>(responseJsonStr);
                return View(model);
            }
            else
            {
                ErrorResponseVM error = JsonConvert.DeserializeObject<ErrorResponseVM>(responseJsonStr);
                return Ok(error);
            }
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FoodCreateVM foodVM)
        {
            var jsonStr = JsonConvert.SerializeObject(foodVM);
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PostAsync("https://localhost:44355/api/foods", new StringContent(jsonStr, Encoding.UTF8, "application/json"));
            if (response.StatusCode == HttpStatusCode.Created)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                string responseContentStr = await response.Content.ReadAsStringAsync();
                ErrorResponseVM error = JsonConvert.DeserializeObject<ErrorResponseVM>(responseContentStr);

                ModelState.AddModelError("", error.Message);
            }
            return View();
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.DeleteAsync($"https://localhost:44355/api/foods/{id}");
            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return Json(new { status = 200 });
            }
            return View();
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"https://localhost:44355/api/foods/{id}");
            HttpResponseMessage responseCategories = await client.GetAsync($"https://localhost:44355/api/categories");
            var responseJsonStr = await response.Content.ReadAsStringAsync();
            var responseCategoriesJsonStr = await responseCategories.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                FoodIndexItemVM model = JsonConvert.DeserializeObject<FoodIndexItemVM>(responseJsonStr);
                HallIndexVM categories = JsonConvert.DeserializeObject<HallIndexVM>(responseCategoriesJsonStr);
                ViewBag.Categories = categories.Halls;
                return View(model);
            }
            else
            {
                ErrorResponseVM error = JsonConvert.DeserializeObject<ErrorResponseVM>(responseJsonStr);
                return Ok(error);
            }
        }
    }
}
