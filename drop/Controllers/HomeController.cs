using System.Diagnostics;
using drop.Models;
using Microsoft.AspNetCore.Mvc;
using drop.Models.ViewModels;

namespace drop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IImageRepository _imageRepository;

        public HomeController(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public IActionResult Index()
        {
            var images = _imageRepository.GetAllImages();

            return View(images);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
