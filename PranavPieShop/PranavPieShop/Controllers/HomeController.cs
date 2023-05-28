using Microsoft.AspNetCore.Mvc;

using PranavPieShop.Models;
using PranavPieShop.ViewModels;

namespace PranavPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var pieOfWeek = _pieRepository.PiesOfTheWeek;
            var homeViewModel = new HomeViewModel(pieOfWeek);
            return View(homeViewModel);
        }
    }
}
