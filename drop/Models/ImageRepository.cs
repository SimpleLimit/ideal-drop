using System.Collections.Generic;
using System.Linq;
using drop.Models.Entity;

namespace drop.Models
{
    public class ImageRepository : IImageRepository
    {
        private readonly ImageContext _context;

        public ImageRepository(ImageContext context)
        {
            _context = context;
        }

        public IEnumerable<Image> GetAllImages()
        {
            return _context.Images.ToList();
        }
    }
}