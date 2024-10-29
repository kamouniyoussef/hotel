

using gestion_hotel.Models;
using Microsoft.EntityFrameworkCore;
 
namespace gestion_hotel.Data
{
    public class AppDbContext : DbContext
    { 
       public AppDbContext(DbContextOptions<AppDbContext> options ):base(options) {
 


        }
        public DbSet<Chambre> Chambres { get; set; }
    }
}
