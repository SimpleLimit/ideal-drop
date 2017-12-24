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
                return Ok(true);
            }
            return BadRequest("Bad data");
        }
    }
}