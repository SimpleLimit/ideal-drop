using System.Collections.Generic;
using System.Threading.Tasks;
using drop.Models.Entity;

namespace drop.Models
{
    public interface IImageRepository
    {
        IEnumerable<Image> GetAllImages();

        void AddImage(Image image);

        Task<bool> SaveChangesAsync();
    }
}