using System.Collections.Generic;
using drop.Models.Entity;

namespace drop.Models
{
    public interface IImageRepository
    {
        IEnumerable<Image> GetAllImages();
    }
}