using Microsoft.AspNetCore.Mvc;
using APIMiniProject.Services;
using APIMiniProject.Interfaces;
using APIMiniProject.Models;

namespace APIMiniProject.Controllers
{
    public class GifsController : Controller
    {
        private readonly IGifsAPIService _gifAPIService;

        public GifsController(IGifsAPIService gifsAPIService)
        {
            _gifAPIService = gifsAPIService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
