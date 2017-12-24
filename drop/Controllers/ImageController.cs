using AutoMapper;
using drop.Models.Entity;
using drop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace drop.Controllers
{
    [Route("image/upload")]
    public class ImageController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody]ImageViewModel image)
        {
            if (ModelState.IsValid)
            {
                var newImage = Mapper.Map<Image>(image);

                return Ok(true);
            }
            return BadRequest("Bad data");
        }
    }
}