using System.Linq;
using System.Threading.Tasks;
using drop.Models.Entity;

namespace drop.Models
{
    public class ImageContextSeedData
    {
        private readonly ImageContext _context;

        public ImageContextSeedData(ImageContext context)
        {
            _context = context;
        }

        public async Task EnsureSeedData()
        {
            if (!_context.Images.Any())
            {
                var imgOne = new Image
                {
                    Data = "Somethign for now"
                };

                _context.Images.Add(imgOne);

                await _context.SaveChangesAsync();
            }
        }
    }
}