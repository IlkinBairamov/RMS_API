using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RMS.MVC.ViewModels;
using RMS.MVC.ViewModels.Hall;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RMS.MVC.Controllers
{
    public class HallController : Controller
    {
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://localhost:44355/api/halls");
            var responseJsonStr = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                HallIndexVM model = JsonConvert.DeserializeObject<HallIndexVM>(responseJsonStr);
                return View(model);
            }
            else
            {
                ErrorResponseVM error = JsonConvert.DeserializeObject<ErrorResponseVM>(responseJsonStr);
                return Ok(error);
            }
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HallCreateVM hallVM)
        {
            var jsonStr = JsonConvert.SerializeObject(hallVM);
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PostAsync("https://localhost:44355/api/halls", new StringContent(jsonStr, Encoding.UTF8, "application/json"));
            if (response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                return RedirectToAction(nameof(Index));
            }
            else {
                string responseContentStr = await response.Content.ReadAsStringAsync();
                ErrorResponseVM error = JsonConvert.DeserializeObject<ErrorResponseVM>(responseContentStr);


               
                ModelState.AddModelError("Name",error.Message);
            }
            return View();
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.DeleteAsync($"https://localhost:44355/api/halls/{id}");
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
            HttpResponseMessage response = await client.GetAsync($"https://localhost:44355/api/halls/{id}");
            var responseJsonStr = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                HallIndexItemVM model = JsonConvert.DeserializeObject<HallIndexItemVM>(responseJsonStr);
                return View(model);
            }
            else
            {
                ErrorResponseVM error = JsonConvert.DeserializeObject<ErrorResponseVM>(responseJsonStr);
                return Ok(error);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,HallCreateVM hallVM)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var jsonStr = JsonConvert.SerializeObject(hallVM);
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PutAsync($"https://localhost:44355/api/halls/{id}", new StringContent(jsonStr, Encoding.UTF8, "application/json"));
            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                string responseContentStr = await response.Content.ReadAsStringAsync();
                ErrorResponseVM error = JsonConvert.DeserializeObject<ErrorResponseVM>(responseContentStr);
                ModelState.AddModelError("Name", error.Message);
            }
            return View();

        }
    }
}
