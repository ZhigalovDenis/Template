using Microsoft.EntityFrameworkCore;
using Template.DAL.Entitys;

namespace Template.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<One> Ones { get; set; }
        public DbSet<Many> Manys { get; set; }
    }
}