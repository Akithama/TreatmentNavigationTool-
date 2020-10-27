using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Unum.BusinessLogic.Service.Interfaces;
using Unum.Common;
using Unum.Web.Models;

namespace Unum.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IQuestionnaireService _QuestionnaireService;

        public HomeController(ILogger<HomeController> logger, IQuestionnaireService QuestionnaireService)
        {
            _logger = logger;
            _QuestionnaireService = QuestionnaireService;
        }

        public IActionResult Index()
        {
            var questions = _QuestionnaireService.PullQuestions();
            ViewBag.Questions = questions;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
