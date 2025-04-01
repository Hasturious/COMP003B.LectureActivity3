using Microsoft.AspNetCore.Mvc;
using COMP003B.LectureActivity3.Models;

namespace COMP003B.LectureActivity3.Controllers
{
    [Route("product")]

    public class ProductController : Controller
    {
        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost("create")]
        public IActionResult post([FromForm] Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            return RedirectToAction("Success", product);
        }
        [Route("success")]
        public IActionResult Success(Product product)
        {
            return View(product);
        }
    }
}


