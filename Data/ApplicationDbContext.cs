using MacAddress.Models;
using Microsoft.EntityFrameworkCore;

namespace MacAddress.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<MacAddresses> macaddresses { get; set;}
    }
}