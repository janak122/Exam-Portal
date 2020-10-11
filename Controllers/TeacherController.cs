using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ExamPortal.DTOS;
using Microsoft.AspNetCore.Mvc;

namespace ExamPortal.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MakePaper()
        {
            return View();
        }
        public IActionResult MakePaper(MCQPaperDTO paper)
        {
            TempData["Message"] = JsonSerializer.Serialize<MCQPaperDTO>(paper);
            return RedirectToAction("index", "home");
        }
    }
}