using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class MikroDbContext : DbContext
    {
        public MikroDbContext(DbContextOptions<MikroDbContext> options) 
        : base(options)
        {

        }
        public DbSet<Depo> DEPOLAR {get; set;}
    }
}