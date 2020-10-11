using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamPortal.DTOS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;

namespace ExamPortal.Controllers
{
    public class StudentController : Controller
    {
        public StudentController()
        {
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetPaper()
        {
            MCQPaperDTO paper = new MCQPaperDTO();
            paper.Questions.Add(new MCQQuestionDTO()
            {
                QuestionText = "what is your favourite Color ?",
                Opetions = new List<string>() { "blue", "red", "white", "black" }
            });
            paper.Questions.Add(new MCQQuestionDTO()
            {
                QuestionText = "which is your favourite City ?",
                Opetions = new List<string>() { "surat", "Baroda", "Navsari", "Rajkot" }
            });
            return View(paper);
        }
        [HttpPost]
        public IActionResult SubmitPaper(MCQPaperDTO mCQPaperDTO)
        {
            TempData["Message"] = JsonSerializer.Serialize<MCQPaperDTO>(mCQPaperDTO);
            return RedirectToAction("Index", "home");
        }
    }
}