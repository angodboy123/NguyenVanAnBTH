using Microsoft.AspNetCore.Mvc;
using demoan.Models;

namespace demoan.Controllers
{
        public class StudentController : Controller
    {
        //cac action
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string StudentID, string StudentName, string StudentAge)
        {
            ViewBag.mess = "ID: " + StudentID + " - Tên SV: " + StudentName + " - Tuổi: " + StudentAge;
            return View();
        }
    }
}