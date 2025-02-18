using AuthProject.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthProject.Api.DBContext
{
    public class AgendaDB(DbContextOptions<AgendaDB> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
