using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RMS.MVC.ViewModels;
using RMS.MVC.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RMS.MVC.Controllers
{
    public class CategoryController : Controller
    {
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://localhost:44355/api/categories");
            var responseJsonStr = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                CategoryIndexVM model = JsonConvert.DeserializeObject<CategoryIndexVM>(responseJsonStr);
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
        public async Task<IActionResult> Create(CategoryCreateVM categoryVM)
        {
             if (!ModelState.IsValid)
            {
                return View();
            }
            var jsonStr = JsonConvert.SerializeObject(categoryVM);
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PostAsync("https://localhost:44355/api/categories", new StringContent(jsonStr, Encoding.UTF8, "application/json"));
            if (response.StatusCode == HttpStatusCode.Created)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                string responseContentStr = await response.Content.ReadAsStringAsync();
                ErrorResponseVM error = JsonConvert.DeserializeObject<ErrorResponseVM>(responseContentStr);

                ModelState.AddModelError("File", error.Message);
                return View();
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
            HttpResponseMessage response = await client.DeleteAsync($"https://localhost:44355/api/categories/{id}");
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
            HttpResponseMessage response = await client.GetAsync($"https://localhost:44355/api/categories/{id}");
            var responseJsonStr = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                CategoryIndexItemVM model = JsonConvert.DeserializeObject<CategoryIndexItemVM>(responseJsonStr);
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
        public async Task<IActionResult> Update(int? id, CategoryCreateVM categoryVM)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var jsonStr = JsonConvert.SerializeObject(categoryVM);
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PutAsync($"https://localhost:44355/api/categories/{id}", new StringContent(jsonStr, Encoding.UTF8, "application/json"));
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
