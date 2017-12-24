using System.Threading.Tasks;
using AutoMapper;
using drop.Models;
using drop.Models.Entity;
using drop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace drop.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageRepository _imageRepository;

        public ImageController(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        [HttpPost("image/upload")]
        public async Task<IActionResult> Post([FromBody]ImageViewModel image)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newImage = Mapper.Map<Image>(image);
            _imageRepository.AddImage(newImage);

            if (await _imageRepository.SaveChangesAsync())
            {
                return Ok(Mapper.Map<ImageViewModel>(newImage));
            }
            return BadRequest("Failed to save");
        }
    }
}