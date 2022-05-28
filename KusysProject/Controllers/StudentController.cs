using Microsoft.AspNetCore.Mvc;

namespace KUSYS_Demo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(int id)
        {
            return View();
        }
        
        public IActionResult List()
        {
            return View();
        }

        [HttpPost]
        public IActionResult List(int id)
        {
            return View();
        }
    }
}
