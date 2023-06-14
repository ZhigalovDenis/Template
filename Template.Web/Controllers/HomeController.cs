using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Template.Domain.Interfaces.Services;
using Template.Web.Models;

namespace Template.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICommonService _commonService;

        public HomeController(ILogger<HomeController> logger, ICommonService commonService)
        {
            _logger = logger;
            _commonService = commonService;
        }

        public IActionResult Index()
        {
            _commonService.GetAll();
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