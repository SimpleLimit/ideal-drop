using drop.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace drop.Models
{
    public class ImageContext : DbContext
    {
        private IConfiguration _config;

        public ImageContext(IConfiguration config, DbContextOptions options) 
            : base(options)
        {
            _config = config;
        }

        public DbSet<Image> Images { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_config["ConnectionStrings:ImageContextConnection"]);
        }
    }
}